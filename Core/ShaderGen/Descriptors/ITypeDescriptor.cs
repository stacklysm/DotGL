namespace Core.ShaderGen.Descriptors;

public interface ITypeDescriptor
{
    DataType BaseType { get; }

    int BaseTypeSize { get; }

    string TypeName { get; }

    int LayoutSlots { get; }

    int FinalSize { get; }
}
