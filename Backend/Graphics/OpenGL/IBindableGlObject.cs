namespace Backend.Graphics.OpenGL;

/// <summary>
/// Defines a common contract for OpenGL objects that can be bound to the OpenGL context.
/// </summary>
public interface IBindableGlObject : IGlObject
{
    /// <summary>
    /// Binds the object to the current OpenGL context.
    /// </summary>
    void Bind();
}
