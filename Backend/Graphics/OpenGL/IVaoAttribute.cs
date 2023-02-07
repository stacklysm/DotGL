using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

public interface IVertexAttribute
{
    int Index { get; }
    int TypeSize { get; }
    int ComponentCount { get; }
    VertexAttribType AttribType { get; }
    bool Normalized { get; }
}
