namespace Core.ShaderGen.Qualifiers;

public class PreciseQualifier : IQualifier
{
    private string Name { get; }

    private PreciseQualifier(string name)
    {
        Name = name;
    }

    public static PreciseQualifier Precise() => new("precise");

    public string GetQualifier() => Name;
}