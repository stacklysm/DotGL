namespace Core.ShaderGen.Descriptors;

public class ScalarTypeDescriptor : IReflectiveTypeDescriptor
{
    public DataType Type { get; }

    public DataType BaseType { get; }

    public int BaseTypeSize { get; }

    public string TypeName { get; }

    public int LayoutSlots => 1;

    public int FinalSize => BaseTypeSize;

    private ScalarTypeDescriptor(DataType dataType, DataType baseType, int baseTypeSize, string typeName)
    {
        Type = dataType;
        BaseType = baseType;
        BaseTypeSize = baseTypeSize;
        TypeName = typeName;
    }

    public IReflectiveTypeDescriptor From(DataType primitiveType)
    {
        return primitiveType switch
        {
            DataType.Boolean => new ScalarTypeDescriptor(primitiveType, DataType.Void, sizeof(bool), "bool"),
            DataType.Integer => new ScalarTypeDescriptor(primitiveType, DataType.Void, sizeof(int), "int"),
            DataType.UnsignedInteger => new ScalarTypeDescriptor(primitiveType, DataType.Void, sizeof(uint), "uint"),
            DataType.Float => new ScalarTypeDescriptor(primitiveType, DataType.Void, sizeof(float), "float"),
            DataType.Double => new ScalarTypeDescriptor(primitiveType, DataType.Void, sizeof(double), "double"),
            _ => throw new InvalidOperationException("The type provided was not a valid primitive type.")
        };
    }
}
