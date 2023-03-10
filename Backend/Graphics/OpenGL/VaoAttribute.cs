using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;

namespace Backend.Graphics.OpenGL;

/// <summary>
/// Represents a vertex attribute, used in Vertex Array Objects to specify the data format used by a buffer.
/// </summary>
/// <typeparam name="T">The vertex attribute data type.</typeparam>
public readonly struct VertexAttribute<T> : IVertexAttribute
    where T : struct
{
    /// <summary>
    /// The location of the attribute in the Vertex Input.
    /// </summary>
    public int Index { get; init; }

    /// <summary>
    /// The size (in bytes) of the attribute data type.
    /// </summary>
    public int TypeSize { get; init; }

    /// <summary>
    /// The type of data being represented by the attribute.
    /// </summary>
    public VertexAttribType AttribType { get; init; }

    /// <summary>
    /// Determines how many components the data type has. A count of one defines a scalar type, while two or more configure the type as a vector.
    /// </summary>
    public int ComponentCount { get; init; }

    /// <summary>
    /// Indicates whether fixed-point data types should be normalized.
    /// </summary>
    public bool Normalized { get; init; }

    // NOTE: do not use doubles, they affect performance negatively
    /// <summary>
    /// Decomposes a data type into three distinct parts: The size (in bytes), number of components and the base, primitive type.
    /// </summary>
    /// <typeparam name="TValue">The type to be analysed.</typeparam>
    /// <returns>The type description.</returns>
    /// <exception cref="NotImplementedException">Thrown when the type provided doesn't have a description.</exception>
    public static (int TypeSize, int ComponentCount, VertexAttribType PointerType) GetTypeDescription<TValue>()
        where TValue : struct
    {
        return new TValue() switch
        {
            byte => (sizeof(byte), 1, VertexAttribType.UnsignedByte),
            sbyte => (sizeof(sbyte), 1, VertexAttribType.Byte),
            short => (sizeof(short), 1, VertexAttribType.Short),
            ushort => (sizeof(ushort), 1, VertexAttribType.UnsignedShort),
            int => (sizeof(int), 1, VertexAttribType.Int),
            Vector2i => (sizeof(int), 2, VertexAttribType.Int),
            Vector3i => (sizeof(int), 3, VertexAttribType.Int),
            Vector4i => (sizeof(int), 4, VertexAttribType.Int),
            uint => (sizeof(uint), 1, VertexAttribType.UnsignedInt),
            Vector2ui => (sizeof(uint), 2, VertexAttribType.UnsignedInt),
            Vector3ui => (sizeof(uint), 3, VertexAttribType.UnsignedInt),
            Vector4ui => (sizeof(uint), 4, VertexAttribType.UnsignedInt),
            float => (sizeof(float), 1, VertexAttribType.Float),
            Vector2 => (sizeof(float), 2, VertexAttribType.Float),
            Vector3 => (sizeof(float), 3, VertexAttribType.Float),
            Vector4 => (sizeof(float), 4, VertexAttribType.Float),
            double => (sizeof(double), 1, VertexAttribType.Double),
            Vector2d => (sizeof(double), 2, VertexAttribType.Double),
            Vector3d => (sizeof(double), 3, VertexAttribType.Double),
            Vector4d => (sizeof(double), 4, VertexAttribType.Double),
            _ => throw new NotImplementedException()
        };
    }

    /// <summary>
    /// Initializes a new instance of <see cref="VertexAttribute{T}"/>.
    /// </summary>
    /// <param name="index">The location of the attribute.</param>
    /// <param name="normalized">Indicates whether fixed-point values should be normalized. Defaults to <see langword="false"/>.</param>
    public VertexAttribute(int index, bool normalized = false)
    {
        Index = index;
        (TypeSize, ComponentCount, AttribType) = GetTypeDescription<T>();
        Normalized = normalized;
    }
}