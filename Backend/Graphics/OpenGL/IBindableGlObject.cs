namespace Backend.Graphics.OpenGL;

public interface IBindableGlObject : IGlObject
{
    void Bind();
    void Unbind();
}
