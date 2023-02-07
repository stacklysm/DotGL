using Backend.Graphics.OpenGL;

using OpenTK.Graphics.OpenGL4;

using System.Text;

namespace Rendering.Shader;

public class ShaderBuilder
{
    private ShaderType ShaderType { get; set; }
    private List<GlslVertexAttribute> VertexAttributes { get; set; } = new();
    private List<GlslVariable> Inputs { get; set; } = new();
    private List<GlslVariable> Outputs { get; set; } = new();
    private List<GlslVariable> Uniforms { get; set; } = new();
    private List<string> Statements { get; set; } = new();

    public ShaderBuilder(ShaderType shaderType)
    {
        ShaderType = shaderType;
    }

    public void VertexInput(GlslDataType dataType, string name, int location)
    {
        VertexAttributes.Add(new(dataType, name, location));
    }

    public void Input(GlslDataType dataType, string name)
    {
        Inputs.Add(new(dataType, name));
    }

    public void Output(GlslDataType dataType, string name)
    {
        Outputs.Add(new(dataType, name));
    }

    public void Uniform(GlslDataType dataType, string name)
    {
        Uniforms.Add(new(dataType, name));
    }

    public void Statement(string statement)
    {
        Statements.Add(statement);
    }

    public GlShader BuildShader(bool fixKhronosNonsense = false)
    {
        StringBuilder builder = new();

        builder.AppendLine("#version 460 core\n");

        if (fixKhronosNonsense)
        {
            builder.AppendLine("out gl_PerVertex\n{");
            builder.AppendLine("\tvec4 gl_Position;");
            builder.AppendLine("\tfloat gl_PointSize;");
            builder.AppendLine("\tfloat[] gl_ClipDistance;");
            builder.AppendLine("};\n");
        }

        for (int i = 0; i < VertexAttributes.Count; i++)
        {
            var vertexAttribute = VertexAttributes[i];

            builder.AppendLine(GlslExpressionBuilder.DeclareVariable(GlslVariableType.VertexInput, vertexAttribute.DataType, vertexAttribute.Name, i));
        }

        foreach (var input in Inputs)
        {
            builder.AppendLine(GlslExpressionBuilder.DeclareVariable(GlslVariableType.Input, input.DataType, input.Name));
        }

        builder.AppendLine();

        foreach (var output in Outputs)
        {
            builder.AppendLine(GlslExpressionBuilder.DeclareVariable(GlslVariableType.Output, output.DataType, output.Name));
        }

        builder.AppendLine();

        foreach (var uniform in Uniforms)
        {
            builder.AppendLine(GlslExpressionBuilder.DeclareVariable(GlslVariableType.Uniform, uniform.DataType, uniform.Name));
        }

        builder.AppendLine();

        builder.AppendLine(GlslExpressionBuilder.BeginMain());

        foreach (var statement in Statements)
        {
            builder.AppendLine($"\t{statement};");
        }

        builder.AppendLine(GlslExpressionBuilder.EndMain());

        GlShader shader = new(builder.ToString(), ShaderType);
        shader.Create();

        return shader;
    }
}
