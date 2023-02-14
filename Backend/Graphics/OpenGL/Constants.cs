namespace Backend.Graphics.OpenGL;

public static class Constants
{
    /// <summary>
    /// Represents the <see langword="true"/> value in OpenGL.
    /// </summary>
    public const int GL_TRUE = 1;

    /// <summary>
    /// Returned by the function GL.GetUniformLocation, it indicates that the uniform could not be found.
    /// </summary>
    public const int UNIFORM_NOT_FOUND = -1;

    public const string ERROR_SHADER_COMPILATION = "An error occurred during shader compilation.";
    public const string ERROR_PROGRAM_LINKING = "An error occurred during program linking.";
    public const string ERROR_UNIFORM_NOT_FOUND = "The uniform could not be located in this program.";
    public const string ERROR_INVALID_UNIFORM_TYPE = "The type provided is not supported by this function.";
    public const string ERROR_MODIFYING_LOCKED_VAO = "Cannot modify a locked VAO.";
    public const string ERROR_EMPTY_VAO = "Cannot submit a VAO without attributes.";
    public const string ERROR_ATTRIBUTE_NOT_FOUND = "The attribute specified does not exist for this VAO.";
    public const string ERROR_BINARY_SHADER_NOT_FOUND = "Cannot find shader in the specified path.";
    public const string ERROR_TEXTURE_PARAMETER_NOT_SUPORTED = "This texture parameter is not supported yet.";
}
