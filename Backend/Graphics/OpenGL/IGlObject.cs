namespace Backend.Graphics.OpenGL;

/// <summary>
/// Defines a common contract followed by most OpenGL objects.
/// </summary>
public interface IGlObject
{
    /// <summary>
    /// The name of the object.
    /// </summary>
    int Id { get; }

    /// <summary>
    /// Determines whether the object is in a valid state and ready to be used.
    /// </summary>
    bool Valid { get; }

    /// <summary>
    /// Generates a new name for this object.
    /// </summary>
    void Create();

    /// <summary>
    /// Deletes the object from the context.
    /// </summary>
    void Delete();
}
