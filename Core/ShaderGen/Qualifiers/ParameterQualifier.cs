namespace Core.ShaderGen.Qualifiers;

public class ParameterQualifier : IQualifier
{
    private string Name { get; }

    private ParameterQualifier(string name)
    {
        Name = name;
    }

    public static ParameterQualifier Const() => new("const");

    public static ParameterQualifier In() => new("in");

    public static ParameterQualifier Out() => new("out");

    public static ParameterQualifier InOut() => new("inout");

    public string GetQualifier() => Name;
}
