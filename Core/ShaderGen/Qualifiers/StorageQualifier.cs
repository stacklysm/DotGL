namespace Core.ShaderGen.Qualifiers;

public class StorageQualifier : IQualifier
{
    private string Name { get; }

    private StorageQualifier(string name)
    {
        Name = name;
    }

    public static StorageQualifier Const() => new("const");

    public static StorageQualifier In() => new("in");

    public static StorageQualifier Out() => new("out");

    public static StorageQualifier Uniform() => new("uniform");

    public static StorageQualifier Buffer() => new("buffer");

    public static StorageQualifier Shared() => new("shared");

    public string GetQualifier() => Name;
}
