using Backend.Graphics.OpenGL.Helper;

using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

public class GlProgram : IGlObject
{
    private bool LinkedInternal = false;
    private Dictionary<string, int> UniformCache = new(); 

    public bool Separable { get; private set; }
    public int Id { get; private set; }
    public bool Linked => Id != 0 && LinkedInternal;

    public GlProgram(bool separable = false)
    {
        Separable = separable;
    }

    public void Create()
    {
        Id = GL.CreateProgram();
        GL.ProgramParameter(Id, ProgramParameterName.ProgramSeparable, Separable ? Constants.GL_TRUE : 0);
    }

    public void Delete()
    {
        GL.DeleteProgram(Id);
        Id = 0;
    }

    public void AttachShader(GlShader shader)
    {
        GL.AttachShader(Id, shader.Id);
    }

    public void DetachShader(GlShader shader)
    {
        GL.DetachShader(Id, shader.Id);
    }

    public void Link()
    {
        GL.LinkProgram(Id);

        GL.GetProgram(Id, GetProgramParameterName.LinkStatus, out int linkStatus);

        if (linkStatus != Constants.GL_TRUE)
        {
            throw new OpenGLException($"{Constants.ERROR_PROGRAM_LINKING} Log:\n{GL.GetProgramInfoLog(Id)}", (int)GL.GetError());
        }

        LinkedInternal = true;
    }

    public void Use()
    {
        GL.UseProgram(Id);
    }

    public static void UnbindCurrentProgram()
    {
        GL.UseProgram(0);
    }

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

    public void SetUniformArray<TUniform>(string uniformName, TUniform[] value, bool transposeMatrix = false)
        where TUniform : struct
    {
        int uniformLocation = GL.GetUniformLocation(Id, uniformName);

        if (uniformLocation == Constants.UNIFORM_NOT_FOUND)
        {
            throw new OpenGLException(Constants.ERROR_UNIFORM_NOT_FOUND, (int)GL.GetError());
        }

        ProgramUniformSet.ProgramId = Id;
        ProgramUniformSet.UniformLocation = uniformLocation;
        ProgramUniformSet.SetUniform(value, transposeMatrix);
    }

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

    public TUniform[] GetUniformArray<TUniform>(string uniformName, int length)
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
