namespace Core.ShaderGen.Qualifiers;

public class InvariantQualifier : IQualifier
{
    private string Name { get; }

    private InvariantQualifier(string name)
    {
        Name = name;
    }

    public static InvariantQualifier Invariant() => new("invariant");

    public string GetQualifier() => Name;
}
