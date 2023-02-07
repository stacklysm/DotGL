using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;

namespace Backend.Graphics.OpenGL.Helper;

public static class ProgramUniformGet
{
    public static int ProgramId { get; set; }
    public static int UniformLocation { get; set; }

    public static TUniform GetUniform<TUniform>()
        where TUniform : struct
    {
        return new TUniform() switch
        {
            int => (dynamic)Int1(),
            Vector2i => (dynamic)Int2(),
            Vector3i => (dynamic)Int3(),
            Vector4i => (dynamic)Int4(),
            uint => (dynamic)UnsignedInt1(),
            Vector2ui => (dynamic)UnsignedInt2(),
            Vector3ui => (dynamic)UnsignedInt3(),
            Vector4ui => (dynamic)UnsignedInt4(),
            float => (dynamic)Float1(),
            Vector2 => (dynamic)Float2(),
            Vector3 => (dynamic)Float3(),
            Vector4 => (dynamic)Float4(),
            double => (dynamic)Double1(),
            Vector2d => (dynamic)Double2(),
            Vector3d => (dynamic)Double3(),
            Vector4d => (dynamic)Double4(),
            bool => (dynamic)Bool1(),
            Vector2b => (dynamic)Bool2(),
            Vector3b => (dynamic)Bool3(),
            Vector4b => (dynamic)Bool4(),
            OpenTK.Mathematics.Matrix2 => (dynamic)Matrix2(),
            OpenTK.Mathematics.Matrix2x3 => (dynamic)Matrix2x3(),
            OpenTK.Mathematics.Matrix2x4 => (dynamic)Matrix2x4(),
            OpenTK.Mathematics.Matrix3 => (dynamic)Matrix3(),
            OpenTK.Mathematics.Matrix3x2 => (dynamic)Matrix3x2(),
            OpenTK.Mathematics.Matrix3x4 => (dynamic)Matrix3x4(),
            OpenTK.Mathematics.Matrix4 => (dynamic)Matrix4(),
            OpenTK.Mathematics.Matrix4x2 => (dynamic)Matrix4x2(),
            OpenTK.Mathematics.Matrix4x3 => (dynamic)Matrix4x3(),
            OpenTK.Mathematics.Matrix2d => (dynamic)Matrix2d(),
            OpenTK.Mathematics.Matrix2x3d => (dynamic)Matrix2x3d(),
            OpenTK.Mathematics.Matrix2x4d => (dynamic)Matrix2x4d(),
            OpenTK.Mathematics.Matrix3d => (dynamic)Matrix3d(),
            OpenTK.Mathematics.Matrix3x2d => (dynamic)Matrix3x2d(),
            OpenTK.Mathematics.Matrix3x4d => (dynamic)Matrix3x4d(),
            OpenTK.Mathematics.Matrix4d => (dynamic)Matrix4d(),
            OpenTK.Mathematics.Matrix4x2d => (dynamic)Matrix4x2d(),
            OpenTK.Mathematics.Matrix4x3d => (dynamic)Matrix4x3d(),
            _ => throw new OpenGLException(Constants.ERROR_INVALID_UNIFORM_TYPE)
        };
    }

    public static TUniform[] GetUniform<TUniform>(int length)
        where TUniform : struct
    {
        return new TUniform[length] switch
        {
            int[] => (dynamic)Int1Array(length),
            Vector2i[] => (dynamic)Int2Array(length),
            Vector3i[] => (dynamic)Int3Array(length),
            Vector4i[] => (dynamic)Int4Array(length),
            uint[] => (dynamic)UnsignedInt1Array(length),
            Vector2ui[] => (dynamic)UnsignedInt2Array(length),
            Vector3ui[] => (dynamic)UnsignedInt3Array(length),
            Vector4ui[] => (dynamic)UnsignedInt4Array(length),
            float[] => (dynamic)Float1Array(length),
            Vector2[] => (dynamic)Float2Array(length),
            Vector3[] => (dynamic)Float3Array(length),
            Vector4[] => (dynamic)Float4Array(length),
            double[] => (dynamic)Double1Array(length),
            Vector2d[] => (dynamic)Double2Array(length),
            Vector3d[] => (dynamic)Double3Array(length),
            Vector4d[] => (dynamic)Double4Array(length),
            bool[] => (dynamic)Bool1Array(length),
            Vector2b[] => (dynamic)Bool2Array(length),
            Vector3b[] => (dynamic)Bool3Array(length),
            Vector4b[] => (dynamic)Bool4Array(length),
            Matrix2[] => (dynamic)Matrix2Array(length),
            Matrix2x3[] => (dynamic)Matrix2x3Array(length),
            Matrix2x4[] => (dynamic)Matrix2x4Array(length),
            Matrix3[] => (dynamic)Matrix3Array(length),
            Matrix3x2[] => (dynamic)Matrix3x2Array(length),
            Matrix3x4[] => (dynamic)Matrix3x4Array(length),
            Matrix4[] => (dynamic)Matrix4Array(length),
            Matrix4x2[] => (dynamic)Matrix4x2Array(length),
            Matrix4x3[] => (dynamic)Matrix4x3Array(length),
            _ => throw new OpenGLException(Constants.ERROR_INVALID_UNIFORM_TYPE)
        };
    }

    public static int Int1()
    {
        GL.GetUniform(ProgramId, UniformLocation, out int v0);

        return v0;
    }

    public static Vector2i Int2()
    {
        int[] v0 = new int[2];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2i(v0);
    }

    public static Vector3i Int3()
    {
        int[] v0 = new int[3];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3i(v0);
    }

    public static Vector4i Int4()
    {
        int[] v0 = new int[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4i(v0);
    }

    public static uint UnsignedInt1()
    {
        GL.GetUniform((uint)ProgramId, UniformLocation, out uint v0);

        return v0;
    }

    public static Vector2ui UnsignedInt2()
    {
        uint[] v0 = new uint[2];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2ui(v0);
    }

    public static Vector3ui UnsignedInt3()
    {
        uint[] v0 = new uint[3];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3ui(v0);
    }

    public static Vector4ui UnsignedInt4()
    {
        uint[] v0 = new uint[4];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4ui(v0);
    }

    public static float Float1()
    {
        GL.GetUniform(ProgramId, UniformLocation, out float v0);

        return v0;
    }

    public static Vector2 Float2()
    {
        float[] v0 = new float[2];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2(v0);
    }

    public static Vector3 Float3()
    {
        float[] v0 = new float[3];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3(v0);
    }

    public static Vector4 Float4()
    {
        float[] v0 = new float[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4(v0);
    }

    public static double Double1()
    {
        GL.GetUniform(ProgramId, UniformLocation, out double v0);

        return v0;
    }

    public static Vector2d Double2()
    {
        double[] v0 = new double[2];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2d(v0);
    }

    public static Vector3d Double3()
    {
        double[] v0 = new double[3];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3d(v0);
    }

    public static Vector4d Double4()
    {
        double[] v0 = new double[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4d(v0);
    }

    public static int Bool1()
    {
        GL.GetUniform(ProgramId, UniformLocation, out int v0);

        return v0;
    }

    public static Vector2b Bool2()
    {
        int[] v0 = new int[2];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2b(v0);
    }

    public static Vector3b Bool3()
    {
        int[] v0 = new int[3];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3b(v0);
    }

    public static Vector4b Bool4()
    {
        int[] v0 = new int[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4b(v0);
    }

    public static Matrix2 Matrix2()
    {
        float[] v0 = new float[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2(v0);
    }

    public static Matrix2x3 Matrix2x3()
    {
        float[] v0 = new float[6];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x3(v0);
    }

    public static Matrix2x4 Matrix2x4()
    {
        float[] v0 = new float[8];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x4(v0);
    }

    public static Matrix3 Matrix3()
    {
        float[] v0 = new float[9];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3(v0);
    }

    public static Matrix3x2 Matrix3x2()
    {
        float[] v0 = new float[6];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x2(v0);
    }

    public static Matrix3x4 Matrix3x4()
    {
        float[] v0 = new float[12];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x4(v0);
    }

    public static Matrix4 Matrix4()
    {
        float[] v0 = new float[16];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4(v0);
    }

    public static Matrix4x2 Matrix4x2()
    {
        float[] v0 = new float[8];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x2(v0);
    }

    public static Matrix4x3 Matrix4x3()
    {
        float[] v0 = new float[12];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x3(v0);
    }

    public static Matrix2d Matrix2d()
    {
        double[] v0 = new double[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2d(v0);
    }

    public static Matrix2x3d Matrix2x3d()
    {
        double[] v0 = new double[6];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x3d(v0);
    }

    public static Matrix2x4d Matrix2x4d()
    {
        double[] v0 = new double[8];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x4d(v0);
    }

    public static Matrix3d Matrix3d()
    {
        double[] v0 = new double[9];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3d(v0);
    }

    public static Matrix3x2d Matrix3x2d()
    {
        double[] v0 = new double[6];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x2d(v0);
    }

    public static Matrix3x4d Matrix3x4d()
    {
        double[] v0 = new double[12];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x4d(v0);
    }

    public static Matrix4d Matrix4d()
    {
        double[] v0 = new double[16];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4d(v0);
    }

    public static Matrix4x2d Matrix4x2d()
    {
        double[] v0 = new double[8];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x2d(v0);
    }

    public static Matrix4x3d Matrix4x3d()
    {
        double[] v0 = new double[12];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x3d(v0);
    }

    public static int[] Int1Array(int length)
    {
        int[] v0 = new int[length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return v0;
    }

    public static Vector2i[] Int2Array(int length)
    {
        int[] v0 = new int[2 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2iArray(v0);
    }

    public static Vector3i[] Int3Array(int length)
    {
        int[] v0 = new int[3 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3iArray(v0);
    }

    public static Vector4i[] Int4Array(int length)
    {
        int[] v0 = new int[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4iArray(v0);
    }

    public static uint[] UnsignedInt1Array(int length)
    {
        uint[] v0 = new uint[length];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return v0;
    }

    public static Vector2ui[] UnsignedInt2Array(int length)
    {
        uint[] v0 = new uint[2 * length];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2uiArray(v0);
    }

    public static Vector3ui[] UnsignedInt3Array(int length)
    {
        uint[] v0 = new uint[3 * length];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3uiArray(v0);
    }

    public static Vector4ui[] UnsignedInt4Array(int length)
    {
        uint[] v0 = new uint[4 * length];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4uiArray(v0);
    }


    public static float[] Float1Array(int length)
    {
        float[] v0 = new float[length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return v0;
    }

    public static Vector2[] Float2Array(int length)
    {
        float[] v0 = new float[2 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2Array(v0);
    }

    public static Vector3[] Float3Array(int length)
    {
        float[] v0 = new float[3 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3Array(v0);
    }

    public static Vector4[] Float4Array(int length)
    {
        float[] v0 = new float[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4Array(v0);
    }

    public static double[] Double1Array(int length)
    {
        double[] v0 = new double[length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return v0;
    }

    public static Vector2d[] Double2Array(int length)
    {
        double[] v0 = new double[2 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2dArray(v0);
    }

    public static Vector3d[] Double3Array(int length)
    {
        double[] v0 = new double[3 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3dArray(v0);
    }

    public static Vector4d[] Double4Array(int length)
    {
        double[] v0 = new double[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4dArray(v0);
    }

    public static bool[] Bool1Array(int length)
    {
        int[] v0 = new int[length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return v0.Select(x => x == 1).ToArray();
    }

    public static Vector2b[] Bool2Array(int length)
    {
        int[] v0 = new int[2 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2bArray(v0);
    }

    public static Vector3b[] Bool3Array(int length)
    {
        int[] v0 = new int[3 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3bArray(v0);
    }

    public static Vector4b[] Bool4Array(int length)
    {
        int[] v0 = new int[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4bArray(v0);
    }

    public static Matrix2[] Matrix2Array(int length)
    {
        float[] v0 = new float[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2Array(v0);
    }

    public static Matrix2x3[] Matrix2x3Array(int length)
    {
        float[] v0 = new float[6 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x3Array(v0);
    }

    public static Matrix2x4[] Matrix2x4Array(int length)
    {
        float[] v0 = new float[8 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x4Array(v0);
    }

    public static Matrix3[] Matrix3Array(int length)
    {
        float[] v0 = new float[9 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3Array(v0);
    }

    public static Matrix3x2[] Matrix3x2Array(int length)
    {
        float[] v0 = new float[6 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x2Array(v0);
    }

    public static Matrix3x4[] Matrix3x4Array(int length)
    {
        float[] v0 = new float[12 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x4Array(v0);
    }

    public static Matrix4[] Matrix4Array(int length)
    {
        float[] v0 = new float[16 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4Array(v0);
    }

    public static Matrix4x2[] Matrix4x2Array(int length)
    {
        float[] v0 = new float[8 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x2Array(v0);
    }

    public static Matrix4x3[] Matrix4x3Array(int length)
    {
        float[] v0 = new float[12 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x3Array(v0);
    }

    public static Matrix2d[] Matrix2dArray(int length)
    {
        double[] v0 = new double[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2dArray(v0);
    }

    public static Matrix2x3d[] Matrix2x3dArray(int length)
    {
        double[] v0 = new double[6 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x3dArray(v0);
    }

    public static Matrix2x4d[] Matrix2x4dArray(int length)
    {
        double[] v0 = new double[8 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x4dArray(v0);
    }

    public static Matrix3d[] Matrix3dArray(int length)
    {
        double[] v0 = new double[9 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3dArray(v0);
    }

    public static Matrix3x2d[] Matrix3x2dArray(int length)
    {
        double[] v0 = new double[6 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x2dArray(v0);
    }

    public static Matrix3x4d[] Matrix3x4dArray(int length)
    {
        double[] v0 = new double[12 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x4dArray(v0);
    }

    public static Matrix4d[] Matrix4dArray(int length)
    {
        double[] v0 = new double[16 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4dArray(v0);
    }

    public static Matrix4x2d[] Matrix4x2dArray(int length)
    {
        double[] v0 = new double[8 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x2dArray(v0);
    }

    public static Matrix4x3d[] Matrix4x3dArray(int length)
    {
        double[] v0 = new double[12 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x3dArray(v0);
    }
}
