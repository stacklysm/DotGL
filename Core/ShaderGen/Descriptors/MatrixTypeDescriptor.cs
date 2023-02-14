namespace Core.ShaderGen.Descriptors;

public class MatrixTypeDescriptor : IReflectiveTypeDescriptor
{
    public DataType Type { get; }

    public DataType BaseType { get; }

    public int BaseTypeSize { get; }

    public string TypeName { get; }

    public int LayoutSlots => ((BaseType == DataType.Double && Rows > 2) ? 1 : 2) * Columns;

    public int FinalSize => BaseTypeSize * Rows * Columns;

    public int Rows { get; }

    public int Columns { get; }

    private MatrixTypeDescriptor(DataType dataType, DataType baseType, int baseTypeSize, string typeName, int rows, int columns)
    {
        Type = dataType;
        BaseType = baseType;
        BaseTypeSize = baseTypeSize;
        TypeName = typeName;
        Rows = rows;
        Columns = columns;
    }

    public IReflectiveTypeDescriptor From(DataType matrixType)
    {
        return matrixType switch
        {
            DataType.FloatMatrix2 => new MatrixTypeDescriptor(matrixType, DataType.Float, sizeof(float), "mat2", 2, 2),
            DataType.FloatMatrix2x3 => new MatrixTypeDescriptor(matrixType, DataType.Float, sizeof(float), "mat2x3", 2, 3),
            DataType.FloatMatrix2x4 => new MatrixTypeDescriptor(matrixType, DataType.Float, sizeof(float), "mat2x4", 2, 4),
            DataType.FloatMatrix3 => new MatrixTypeDescriptor(matrixType, DataType.Float, sizeof(float), "mat3", 3, 3),
            DataType.FloatMatrix3x2 => new MatrixTypeDescriptor(matrixType, DataType.Float, sizeof(float), "mat3x2", 3, 2),
            DataType.FloatMatrix3x4 => new MatrixTypeDescriptor(matrixType, DataType.Float, sizeof(float), "mat3x4", 3, 4),
            DataType.FloatMatrix4 => new MatrixTypeDescriptor(matrixType, DataType.Float, sizeof(float), "mat4", 4, 4),
            DataType.FloatMatrix4x2 => new MatrixTypeDescriptor(matrixType, DataType.Float, sizeof(float), "mat4x2", 4, 2),
            DataType.FloatMatrix4x3 => new MatrixTypeDescriptor(matrixType, DataType.Float, sizeof(float), "mat4x3", 4, 3),
            DataType.DoubleMatrix2 => new MatrixTypeDescriptor(matrixType, DataType.Double, sizeof(double), "dmat2", 2, 2),
            DataType.DoubleMatrix2x3 => new MatrixTypeDescriptor(matrixType, DataType.Double, sizeof(double), "dmat2x3", 2, 3),
            DataType.DoubleMatrix2x4 => new MatrixTypeDescriptor(matrixType, DataType.Double, sizeof(double), "dmat2x4", 2, 4),
            DataType.DoubleMatrix3 => new MatrixTypeDescriptor(matrixType, DataType.Double, sizeof(double), "dmat3", 3, 3),
            DataType.DoubleMatrix3x2 => new MatrixTypeDescriptor(matrixType, DataType.Double, sizeof(double), "dmat3x2", 3, 2),
            DataType.DoubleMatrix3x4 => new MatrixTypeDescriptor(matrixType, DataType.Double, sizeof(double), "dmat3x4", 3, 4),
            DataType.DoubleMatrix4 => new MatrixTypeDescriptor(matrixType, DataType.Double, sizeof(double), "dmat4", 4, 4),
            DataType.DoubleMatrix4x2 => new MatrixTypeDescriptor(matrixType, DataType.Double, sizeof(double), "dmat4x2", 4, 2),
            DataType.DoubleMatrix4x3 => new MatrixTypeDescriptor(matrixType, DataType.Double, sizeof(double), "dmat4x3", 4, 3),
            _ => throw new InvalidOperationException("The type provided was not a valid matrix type.")
        };
    }
}
