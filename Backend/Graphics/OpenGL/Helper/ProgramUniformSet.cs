using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;

namespace Backend.Graphics.OpenGL.Helper;

/// <summary>
/// Contains helper functions to set values to uniforms variables.
/// </summary>
/// <remarks>
/// Make sure to set the properties <see cref="ProgramId"/> and <see cref="UniformLocation"/> before calling <see cref="SetUniform{TUniform}(TUniform, bool)"/>.
/// </remarks>
public static class ProgramUniformSet
{
    /// <summary>
    /// The name of the program that contains the uniform.
    /// </summary>
    public static int ProgramId { get; set; }

    /// <summary>
    /// The location of the uniform.
    /// </summary>
    public static int UniformLocation { get; set; }

    /// <summary>
    /// Sets the value of a program uniform.
    /// </summary>
    /// <typeparam name="TUniform">The type of the uniform.</typeparam>
    /// <param name="value">The value being assigned to the uniform.</param>
    /// <param name="transposeMatrix">Indicates whether a matrix should be transposed.</param>
    /// <exception cref="OpenGLException">Thrown when the uniform type could not be handled.</exception>
    public static void SetUniform<TUniform>(TUniform value, bool transposeMatrix)
        where TUniform : struct
    {
        switch (value)
        {
            case int v0:
                Int1(v0);
                break;

            case uint v0:
                UnsignedInt1(v0);
                break;

            case float v0:
                Float1(v0);
                break;

            case double v0:
                Double1(v0);
                break;

            case bool v0:
                Bool1(v0);
                break;

            case Vector2i v0:
                Int2(v0);
                break;

            case Vector3i v0:
                Int3(v0);
                break;

            case Vector4i v0:
                Int4(v0);
                break;

            case Vector2ui v0:
                UnsignedInt2(v0);
                break;

            case Vector3ui v0:
                UnsignedInt3(v0);
                break;

            case Vector4ui v0:
                UnsignedInt4(v0);
                break;

            case Vector2 v0:
                Float2(v0);
                break;

            case Vector3 v0:
                Float3(v0);
                break;

            case Vector4 v0:
                Float4(v0);
                break;

            case Vector2d v0:
                Double2(v0);
                break;

            case Vector3d v0:
                Double3(v0);
                break;

            case Vector4d v0:
                Double4(v0);
                break;

            case Vector2b v0:
                Bool2(v0);
                break;

            case Vector3b v0:
                Bool3(v0);
                break;

            case Vector4b v0:
                Bool4(v0);
                break;

            case Matrix2 v0:
                FloatMatrix2(v0, transposeMatrix);
                break;

            case Matrix2x3 v0:
                FloatMatrix2x3(v0, transposeMatrix);
                break;

            case Matrix2x4 v0:
                FloatMatrix2x4(v0, transposeMatrix);
                break;

            case Matrix3 v0:
                FloatMatrix3(v0, transposeMatrix);
                break;

            case Matrix3x2 v0:
                FloatMatrix3x2(v0, transposeMatrix);
                break;

            case Matrix3x4 v0:
                FloatMatrix3x4(v0, transposeMatrix);
                break;

            case Matrix4 v0:
                FloatMatrix4(v0, transposeMatrix);
                break;

            case Matrix4x2 v0:
                FloatMatrix4x2(v0, transposeMatrix);
                break;

            case Matrix4x3 v0:
                FloatMatrix4x3(v0, transposeMatrix);
                break;

            case Matrix2d v0:
                DoubleMatrix2(v0, transposeMatrix);
                break;

            case Matrix2x3d v0:
                DoubleMatrix2x3(v0, transposeMatrix);
                break;

            case Matrix2x4d v0:
                DoubleMatrix2x4(v0, transposeMatrix);
                break;

            case Matrix3d v0:
                DoubleMatrix3(v0, transposeMatrix);
                break;

            case Matrix3x2d v0:
                DoubleMatrix3x2(v0, transposeMatrix);
                break;

            case Matrix3x4d v0:
                DoubleMatrix3x4(v0, transposeMatrix);
                break;

            case Matrix4d v0:
                DoubleMatrix4(v0, transposeMatrix);
                break;

            case Matrix4x2d v0:
                DoubleMatrix4x2(v0, transposeMatrix);
                break;

            case Matrix4x3d v0:
                DoubleMatrix4x3(v0, transposeMatrix);
                break;

            default:
                throw new OpenGLException($"{Constants.ERROR_INVALID_UNIFORM_TYPE}");
        }
    }

    /// <summary>
    /// Sets the value of an array uniform.
    /// </summary>
    /// <typeparam name="TUniform">The type of the array uniform.</typeparam>
    /// <param name="value">The array being assigned to the uniform.</param>
    /// <param name="transposeAllMatrices">Indicates whether all matrices in the array should be transposed.</param>
    /// <exception cref="OpenGLException">Thrown when the uniform type could not be handled.</exception>
    public static void SetUniform<TUniform>(TUniform[] value, bool transposeAllMatrices)
        where TUniform : struct
    {
        switch (value)
        {
            case int[] v0:
                Int1Array(v0);
                break;

            case uint[] v0:
                UnsignedInt1Array(v0);
                break;

            case float[] v0:
                Float1Array(v0);
                break;

            case double[] v0:
                Double1Array(v0);
                break;

            case bool[] v0:
                Bool1Array(v0);
                break;

            case Vector2i[] v0:
                Int2Array(v0);
                break;

            case Vector3i[] v0:
                Int3Array(v0);
                break;

            case Vector4i[] v0:
                Int4Array(v0);
                break;

            case Vector2ui[] v0:
                UnsignedInt2Array(v0);
                break;

            case Vector3ui[] v0:
                UnsignedInt3Array(v0);
                break;

            case Vector4ui[] v0:
                UnsignedInt4Array(v0);
                break;

            case Vector2[] v0:
                Float2Array(v0);
                break;

            case Vector3[] v0:
                Float3Array(v0);
                break;

            case Vector4[] v0:
                Float4Array(v0);
                break;

            case Vector2d[] v0:
                Double2Array(v0);
                break;

            case Vector3d[] v0:
                Double3Array(v0);
                break;

            case Vector4d[] v0:
                Double4Array(v0);
                break;

            case Vector2b[] v0:
                Bool2Array(v0);
                break;

            case Vector3b[] v0:
                Bool3Array(v0);
                break;

            case Vector4b[] v0:
                Bool4Array(v0);
                break;

            case Matrix2[] v0:
                FloatMatrix2Array(v0, transposeAllMatrices);
                break;

            case Matrix2x3[] v0:
                FloatMatrix2x3Array(v0, transposeAllMatrices);
                break;

            case Matrix2x4[] v0:
                FloatMatrix2x4Array(v0, transposeAllMatrices);
                break;

            case Matrix3[] v0:
                FloatMatrix3Array(v0, transposeAllMatrices);
                break;

            case Matrix3x2[] v0:
                FloatMatrix3x2Array(v0, transposeAllMatrices);
                break;

            case Matrix3x4[] v0:
                FloatMatrix3x4Array(v0, transposeAllMatrices);
                break;

            case Matrix4[] v0:
                FloatMatrix4Array(v0, transposeAllMatrices);
                break;

            case Matrix4x2[] v0:
                FloatMatrix4x2Array(v0, transposeAllMatrices);
                break;

            case Matrix4x3[] v0:
                FloatMatrix4x3Array(v0, transposeAllMatrices);
                break;

            case Matrix2d[] v0:
                DoubleMatrix2Array(v0, transposeAllMatrices);
                break;

            case Matrix2x3d[] v0:
                DoubleMatrix2x3Array(v0, transposeAllMatrices);
                break;

            case Matrix2x4d[] v0:
                DoubleMatrix2x4Array(v0, transposeAllMatrices);
                break;

            case Matrix3d[] v0:
                DoubleMatrix3Array(v0, transposeAllMatrices);
                break;

            case Matrix3x2d[] v0:
                DoubleMatrix3x2Array(v0, transposeAllMatrices);
                break;

            case Matrix3x4d[] v0:
                DoubleMatrix3x4Array(v0, transposeAllMatrices);
                break;

            case Matrix4d[] v0:
                DoubleMatrix4Array(v0, transposeAllMatrices);
                break;

            case Matrix4x2d[] v0:
                DoubleMatrix4x2Array(v0, transposeAllMatrices);
                break;

            case Matrix4x3d[] v0:
                DoubleMatrix4x3Array(v0, transposeAllMatrices);
                break;

            default:
                throw new OpenGLException($"{Constants.ERROR_INVALID_UNIFORM_TYPE}");
        }
    }

    /// <summary>
    /// Sets the value of the <see cref="int"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Int1(int v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector2i"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Int2(Vector2i v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector3i"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Int3(Vector3i v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector4i"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Int4(Vector4i v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="uint"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void UnsignedInt1(uint v0)
    {
        GL.ProgramUniform1((uint)ProgramId, UniformLocation, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector2ui"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void UnsignedInt2(Vector2ui v0)
    {
        GL.ProgramUniform2((uint)ProgramId, UniformLocation, v0.Item1, v0.Item2);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector3ui"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void UnsignedInt3(Vector3ui v0)
    {
        GL.ProgramUniform3((uint)ProgramId, UniformLocation, v0.Item1, v0.Item2, v0.Item3);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector4ui"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void UnsignedInt4(Vector4ui v0)
    {
        GL.ProgramUniform4((uint)ProgramId, UniformLocation, v0.Item1, v0.Item2, v0.Item3, v0.Item4);
    }

    /// <summary>
    /// Sets the value of the <see cref="float"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Float1(float v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector2"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Float2(Vector2 v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector3"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Float3(Vector3 v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector4"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Float4(Vector4 v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="double"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Double1(double v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector2d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Double2(Vector2d v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0.X, v0.Y);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector3d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Double3(Vector3d v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.X, v0.Y, v0.Z);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector4d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Double4(Vector4d v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.X, v0.Y, v0.Z, v0.W);
    }

    /// <summary>
    /// Sets the value of the <see cref="bool"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Bool1(bool v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0 ? 1 : 0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector2b"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Bool2(Vector2b v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0.Item1 ? 1 : 0, v0.Item2 ? 1 : 0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector3b"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Bool3(Vector3b v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.Item1 ? 1 : 0, v0.Item2 ? 1 : 0, v0.Item3 ? 1 : 0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector4b"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    public static void Bool4(Vector4b v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Item1 ? 1 : 0, v0.Item2 ? 1 : 0, v0.Item3 ? 1 : 0, v0.Item4 ? 1 : 0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void FloatMatrix2(Matrix2 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2x3"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void FloatMatrix2x3(Matrix2x3 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2x3(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2x4"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void FloatMatrix2x4(Matrix2x4 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2x4(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void FloatMatrix3(Matrix3 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3x2"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void FloatMatrix3x2(Matrix3x2 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3x2(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3x4"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void FloatMatrix3x4(Matrix3x4 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3x4(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void FloatMatrix4(Matrix4 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4x2"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void FloatMatrix4x2(Matrix4x2 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4x2(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4x3"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void FloatMatrix4x3(Matrix4x3 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4x3(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void DoubleMatrix2(Matrix2d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2x3d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void DoubleMatrix2x3(Matrix2x3d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2x3(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2x4d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void DoubleMatrix2x4(Matrix2x4d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2x4(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void DoubleMatrix3(Matrix3d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3x2d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void DoubleMatrix3x2(Matrix3x2d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3x2(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3x4d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void DoubleMatrix3x4(Matrix3x4d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3x4(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void DoubleMatrix4(Matrix4d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4x2d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void DoubleMatrix4x2(Matrix4x2d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4x2(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4x3d"/> uniform variable.
    /// </summary>
    /// <param name="v0">The new value.</param>
    /// <param name="transpose">Indicates whether the matrix should be transposed.</param>
    public static void DoubleMatrix4x3(Matrix4x3d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4x3(ProgramId, UniformLocation, transpose, ref v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="int"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Int1Array(int[] v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0.Length, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector2i"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Int2Array(Vector2i[] v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector2iArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector3i"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Int3Array(Vector3i[] v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector3iArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector4i"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Int4Array(Vector4i[] v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector4iArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="uint"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void UnsignedInt1Array(uint[] v0)
    {
        GL.ProgramUniform1((uint)ProgramId, UniformLocation, v0.Length, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector2ui"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void UnsignedInt2Array(Vector2ui[] v0)
    {
        GL.ProgramUniform2((uint)ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector2uiArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector3i"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void UnsignedInt3Array(Vector3ui[] v0)
    {
        GL.ProgramUniform3((uint)ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector3uiArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector4i"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void UnsignedInt4Array(Vector4ui[] v0)
    {
        GL.ProgramUniform4((uint)ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector4uiArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="float"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Float1Array(float[] v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0.Length, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector2"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Float2Array(Vector2[] v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector2ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector3"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Float3Array(Vector3[] v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector3ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector4"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Float4Array(Vector4[] v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector4ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="double"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Double1Array(double[] v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0.Length, v0);
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector2d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Double2Array(Vector2d[] v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector2dArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector3d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Double3Array(Vector3d[] v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector3dArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector4d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Double4Array(Vector4d[] v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector4dArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="bool"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Bool1Array(bool[] v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0.Length, v0.Select(b => b ? 1 : 0).ToArray());
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector2b"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Bool2Array(Vector2b[] v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector2bArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector3b"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Bool3Array(Vector3b[] v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector3bArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Vector4b"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    public static void Bool4Array(Vector4b[] v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector4bArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void FloatMatrix2Array(Matrix2[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2x3"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void FloatMatrix2x3Array(Matrix2x3[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2x3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2x3ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2x4"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void FloatMatrix2x4Array(Matrix2x4[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2x4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2x4ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void FloatMatrix3Array(Matrix3[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3x2"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void FloatMatrix3x2Array(Matrix3x2[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3x2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3x2ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3x4"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void FloatMatrix3x4Array(Matrix3x4[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3x4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3x4ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void FloatMatrix4Array(Matrix4[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4x2"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void FloatMatrix4x2Array(Matrix4x2[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4x2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4x2ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4x3"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void FloatMatrix4x3Array(Matrix4x3[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4x3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4x3ArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void DoubleMatrix2Array(Matrix2d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2dArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2x3d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void DoubleMatrix2x3Array(Matrix2x3d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2x3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2x3dArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix2x4d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void DoubleMatrix2x4Array(Matrix2x4d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2x4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2x4dArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void DoubleMatrix3Array(Matrix3d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3dArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3x2d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void DoubleMatrix3x2Array(Matrix3x2d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3x2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3x2dArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix3x4d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void DoubleMatrix3x4Array(Matrix3x4d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3x4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3x4dArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void DoubleMatrix4Array(Matrix4d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4dArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4x2d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void DoubleMatrix4x2Array(Matrix4x2d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4x2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4x2dArrayToArray(v0));
    }

    /// <summary>
    /// Sets the value of the <see cref="Matrix4x3d"/> uniform array variable.
    /// </summary>
    /// <param name="v0">The new array.</param>
    /// <param name="transposeAll">Indicates whether all matrices in the array should be transposed.</param>
    public static void DoubleMatrix4x3Array(Matrix4x3d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4x3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4x3dArrayToArray(v0));
    }
}
