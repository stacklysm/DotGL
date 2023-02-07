using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;

namespace Backend.Graphics.OpenGL;

public readonly struct VertexAttribute<T> : IVertexAttribute
    where T : struct
{
    public int Index { get; init; }
    public int TypeSize { get; init; }
    public int ComponentCount { get; init; }
    public VertexAttribType AttribType { get; init; }
    public bool Normalized { get; init; }

    // NOTE: do not use doubles, they affect performance negatively
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
            _ => throw new InvalidOperationException()
        };
    }

    public VertexAttribute(int index, bool normalized = false)
    {
        Index = index;
        (TypeSize, ComponentCount, AttribType) = GetTypeDescription<T>();
        Normalized = normalized;
    }
}