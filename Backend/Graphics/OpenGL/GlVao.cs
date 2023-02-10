using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

// NOTE: Instead of dictionaries, create new types for Binding Points and Vertex Attributes.
// NOTE: Add functionality to enable/disable individual vertex attributes (and all of them at the same time as well).

/// <summary>
/// Represents a Vertex Array Object.
/// </summary>
public class GlVao : IBindableGlObject
{
    /// <summary>
    /// A collection of binding points, subdividing the underlying source buffer for use by the vertex attributes.
    /// </summary>
    /// <remarks>
    /// The <see cref="int"/> key represents the binding point index (not to be confused with vertex attribute indices), while the <see cref="int"/> value represents
    /// an offset (starting at the beginning of the source buffer) from where a binding point takes its data from.
    /// </remarks>
    private readonly Dictionary<int, int> BindingPoints = new();

    /// <summary>
    /// A collection of vertex attributes, specifying the data format of the source buffer.
    /// </summary>
    /// <remarks>
    /// The <see cref="int"/> key represents the binding point associated with the vertex attributes, while the <see cref="int"/> value represents the vertex attributes themselves.
    /// </remarks>
    private readonly Dictionary<int, List<IVertexAttribute>> Attributes = new();

    /// <summary>
    /// The name of the VAO.
    /// </summary>
    public int Id { get; private set; }

    // FIXME: Add better validation: check if its bound, if all attributes and binding points make sense, if it was properly setup and other sanity checks
    /// <summary>
    /// Determines whether the VAO is properly configured to be used for rendering.
    /// </summary>
    public bool Valid => BindingPoints.Count != 0 && Attributes.Count != 0 && Id != 0;

    /// <summary>
    /// Generates a new name for the VAO.
    /// </summary>
    public void Create()
    {
        Id = GL.GenVertexArray();
    }

    /// <summary>
    /// Deletes the VAO from the context.
    /// </summary>
    public void Delete()
    {
        GL.DeleteVertexArray(Id);
        Id = 0;
    }

    /// <summary>
    /// Binds the VAO to the context.
    /// </summary>
    public void Bind()
    {
        GL.BindVertexArray(Id);
    }

    /// <summary>
    /// Unbins the currently active VAO from the context.
    /// </summary>
    public static void Unbind()
    {
        GL.BindVertexArray(0);
    }

    /// <summary>
    /// Adds a binding point description to the internal storage of this <see cref="GlVao"/> instance.
    /// </summary>
    /// <remarks>
    /// In order to actually use this binding point on OpenGL, make sure to call <see cref="Setup(GlBuffer)"/> after all binding points and attributes have been added.
    /// </remarks>
    /// <param name="bindingIndex"></param>
    /// <param name="baseOffset"></param>
    public void AddBindingPoint(int bindingIndex, int baseOffset)
    {
        BindingPoints.Add(bindingIndex, baseOffset);
    }

    /// <summary>
    /// Adds a vertex attribute description to the internal storage of this <see cref="GlVao"/> instance.
    /// </summary>
    /// <remarks>
    /// In order to actually use this vertex attribute on OpenGL, make sure to call <see cref="Setup(GlBuffer)"/> after all binding points and attributes have been added.
    /// </remarks>
    /// <param name="bindingIndex">The index of the binding point.</param>
    /// <param name="attribute">The vertex attribute description.</param>
    public void AddVertexAttribute(int bindingIndex, IVertexAttribute attribute)
    {
        if (!Attributes.ContainsKey(bindingIndex))
        {
            Attributes.Add(bindingIndex, new List<IVertexAttribute>());
        }

        Attributes[bindingIndex].Add(attribute);
    }

    /// <summary>
    /// Uses the provided information to specify how the source buffer will be accessed by OpenGL.
    /// </summary>
    /// <remarks>All vertex attributes are enabled by default when calling this method.</remarks>
    /// <param name="source">The vertex data source of the VAO.</param>
    public void Setup(GlBuffer source)
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
}