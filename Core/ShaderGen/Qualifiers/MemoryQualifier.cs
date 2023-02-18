namespace Core.ShaderGen.Qualifiers;

public class MemoryQualifier : IQualifier
{
    private string Name { get; }

    private MemoryQualifier(string name)
    {
        Name = name;
    }

    public static MemoryQualifier Coherent() => new("coherent");

    public static MemoryQualifier Volatile() => new("volatile");

    public static MemoryQualifier Restrict() => new("restrict");

    public static MemoryQualifier ReadOnly() => new("readonly");

    public static MemoryQualifier WriteOnly() => new("writeonly");

    public string GetQualifier() => Name;
}
