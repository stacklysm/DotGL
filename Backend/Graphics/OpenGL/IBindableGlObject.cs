namespace Backend.Graphics.OpenGL;

/// <summary>
/// Defines a contract for object types that can be bound to (and unbound from) the OpenGL context.
/// </summary>
public interface IBindableGlObject : IGlObject
{
    /// <summary>
    /// Binds the object to the current OpenGL context.
    /// </summary>
    void Bind();

    /// <summary>
    /// Unbinds the object from the OpenGL context.
    /// </summary>
    /// <remarks>This function should set the <see cref="IGlObject.Id"/> property to 0 before returning.</remarks>
    void Unbind();
}
