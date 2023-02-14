namespace Core.ShaderGen.Descriptors;

public interface IReflectiveTypeDescriptor : ITypeDescriptor
{
    DataType Type { get; }

    IReflectiveTypeDescriptor From(DataType dataType);
}
