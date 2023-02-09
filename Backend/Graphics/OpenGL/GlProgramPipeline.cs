using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

/// <summary>
/// Represents a program pipeline object.
/// </summary>
public class GlProgramPipeline : IBindableGlObject
{
    /// <summary>
    /// A collection of pipeline stages.
    /// </summary>
    private readonly List<GlProgram> Pipeline = new();

    /// <summary>
    /// Determines whether all program stages are valid.
    /// </summary>
    private bool StagesLinked => Pipeline.All(program => program.Valid);

    /// <summary>
    /// The name of the program pipeline object.
    /// </summary>
    public int Id { get; private set; }

    /// <summary>
    /// Determines whether the program pipeline has an assigned name and all of its stages are also valid.
    /// </summary>
    // FIXME: Add better validation for this type (maybe?)
    public bool Valid => Id != 0 && StagesLinked;

    /// <summary>
    /// Initializes a new instance of <see cref="GlProgramPipeline"/>
    /// </summary>
    public GlProgramPipeline() { }

    /// <summary>
    /// Generates a new name for the program pipeline.
    /// </summary>
    public void Create()
    {
        Id = GL.GenProgramPipeline();
    }

    /// <summary>
    /// Deletes the program pipeline object from the OpenGL context.
    /// </summary>
    public void Delete()
    {
        GL.DeleteProgramPipeline(Id);
        Id = 0;
    }

    /// <summary>
    /// Binds the pipeline program to the OpenGL context.
    /// </summary>
    public void Bind()
    {
        GL.BindProgramPipeline(Id);
    }

    /// <summary>
    /// Unbinds the current pipeline object from the OpenGL context.
    /// </summary>
    public void Unbind()
    {
        GL.BindProgramPipeline(0);
    }

    /// <summary>
    /// Creates a pipeline program stage from a collection of shaders.
    /// </summary>
    /// <param name="shaders">A collection of shaders to be used in this stage. the type of each shader must be unique from each other.</param>
    /// <returns>A separable <see cref="GlProgram"/>, which can be used by this pipeline.</returns>
    public GlProgram AddStage(GlShader[] shaders)
    {
        GlProgram stageProgram = new(true);
        stageProgram.Create();

        foreach (var shader in shaders)
        {
            shader.Compile();
            stageProgram.AttachShader(shader);
        }

        stageProgram.Link();

        foreach (var shader in shaders)
        {
            stageProgram.DetachShader(shader);
            shader.Delete();
        }

        Pipeline.Add(stageProgram);

        return stageProgram;
    }

    /// <summary>
    /// Creates a pipeline program stage from a collection of shaders, while executing an user defined operation before program linking.
    /// </summary>
    /// <param name="shaders">A collection of shaders to be used in this stage. The type of each shader must be unique from each other.</param>
    /// <param name="preLinkOperation">An operation executed to the program before the linking step.</param>
    /// <returns>A separable <see cref="GlProgram"/>, which can be used by this pipeline.</returns>
    /// <exception cref="OpenGLException">
    /// Thrown when either shader compilation or program linking fails. Enable debugging to capture OpenGL errors that might occur in this stage.
    /// </exception>
    public GlProgram AddStage(GlShader[] shaders, Action<GlProgram> preLinkOperation)
    {
        GlProgram stageProgram = new(true);
        stageProgram.Create();

        foreach (var shader in shaders)
        {
            shader.Compile();
            stageProgram.AttachShader(shader);
        }

        preLinkOperation(stageProgram);
        stageProgram.Link();

        foreach (var shader in shaders)
        {
            stageProgram.DetachShader(shader);
            shader.Delete();
        }

        Pipeline.Add(stageProgram);

        return stageProgram;
    }

    /// <summary>
    /// Binds the stages of a program to the pipeline, enabling it to be used by the OpenGL context.
    /// </summary>
    /// <param name="stageMask">Indicates which program stages will be for rendering.</param>
    /// <param name="program">A program containing pipeline stages.</param>
    public void UseStages(ProgramStageMask stageMask, GlProgram program)
    {
        GL.UseProgramStages(Id, stageMask, program.Id);
    }
}
