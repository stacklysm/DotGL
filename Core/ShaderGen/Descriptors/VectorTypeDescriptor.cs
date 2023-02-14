namespace Core.ShaderGen.Descriptors;

public class VectorTypeDescriptor : IReflectiveTypeDescriptor
{
    public DataType Type { get; }

    public DataType BaseType { get; }

    public int BaseTypeSize { get; }

    public string TypeName { get; }

    public int LayoutSlots => (BaseType == DataType.Double && ComponentCount > 2) ? 2 : 1;

    public int FinalSize => BaseTypeSize * ComponentCount;

    public int ComponentCount { get; }

    private VectorTypeDescriptor(DataType dataType, DataType baseType, int baseTypeSize, string typeName, int componentCount)
    {
        Type = dataType;
        BaseType = baseType;
        BaseTypeSize = baseTypeSize;
        TypeName = typeName;
        ComponentCount = componentCount;
    }

    public IReflectiveTypeDescriptor From(DataType vectorType)
    {
        return vectorType switch
        {
            DataType.BooleanVector2 => new VectorTypeDescriptor(vectorType, DataType.Boolean, sizeof(bool), "bvec2", 2),
            DataType.BooleanVector3 => new VectorTypeDescriptor(vectorType, DataType.Boolean, sizeof(bool), "bvec4", 3),
            DataType.BooleanVector4 => new VectorTypeDescriptor(vectorType, DataType.Boolean, sizeof(bool), "bvec3", 4),
            DataType.IntegerVector2 => new VectorTypeDescriptor(vectorType, DataType.Integer, sizeof(int), "ivec2", 2),
            DataType.IntegerVector3 => new VectorTypeDescriptor(vectorType, DataType.Integer, sizeof(int), "ivec4", 3),
            DataType.IntegerVector4 => new VectorTypeDescriptor(vectorType, DataType.Integer, sizeof(int), "ivec3", 4),
            DataType.UnsignedIntegerVector2 => new VectorTypeDescriptor(vectorType, DataType.UnsignedInteger, sizeof(uint), "uvec2", 2),
            DataType.UnsignedIntegerVector3 => new VectorTypeDescriptor(vectorType, DataType.UnsignedInteger, sizeof(uint), "uvec4", 3),
            DataType.UnsignedIntegerVector4 => new VectorTypeDescriptor(vectorType, DataType.UnsignedInteger, sizeof(uint), "uvec3", 4),
            DataType.FloatVector2 => new VectorTypeDescriptor(vectorType, DataType.Float, sizeof(float), "vec2", 2),
            DataType.FloatVector3 => new VectorTypeDescriptor(vectorType, DataType.Float, sizeof(float), "vec4", 3),
            DataType.FloatVector4 => new VectorTypeDescriptor(vectorType, DataType.Float, sizeof(float), "vec3", 4),
            DataType.DoubleVector2 => new VectorTypeDescriptor(vectorType, DataType.Double, sizeof(double), "dvec2", 2),
            DataType.DoubleVector3 => new VectorTypeDescriptor(vectorType, DataType.Double, sizeof(double), "dvec4", 3),
            DataType.DoubleVector4 => new VectorTypeDescriptor(vectorType, DataType.Double, sizeof(double), "dvec3", 4),
            _ => throw new InvalidOperationException("The type provided was not a valid vector type.")
        };
    }
}
