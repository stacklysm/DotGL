using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;

namespace Backend.Graphics.OpenGL.Helper;

public static class ProgramUniformSet
{
    public static int ProgramId { get; set; }
    public static int UniformLocation { get; set; }

    public static void SetUniform<TUniform>(TUniform uniform, bool transposeMatrix)
        where TUniform : struct
    {
        switch (uniform)
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
                Matrix2(v0, transposeMatrix);
                break;

            case Matrix2x3 v0:
                Matrix2x3(v0, transposeMatrix);
                break;

            case Matrix2x4 v0:
                Matrix2x4(v0, transposeMatrix);
                break;

            case Matrix3 v0:
                Matrix3(v0, transposeMatrix);
                break;

            case Matrix3x2 v0:
                Matrix3x2(v0, transposeMatrix);
                break;

            case Matrix3x4 v0:
                Matrix3x4(v0, transposeMatrix);
                break;

            case Matrix4 v0:
                Matrix4(v0, transposeMatrix);
                break;

            case Matrix4x2 v0:
                Matrix4x2(v0, transposeMatrix);
                break;

            case Matrix4x3 v0:
                Matrix4x3(v0, transposeMatrix);
                break;

            case Matrix2d v0:
                Matrix2d(v0, transposeMatrix);
                break;

            case Matrix2x3d v0:
                Matrix2x3d(v0, transposeMatrix);
                break;

            case Matrix2x4d v0:
                Matrix2x4d(v0, transposeMatrix);
                break;

            case Matrix3d v0:
                Matrix3d(v0, transposeMatrix);
                break;

            case Matrix3x2d v0:
                Matrix3x2d(v0, transposeMatrix);
                break;

            case Matrix3x4d v0:
                Matrix3x4d(v0, transposeMatrix);
                break;

            case Matrix4d v0:
                Matrix4d(v0, transposeMatrix);
                break;

            case Matrix4x2d v0:
                Matrix4x2d(v0, transposeMatrix);
                break;

            case Matrix4x3d v0:
                Matrix4x3d(v0, transposeMatrix);
                break;

            default:
                throw new OpenGLException($"{Constants.ERROR_INVALID_UNIFORM_TYPE}");
        }
    }

    public static void SetUniform<TUniform>(TUniform[] uniform, bool transposeMatrix)
        where TUniform : struct
    {
        switch (uniform)
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
                Matrix2Array(v0, transposeMatrix);
                break;

            case Matrix2x3[] v0:
                Matrix2x3Array(v0, transposeMatrix);
                break;

            case Matrix2x4[] v0:
                Matrix2x4Array(v0, transposeMatrix);
                break;

            case Matrix3[] v0:
                Matrix3Array(v0, transposeMatrix);
                break;

            case Matrix3x2[] v0:
                Matrix3x2Array(v0, transposeMatrix);
                break;

            case Matrix3x4[] v0:
                Matrix3x4Array(v0, transposeMatrix);
                break;

            case Matrix4[] v0:
                Matrix4Array(v0, transposeMatrix);
                break;

            case Matrix4x2[] v0:
                Matrix4x2Array(v0, transposeMatrix);
                break;

            case Matrix4x3[] v0:
                Matrix4x3Array(v0, transposeMatrix);
                break;

            case Matrix2d[] v0:
                Matrix2dArray(v0, transposeMatrix);
                break;

            case Matrix2x3d[] v0:
                Matrix2x3dArray(v0, transposeMatrix);
                break;

            case Matrix2x4d[] v0:
                Matrix2x4dArray(v0, transposeMatrix);
                break;

            case Matrix3d[] v0:
                Matrix3dArray(v0, transposeMatrix);
                break;

            case Matrix3x2d[] v0:
                Matrix3x2dArray(v0, transposeMatrix);
                break;

            case Matrix3x4d[] v0:
                Matrix3x4dArray(v0, transposeMatrix);
                break;

            case Matrix4d[] v0:
                Matrix4dArray(v0, transposeMatrix);
                break;

            case Matrix4x2d[] v0:
                Matrix4x2dArray(v0, transposeMatrix);
                break;

            case Matrix4x3d[] v0:
                Matrix4x3dArray(v0, transposeMatrix);
                break;

            default:
                throw new OpenGLException($"{Constants.ERROR_INVALID_UNIFORM_TYPE}");
        }
    }

    public static void Int1(int v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0);
    }

    public static void Int2(Vector2i v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0);
    }

    public static void Int3(Vector3i v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0);
    }

    public static void Int4(Vector4i v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0);
    }

    public static void UnsignedInt1(uint v0)
    {
        GL.ProgramUniform1((uint)ProgramId, UniformLocation, v0);
    }

    public static void UnsignedInt2(Vector2ui v0)
    {
        GL.ProgramUniform2((uint)ProgramId, UniformLocation, v0.Item1, v0.Item2);
    }

    public static void UnsignedInt3(Vector3ui v0)
    {
        GL.ProgramUniform3((uint)ProgramId, UniformLocation, v0.Item1, v0.Item2, v0.Item3);
    }

    public static void UnsignedInt4(Vector4ui v0)
    {
        GL.ProgramUniform4((uint)ProgramId, UniformLocation, v0.Item1, v0.Item2, v0.Item3, v0.Item4);
    }

    public static void Float1(float v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0);
    }

    public static void Float2(Vector2 v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0);
    }

    public static void Float3(Vector3 v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0);
    }

    public static void Float4(Vector4 v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0);
    }

    public static void Double1(double v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0);
    }

    public static void Double2(Vector2d v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0.X, v0.Y);
    }

    public static void Double3(Vector3d v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.X, v0.Y, v0.Z);
    }

    public static void Double4(Vector4d v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.X, v0.Y, v0.Z, v0.W);
    }

    public static void Bool1(bool v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0 ? 1 : 0);
    }

    public static void Bool2(Vector2b v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0.Item1 ? 1 : 0, v0.Item2 ? 1 : 0);
    }

    public static void Bool3(Vector3b v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.Item1 ? 1 : 0, v0.Item2 ? 1 : 0, v0.Item3 ? 1 : 0);
    }

    public static void Bool4(Vector4b v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Item1 ? 1 : 0, v0.Item2 ? 1 : 0, v0.Item3 ? 1 : 0, v0.Item4 ? 1 : 0);
    }

    public static void Matrix2(Matrix2 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix2x3(Matrix2x3 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2x3(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix2x4(Matrix2x4 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2x4(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix3(Matrix3 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix3x2(Matrix3x2 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3x2(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix3x4(Matrix3x4 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3x4(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix4(Matrix4 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix4x2(Matrix4x2 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4x2(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix4x3(Matrix4x3 v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4x3(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix2d(Matrix2d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix2x3d(Matrix2x3d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2x3(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix2x4d(Matrix2x4d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix2x4(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix3d(Matrix3d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix3x2d(Matrix3x2d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3x2(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix3x4d(Matrix3x4d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix3x4(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix4d(Matrix4d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix4x2d(Matrix4x2d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4x2(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Matrix4x3d(Matrix4x3d v0, bool transpose = true)
    {
        GL.ProgramUniformMatrix4x3(ProgramId, UniformLocation, transpose, ref v0);
    }

    public static void Int1Array(int[] v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0.Length, v0);
    }

    public static void Int2Array(Vector2i[] v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector2iArrayToArray(v0));
    }

    public static void Int3Array(Vector3i[] v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector3iArrayToArray(v0));
    }

    public static void Int4Array(Vector4i[] v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector4iArrayToArray(v0));
    }

    public static void UnsignedInt1Array(uint[] v0)
    {
        GL.ProgramUniform1((uint)ProgramId, UniformLocation, v0.Length, v0);
    }

    public static void UnsignedInt2Array(Vector2ui[] v0)
    {
        GL.ProgramUniform2((uint)ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector2uiArrayToArray(v0));
    }

    public static void UnsignedInt3Array(Vector3ui[] v0)
    {
        GL.ProgramUniform3((uint)ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector3uiArrayToArray(v0));
    }

    public static void UnsignedInt4Array(Vector4ui[] v0)
    {
        GL.ProgramUniform4((uint)ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector4uiArrayToArray(v0));
    }

    public static void Float1Array(float[] v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0.Length, v0);
    }

    public static void Float2Array(Vector2[] v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector2ArrayToArray(v0));
    }

    public static void Float3Array(Vector3[] v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector3ArrayToArray(v0));
    }

    public static void Float4Array(Vector4[] v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector4ArrayToArray(v0));
    }

    public static void Double1Array(double[] v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0.Length, v0);
    }

    public static void Double2Array(Vector2d[] v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector2dArrayToArray(v0));
    }

    public static void Double3Array(Vector3d[] v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector3dArrayToArray(v0));
    }

    public static void Double4Array(Vector4d[] v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector4dArrayToArray(v0));
    }

    public static void Bool1Array(bool[] v0)
    {
        GL.ProgramUniform1(ProgramId, UniformLocation, v0.Length, v0.Select(b => b ? 1 : 0).ToArray());
    }

    public static void Bool2Array(Vector2b[] v0)
    {
        GL.ProgramUniform2(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector2bArrayToArray(v0));
    }

    public static void Bool3Array(Vector3b[] v0)
    {
        GL.ProgramUniform3(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector3bArrayToArray(v0));
    }

    public static void Bool4Array(Vector4b[] v0)
    {
        GL.ProgramUniform4(ProgramId, UniformLocation, v0.Length, SetTypeHelpers.Vector4bArrayToArray(v0));
    }

    public static void Matrix2Array(Matrix2[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2ArrayToArray(v0));
    }

    public static void Matrix2x3Array(Matrix2x3[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2x3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2x3ArrayToArray(v0));
    }

    public static void Matrix2x4Array(Matrix2x4[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2x4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2x4ArrayToArray(v0));
    }

    public static void Matrix3Array(Matrix3[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3ArrayToArray(v0));
    }

    public static void Matrix3x2Array(Matrix3x2[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3x2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3x2ArrayToArray(v0));
    }

    public static void Matrix3x4Array(Matrix3x4[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3x4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3x4ArrayToArray(v0));
    }

    public static void Matrix4Array(Matrix4[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4ArrayToArray(v0));
    }

    public static void Matrix4x2Array(Matrix4x2[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4x2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4x2ArrayToArray(v0));
    }

    public static void Matrix4x3Array(Matrix4x3[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4x3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4x3ArrayToArray(v0));
    }

    public static void Matrix2dArray(Matrix2d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2dArrayToArray(v0));
    }

    public static void Matrix2x3dArray(Matrix2x3d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2x3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2x3dArrayToArray(v0));
    }

    public static void Matrix2x4dArray(Matrix2x4d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix2x4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix2x4dArrayToArray(v0));
    }

    public static void Matrix3dArray(Matrix3d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3dArrayToArray(v0));
    }

    public static void Matrix3x2dArray(Matrix3x2d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3x2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3x2dArrayToArray(v0));
    }

    public static void Matrix3x4dArray(Matrix3x4d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix3x4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix3x4dArrayToArray(v0));
    }

    public static void Matrix4dArray(Matrix4d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4dArrayToArray(v0));
    }

    public static void Matrix4x2dArray(Matrix4x2d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4x2(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4x2dArrayToArray(v0));
    }

    public static void Matrix4x3dArray(Matrix4x3d[] v0, bool transposeAll = true)
    {
        GL.ProgramUniformMatrix4x3(ProgramId, UniformLocation, v0.Length, transposeAll, SetTypeHelpers.Matrix4x3dArrayToArray(v0));
    }
}
