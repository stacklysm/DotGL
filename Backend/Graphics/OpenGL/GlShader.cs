using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

/// <summary>
/// Represents a shader object.
/// </summary>
public class GlShader : IGlObject
{
	/// <summary>
	/// Determines whether the shader is compiled.
	/// </summary>
	private bool Compiled = false;

	/// <summary>
	/// The source code of the shader.
	/// </summary>
	public string ShaderSource { get; init; }

	/// <summary>
	/// The type of the shader.
	/// </summary>
	public ShaderType ShaderType { get; init; }

	/// <summary>
	/// The name of the shader object.
	/// </summary>
	public int Id { get; private set; }

	/// <summary>
	/// Determines whether the shader has an assigned name and is compiled.
	/// </summary>
	public bool Valid => Id != 0 && Compiled;

	/// <summary>
	/// Initializes a new instance of <see cref="GlShader"/>.
	/// </summary>
	/// <param name="shaderSource">The source code of the shader.</param>
	/// <param name="shaderType">The type of the shader.</param>
	public GlShader(string shaderSource, ShaderType shaderType)
	{
		ShaderSource = shaderSource;
		ShaderType = shaderType;
	}

	/// <summary>
	/// Generates a new name for the shader.
	/// </summary>
	public void Create()
	{
		Id = GL.CreateShader(ShaderType);
		GL.ShaderSource(Id, ShaderSource);
	}

    /// <summary>
    /// Deletes the shader object from the OpenGL context.
    /// </summary>
	/// <remarks>OpenGL won't delete the shader immediately if it's attached to a <see cref="GlProgram"/> object.</remarks>
    public void Delete()
	{
		GL.DeleteShader(Id);
		Id = 0;
	}

	/// <summary>
	/// Loads the GLSL script into OpenGL to be used as a shader.
	/// </summary>
	/// <exception cref="OpenGLException">Thrown when shader compilation fails.</exception>
	public void Compile()
	{
		GL.CompileShader(Id);

		GL.GetShader(Id, ShaderParameter.CompileStatus, out int compileStatus);

		if (compileStatus != Constants.GL_TRUE)
		{
			throw new OpenGLException($"{Constants.ERROR_SHADER_COMPILATION} Log:\n{GL.GetShaderInfoLog(Id)}", (int)GL.GetError());
		}

		Compiled = true;
	}
}
