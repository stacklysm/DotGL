namespace Core.ShaderGen.Qualifiers;

public class InterpolationQualifier : IQualifier
{
    private string Name { get; }

    private InterpolationQualifier(string name)
    {
        Name = name;
    }

    public static InterpolationQualifier Smooth() => new("smooth");

    public static InterpolationQualifier Flat() => new("flat");

    public static InterpolationQualifier NoPerspective() => new("noperspective");

    public string GetQualifier() => Name;
}
