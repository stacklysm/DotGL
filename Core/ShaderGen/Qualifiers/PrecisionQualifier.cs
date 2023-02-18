namespace Core.ShaderGen.Qualifiers;

public class PrecisionQualifier : IQualifier
{
    private string Name { get; }

    private PrecisionQualifier(string name)
    {
        Name = name;
    }

    public static PrecisionQualifier HighP() => new("highp");

    public static PrecisionQualifier MediumP() => new("mediump");

    public static PrecisionQualifier LowP() => new("lowp");

    public string GetQualifier() => Name;
}
