using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

/// <summary>
/// Defines properties common to all Vertex Attributes.
/// </summary>
public interface IVertexAttribute
{
    /// <summary>
    /// The index (location) of the attribute.
    /// </summary>
    int Index { get; }

    /// <summary>
    /// The size (in bytes) of the attribute data type.
    /// </summary>
    int TypeSize { get; }

    /// <summary>
    /// The type of data being represented by the attribute.
    /// </summary>
    VertexAttribType AttribType { get; }

    /// <summary>
    /// Determines how many components the data type has. A count of one defines a scalar type, while two or more configure the type as a vector.
    /// </summary>
    int ComponentCount { get; }

    /// <summary>
    /// Indicates whether fixed-point data types should be normalized.
    /// </summary>
    bool Normalized { get; }
}
