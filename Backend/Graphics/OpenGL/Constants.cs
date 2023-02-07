namespace Backend.Graphics.OpenGL;

public static class Constants
{
    public const int GL_TRUE = 1;
    public const int UNIFORM_NOT_FOUND = -1;

    public const string ERROR_GEN_INVALID_TYPE = "The type provided is invalid for this function";
    public const string ERROR_SHADER_COMPILATION = "Could not compile shader.";
    public const string ERROR_PROGRAM_LINKING = "Could not link program.";
    public const string ERROR_UNIFORM_NOT_FOUND = "Could not find uniform location.";
    public const string ERROR_INVALID_UNIFORM_TYPE = "Invalid uniform data type for this function.";
    public const string ERROR_MODIFYING_LOCKED_VAO = "Cannot modify a locked VAO.";
    public const string ERROR_EMPTY_VAO = "Cannot submit a VAO without attributes.";
    public const string ERROR_ATTRIBUTE_NOT_FOUND = "The attribute specified does not exist for this VAO.";
    public const string ERROR_BINARY_SHADER_NOT_FOUND = "Cannot find shader in the specified path.";
    public const string ERROR_TEXTURE_PARAMETER_NOT_SUPORTED = "This texture parameter is not supported yet.";
}
