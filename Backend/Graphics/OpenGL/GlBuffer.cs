using OpenTK.Graphics.OpenGL4;

using System.Runtime.InteropServices;

namespace Backend.Graphics.OpenGL;

// NOTE: Add support for buffer mapping
/// <summary>
/// Represents a buffer object that holds unformatted memory allocated by the GPU.
/// </summary>
public class GlBuffer : IBindableGlObject
{
    /// <summary>
    /// The target of the buffer.
    /// </summary>
    public BufferTarget Target { get; private set; }

    /// <summary>
    /// The name of the buffer.
    /// </summary>
    public int Id { get; private set; }

    // FIXME: Add better validation: check if its bound and data has been attributed to it
    /// <summary>
    /// Determines whether the buffer has an assigned name.
    /// </summary>
    public bool Valid => Id != 0;

    /// <summary>
    /// Initializes a new instance of <see cref="GlBuffer"/> with a specific target.
    /// </summary>
    /// <param name="target">The target of the buffer.</param>
    public GlBuffer(BufferTarget target)
    {
        Target = target;
    }

    /// <summary>
    /// Generates a new name for the buffer.
    /// </summary>
    public void Create()
    {
        Id = GL.GenBuffer();
    }

    /// <summary>
    /// Deletes the buffer from the context.
    /// </summary>
    public void Delete()
    {
        GL.DeleteBuffer(Id);
        Id = 0;
    }

    /// <summary>
    /// Binds the buffer to the context.
    /// </summary>
    public void Bind()
    {
        GL.BindBuffer(Target, Id);
    }

    /// <summary>
    /// Unbinds the buffer bound at the specified target from the context.
    /// </summary>
    /// <param name="target">The buffer target.</param>
    public static void Unbind(BufferTarget target)
    {
        GL.BindBuffer(target, 0);
    }

    /// <summary>
    /// Creates and initializes the buffer data store.
    /// </summary>
    /// <typeparam name="TData">The type of data stored in the buffer.</typeparam>
    /// <param name="data">The data being uploaded to the GPU.</param>
    /// <param name="usageHint">
    /// Specifies how the data will be accessed and the frequency of these accesses. This serves only as a hint for the OpenGL implementation and doesn't constrain the usage of data.
    /// </param>
    public void SetData<TData>(TData[] data, BufferUsageHint usageHint)
        where TData : struct
    {
        GL.BufferData(Target, data.Length * Marshal.SizeOf<TData>(), data, usageHint);
    }

    /// <summary>
    /// Creates and initializes the buffer immutable data store.
    /// </summary>
    /// <typeparam name="TData">The type of data stored in the buffer.</typeparam>
    /// <param name="data">The data being uploaded to the GPU.</param>
    /// <param name="storageFlags">
    /// Specifies the intended usage of the buffer. These flags define usage constraints and restrict certain kinds of operations in the buffer.
    /// </param>
    public void SetStorage<TData>(TData[] data, BufferStorageFlags storageFlags)
        where TData : struct
    {
        GL.BufferStorage(Target, data.Length * Marshal.SizeOf<TData>(), data, storageFlags);
    }
}
