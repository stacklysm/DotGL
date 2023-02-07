using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

public class GlProgramPipeline : IBindableGlObject
{
    private List<GlProgram> Pipeline { get; set; } = new();

    public int Id { get; private set; }

    public void Create()
    {
        Id = GL.GenProgramPipeline();
    }

    public void Delete()
    {
        GL.DeleteProgramPipeline(Id);
        Id = 0;
    }

    public void Bind()
    {
        GL.BindProgramPipeline(Id);
    }

    public void Unbind()
    {
        GL.BindProgramPipeline(0);
    }

    // NOTE: This function returns the created program to allow the user to perform pre-linking steps. This function will detach and delete the shaders once it returns
    public GlProgram AddStage(GlShader[] shaders, Action<GlProgram>? preLinkOperation = null)
    {
        GlProgram stageProgram = new(true);
        stageProgram.Create();

        foreach (var shader in shaders)
        {
            shader.Compile();
            stageProgram.AttachShader(shader);
        }

        preLinkOperation?.Invoke(stageProgram);
        stageProgram.Link();

        foreach (var shader in shaders)
        {
            stageProgram.DetachShader(shader);
            shader.Delete();
        }

        Pipeline.Add(stageProgram);

        return stageProgram;
    }

    public void UseStages(ProgramStageMask stageMask, GlProgram program)
    {
        GL.UseProgramStages(Id, stageMask, program.Id);
    }
}
