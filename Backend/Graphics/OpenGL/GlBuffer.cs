using System.Runtime.InteropServices;

using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

public class GlBuffer : IBindableGlObject
{
	public int Id { get; private set; }
	public BufferTarget Target { get; private set; }

	public GlBuffer(BufferTarget target)
	{
		Target = target;
	}

    public void Create()
	{
		Id = GL.GenBuffer();
	}

    public void Delete()
	{
		GL.DeleteBuffer(Id);
		Id = 0;
	}

    public void Bind()
	{
		GL.BindBuffer(Target, Id);
	}

    public void Unbind()
	{
		GL.BindBuffer(Target, 0);
	}

	public void SetData<TData>(TData[] data, BufferUsageHint usageHint)
		where TData : struct
	{
		GL.BufferData(Target, data.Length * Marshal.SizeOf<TData>(), data, usageHint);
	}

	public void SetStorage<TData>(TData[] data, BufferStorageFlags storageFlags)
		where TData : struct
	{
        GL.BufferStorage(Target, data.Length * Marshal.SizeOf<TData>(), data, storageFlags);
	}
}
