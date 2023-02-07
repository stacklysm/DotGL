using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

public class GlShader : IGlObject
{
	private bool CompiledInternal = false;

	public int Id { get; private set; }
	public string ShaderSource { get; init; }
	public ShaderType ShaderType { get; init; }
	public bool Compiled => Id != 0 && CompiledInternal;

	public GlShader(string shaderSource, ShaderType shaderType)
	{
		ShaderSource = shaderSource;
		ShaderType = shaderType;
	}

    public void Create()
	{
		Id = GL.CreateShader(ShaderType);
        GL.ShaderSource(Id, ShaderSource);
    }

    public void Delete()
	{
		GL.DeleteShader(Id);
		Id = 0;
	}

	public void Compile()
	{
		GL.CompileShader(Id);

		GL.GetShader(Id, ShaderParameter.CompileStatus, out int compileStatus);

		if (compileStatus != Constants.GL_TRUE)
		{
			throw new OpenGLException($"{Constants.ERROR_SHADER_COMPILATION} Log:\n{GL.GetShaderInfoLog(Id)}", (int)GL.GetError());
		}

		CompiledInternal = true;
	}
}
