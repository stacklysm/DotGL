namespace Core.ShaderGen.Descriptors;

public class ArrayTypeDescriptor : ITypeDescriptor
{
    public DataType BaseType => TypeDescriptor.Type;

    public int BaseTypeSize => TypeDescriptor.FinalSize;

    public string TypeName => TypeDescriptor.TypeName;

    public int LayoutSlots => Length * TypeDescriptor.LayoutSlots;

    public int FinalSize => Length * BaseTypeSize;

    public IReflectiveTypeDescriptor TypeDescriptor { get; }

    public int Length { get; }

    public ArrayTypeDescriptor(IReflectiveTypeDescriptor typeDescriptor, int length)
    {
        TypeDescriptor = typeDescriptor;
        Length = length;
    }
}