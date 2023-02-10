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
    /// Gets the location of an uniform and stores it in memory.
    /// </summary>
    /// <param name="uniformName">The name of the uniform.</param>
    /// <exception cref="OpenGLException">Thrown when the uniform name could not be located.</exception>
    /// <returns>The location of the uniform.</returns>
    private int GetUniformLocation(string uniformName)
    {
        int uniformLocation = GL.GetUniformLocation(Id, uniformName);

        if (uniformLocation == Constants.UNIFORM_NOT_FOUND)
        {
            throw new OpenGLException(Constants.ERROR_UNIFORM_NOT_FOUND, (int)GL.GetError());
        }

        UniformCache.Add(uniformName, uniformLocation);

        return uniformLocation;
    }

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
    /// <remarks>Detaching a shader from the program allows it to be deleted when calling <see cref="GlShader.Delete"/>.</remarks>
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
    /// Unbinds the currently active program from the OpenGL context.
    /// </summary>
    public static void Unbind()
    {
        GL.UseProgram(0);
    }

    /// <summary>
    /// Sets the value of an uniform variable.
    /// </summary>
    /// <typeparam name="TUniform">The type of the variable.</typeparam>
    /// <param name="uniformName">The name of the uniform.</param>
    /// <param name="value">The value being assigned to the uniform.</param>
    /// <param name="transposeMatrix">
    /// Indicates whether a matrix should be transposed, defaults to <see langword="false"/>.
    /// </param>
    /// <exception cref="OpenGLException">Thrown when the uniform name could not be located.</exception>
    public void SetUniform<TUniform>(string uniformName, TUniform value, bool transposeMatrix = false)
        where TUniform : struct
    {
        ProgramUniformSet.ProgramId = Id;
        ProgramUniformSet.UniformLocation = UniformCache.TryGetValue(uniformName, out int uniformLocation) ? uniformLocation : GetUniformLocation(uniformName);
        ProgramUniformSet.SetUniform(value, transposeMatrix);
    }

    /// <summary>
    /// Sets the value of an uniform array variable.
    /// </summary>
    /// <typeparam name="TUniform">The type of the array.</typeparam>
    /// <param name="uniformName">The name of the uniform.</param>
    /// <param name="value">The array being assigned to the uniform.</param>
    /// <param name="transposeMatrices">
    /// Indicates whether all matrices in the array should be transposed, defaults to <see langword="false"/>.
    /// </param>
    /// <exception cref="OpenGLException">Thrown when the uniform name could not be located.</exception>
    public void SetUniformArray<TUniform>(string uniformName, TUniform[] value, bool transposeMatrices = false)
        where TUniform : struct
    {
        ProgramUniformSet.ProgramId = Id;
        ProgramUniformSet.UniformLocation = UniformCache.TryGetValue(uniformName, out int uniformLocation) ? uniformLocation : GetUniformLocation(uniformName);
        ProgramUniformSet.SetUniform(value, transposeMatrices);
    }

    /// <summary>
    /// Gets the value of a uniform variable.
    /// </summary>
    /// <typeparam name="TUniform">The type of the uniform.</typeparam>
    /// <param name="uniformName">The name of the uniform.</param>
    /// <returns>The value of the uniform.</returns>
    /// <exception cref="OpenGLException">Thrown when the uniform name could not be located.</exception>
    public TUniform GetUniform<TUniform>(string uniformName)
        where TUniform : struct
    {
        ProgramUniformSet.ProgramId = Id;
        ProgramUniformSet.UniformLocation = UniformCache.TryGetValue(uniformName, out int uniformLocation) ? uniformLocation : GetUniformLocation(uniformName);

        return ProgramUniformGet.GetUniform<TUniform>();
    }

    /// <summary>
    /// Gets the value of a uniform array variable.
    /// </summary>
    /// <typeparam name="TUniform">The type of the array.</typeparam>
    /// <param name="uniformName">The name of the uniform.</param>
    /// <param name="length">The number of elements in the array.</param>
    /// <returns>The value of the array uniform.</returns>
    /// <exception cref="OpenGLException">Thrown when the uniform name could not be located.</exception>
    public TUniform[] GetArrayUniform<TUniform>(string uniformName, int length)
        where TUniform : struct
    {
        ProgramUniformSet.ProgramId = Id;
        ProgramUniformSet.UniformLocation = UniformCache.TryGetValue(uniformName, out int uniformLocation) ? uniformLocation : GetUniformLocation(uniformName);

        return ProgramUniformGet.GetUniform<TUniform>(length);
    }
}
