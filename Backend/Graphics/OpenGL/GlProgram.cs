using Backend.Graphics.OpenGL.Helper;

using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

/// <summary>
/// Represents a program object, containing executable code for one or more <see cref="GlShader"/>.
/// </summary>
public class GlProgram : IGlObject
{
    /// <summary>
    /// Determines whether the program is linked.
    /// </summary>
    private bool Linked = false;

    /// <summary>
    /// Stores the location for every uniform used in SetUniform and GetUniform calls.
    /// </summary>
    private readonly Dictionary<string, int> UniformCache = new();

    /// <summary>
    /// Determines whether the program will be used in a pipeline object.
    /// </summary>
    public bool Separable { get; private set; }

    /// <summary>
    /// The name of the program object.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Determines whether the program has an assigned name and is linked.
    /// </summary>
    public bool Valid => Id != 0 && Linked;

    /// <summary>
    /// Initializes a new instance of <see cref="GlProgram"/>.
    /// </summary>
    /// <param name="separable">Indicates whether the program will be used in a Program Pipeline, defaults to <see langword="false"/>.</param>
    public GlProgram(bool separable = false)
    {
        Separable = separable;
    }

    /// <summary>
    /// Generates a new name for the program.
    /// </summary>
    public void Create()
    {
        Id = GL.CreateProgram();
        GL.ProgramParameter(Id, ProgramParameterName.ProgramSeparable, Separable ? Constants.GL_TRUE : 0);
    }

    /// <summary>
    /// Deletes the program object from the OpenGL context.
    /// </summary>
    public void Delete()
    {
        GL.DeleteProgram(Id);
        Id = 0;
    }

    /// <summary>
    /// Attaches a shader to the program.
    /// </summary>
    /// <remarks>The shader object is expected to be compiled before being attached.</remarks>
    /// <param name="shader">The shader object being attached.</param>
    public void AttachShader(GlShader shader)
    {
        GL.AttachShader(Id, shader.Id);
    }

    /// <summary>
    /// Detaches a shader to the program.
    /// </summary>
    /// <remarks>Detaching a shader allows it to be deleted when calling <see cref="GlShader.Delete"/>.</remarks>
    /// <param name="shader">The shader object being attached.</param>
    public void DetachShader(GlShader shader)
    {
        GL.DetachShader(Id, shader.Id);
    }

    /// <summary>
    /// Links the program to the OpenGL context.
    /// </summary>
    /// <exception cref="OpenGLException">Thrown when program linking fails.</exception>
    public void Link()
    {
        GL.LinkProgram(Id);

        GL.GetProgram(Id, GetProgramParameterName.LinkStatus, out int linkStatus);

        if (linkStatus != Constants.GL_TRUE)
        {
            throw new OpenGLException($"{Constants.ERROR_PROGRAM_LINKING} Log:\n{GL.GetProgramInfoLog(Id)}", (int)GL.GetError());
        }

        Linked = true;
    }

    /// <summary>
    /// Binds the program object to the OpenGL context, allowing it to use and modify the current rendering state.
    /// </summary>
    /// <remarks>
    /// Avoid using this function if <see cref="Separable"/> is <see langword="true"/>, in those cases you should call
    /// <see cref="GlProgramPipeline.UseStages(ProgramStageMask, GlProgram)"/> instead.
    /// </remarks>
    public void Use()
    {
        GL.UseProgram(Id);
    }

    /// <summary>
    /// Unbinds any program from the OpenGL context.
    /// </summary>
    public static void UnbindCurrentProgram()
    {
        GL.UseProgram(0);
    }

    /// <summary>
    /// Specifies a value for the shader program uniform.
    /// </summary>
    /// <typeparam name="TUniform">The type of the uniform (check for compatibility in the project README).</typeparam>
    /// <param name="uniformName">The name of the uniform.</param>
    /// <param name="value">The new value of the uniform.</param>
    /// <param name="transposeMatrix">
    /// For matrix types, it indicates whether the matrix should be transposed before being uploaded to the GPU, defaults to <see langword="false"/>.
    /// </param>
    /// <exception cref="OpenGLException">Thrown when OpenGL is unable to locate the uniform by the name provided.</exception>
    public void SetUniform<TUniform>(string uniformName, TUniform value, bool transposeMatrix = false)
        where TUniform : struct
    {
        int uniformLocation = UniformCache.ContainsKey(uniformName) switch
        {
            true => UniformCache[uniformName],
            false => GL.GetUniformLocation(Id, uniformName)
        };

        if (uniformLocation == Constants.UNIFORM_NOT_FOUND)
        {
            throw new OpenGLException(Constants.ERROR_UNIFORM_NOT_FOUND, (int)GL.GetError());
        }

        ProgramUniformSet.ProgramId = Id;
        ProgramUniformSet.UniformLocation = uniformLocation;
        ProgramUniformSet.SetUniform(value, transposeMatrix);
    }

    /// <summary>
    /// Specifies an array for the shader program uniform.
    /// </summary>
    /// <typeparam name="TUniform">The array type of the uniform (check for compatibility in the project README).</typeparam>
    /// <param name="uniformName">The name of the uniform.</param>
    /// <param name="value">The new value of the uniform.</param>
    /// <param name="transposeMatrices">
    /// For matrix types, it indicates whether all matrices in the array should be transposed before being uploaded to the GPU, defaults to <see langword="false"/>.
    /// </param>
    /// <exception cref="OpenGLException">Thrown when OpenGL is unable to locate the uniform by the name provided.</exception>
    public void SetUniformArray<TUniform>(string uniformName, TUniform[] value, bool transposeMatrices = false)
        where TUniform : struct
    {
        int uniformLocation = GL.GetUniformLocation(Id, uniformName);

        if (uniformLocation == Constants.UNIFORM_NOT_FOUND)
        {
            throw new OpenGLException(Constants.ERROR_UNIFORM_NOT_FOUND, (int)GL.GetError());
        }

        ProgramUniformSet.ProgramId = Id;
        ProgramUniformSet.UniformLocation = uniformLocation;
        ProgramUniformSet.SetUniform(value, transposeMatrices);
    }

    /// <summary>
    /// Retrieves an uniform value from the shader program.
    /// </summary>
    /// <typeparam name="TUniform">The type of the uniform.</typeparam>
    /// <param name="uniformName">The name of the uniform.</param>
    /// <returns>The value of the uniform.</returns>
    /// <exception cref="OpenGLException">Thrown when OpenGL is unable to locate the uniform by the name provided.</exception>
    public TUniform GetUniform<TUniform>(string uniformName)
        where TUniform : struct
    {
        int uniformLocation = GL.GetUniformLocation(Id, uniformName);

        if (uniformLocation == Constants.UNIFORM_NOT_FOUND)
        {
            throw new OpenGLException(Constants.ERROR_UNIFORM_NOT_FOUND, (int)GL.GetError());
        }

        ProgramUniformSet.ProgramId = Id;
        ProgramUniformSet.UniformLocation = uniformLocation;

        return ProgramUniformGet.GetUniform<TUniform>();
    }

    /// <summary>
    /// Retrieves an array uniform from the shader program.
    /// </summary>
    /// <typeparam name="TUniform">The type of the array uniform.</typeparam>
    /// <param name="uniformName">The name of the uniform.</param>
    /// <param name="length">The number of elements in the array uniform.</param>
    /// <returns>The value of the uniform.</returns>
    /// <exception cref="OpenGLException">Thrown when OpenGL is unable to locate the uniform by the name provided.</exception>
    public TUniform[] GetArrayUniform<TUniform>(string uniformName, int length)
        where TUniform : struct
    {
        int uniformLocation = GL.GetUniformLocation(Id, uniformName);

        if (uniformLocation == Constants.UNIFORM_NOT_FOUND)
        {
            throw new OpenGLException(Constants.ERROR_UNIFORM_NOT_FOUND, (int)GL.GetError());
        }

        ProgramUniformSet.ProgramId = Id;
        ProgramUniformSet.UniformLocation = uniformLocation;

        return ProgramUniformGet.GetUniform<TUniform>(length);
    }
}
