namespace Core.ShaderGen.Qualifiers;

public class SpecializationConstantQualifier : IQualifier
{
    private string Name { get; }

    private int Value { get; }

    private SpecializationConstantQualifier(string name, int value)
    {
        Name = name;
        Value = value;
    }

    public static SpecializationConstantQualifier ConstantId(int id) => new("constant_id", id);

    public string GetQualifier() => $"{Name} = {Value}";
}