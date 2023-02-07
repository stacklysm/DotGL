using OpenTK.Graphics.OpenGL4;

using System.Text;

namespace Backend.Graphics.OpenGL;

public class GlVao : IBindableGlObject
{
    private readonly Dictionary<int, int> BindingPoints = new();
    private readonly Dictionary<int, List<IVertexAttribute>> Attributes = new();

    public int Id { get; private set; }

    public void Create()
    {
        Id = GL.GenVertexArray();
    }

    public void Delete()
    {
        GL.DeleteVertexArray(Id);
        Id = 0;
    }

    public void Bind()
    {
        GL.BindVertexArray(Id);
    }

    public void Unbind()
    {
        GL.BindVertexArray(0);
    }

    // NOTE: Finish source buffer implementation
    public void AddAttribute(int bindingIndex, IVertexAttribute attribute)
    {
        if (!Attributes.ContainsKey(bindingIndex))
        {
            Attributes.Add(bindingIndex, new List<IVertexAttribute>());
        }

        Attributes[bindingIndex].Add(attribute);
    }

    public void AddBindingPoint(int bindingIndex, int baseOffset)
    {
        BindingPoints.Add(bindingIndex, baseOffset);
    }

    public void AddVertexAttribute(int bindingIndex, IVertexAttribute attribute)
    {
        if (!Attributes.ContainsKey(bindingIndex))
        {
            Attributes.Add(bindingIndex, new List<IVertexAttribute>());
        }

        Attributes[bindingIndex].Add(attribute);
    }

    public void SetupAttributes(GlBuffer source)
    {
        foreach (var (bindingIndex, baseOffset) in BindingPoints)
        {
            int relativeOffset = 0;
            int stride = Attributes[bindingIndex].Sum(x => x.ComponentCount * x.TypeSize);
            GL.BindVertexBuffer(bindingIndex, source.Id, baseOffset, stride);

            foreach (var vertexAttribute in Attributes[bindingIndex])
            {
                GL.EnableVertexAttribArray(vertexAttribute.Index);
                GL.VertexAttribFormat(vertexAttribute.Index, vertexAttribute.ComponentCount, vertexAttribute.AttribType, vertexAttribute.Normalized, relativeOffset);
                GL.VertexAttribBinding(vertexAttribute.Index, bindingIndex);

                relativeOffset += vertexAttribute.ComponentCount * vertexAttribute.TypeSize;
            }
        }
    }

    public void EnableAllAttributes()
    {
        foreach (var attribute in Attributes.Values.SelectMany(x => x))
        {
            GL.EnableVertexAttribArray(attribute.Index);
        }
    }

    public void DisableAllAtributes()
    {
        foreach (var attribute in Attributes.Values.SelectMany(x => x))
        {
            GL.DisableVertexAttribArray(attribute.Index);
        }
    }
}