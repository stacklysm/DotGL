using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;

namespace Backend.Graphics.OpenGL.Helper;

/// <summary>
/// Contains helper functions to retrieve uniforms from a program.
/// </summary>
/// <remarks>
/// Make sure to set the properties <see cref="ProgramId"/> and <see cref="UniformLocation"/> before calling <see cref="ProgramUniformGet.GetUniform{TUniform}"/>.
/// </remarks>
public static class ProgramUniformGet
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
    /// Gets the value of a program uniform.
    /// </summary>
    /// <typeparam name="TUniform">The type of the uniform.</typeparam>
    /// <returns>The uniform value.</returns>
    /// <exception cref="OpenGLException">Thrown when the uniform type couldn't be handled.</exception>
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
            Matrix2 => (dynamic)FloatMatrix2(),
            Matrix2x3 => (dynamic)FloatMatrix2x3(),
            Matrix2x4 => (dynamic)FloatMatrix2x4(),
            Matrix3 => (dynamic)FloatMatrix3(),
            Matrix3x2 => (dynamic)FloatMatrix3x2(),
            Matrix3x4 => (dynamic)FloatMatrix3x4(),
            Matrix4 => (dynamic)FloatMatrix4(),
            Matrix4x2 => (dynamic)FloatMatrix4x2(),
            Matrix4x3 => (dynamic)FloatMatrix4x3(),
            Matrix2d => (dynamic)DoubleMatrix2(),
            Matrix2x3d => (dynamic)DoubleMatrix2x3(),
            Matrix2x4d => (dynamic)DoubleMatrix2x4(),
            Matrix3d => (dynamic)DoubleMatrix3(),
            Matrix3x2d => (dynamic)DoubleMatrix3x2(),
            Matrix3x4d => (dynamic)DoubleMatrix3x4(),
            Matrix4d => (dynamic)DoubleMatrix4(),
            Matrix4x2d => (dynamic)DoubleMatrix4x2(),
            Matrix4x3d => (dynamic)DoubleMatrix4x3(),
            _ => throw new OpenGLException(Constants.ERROR_INVALID_UNIFORM_TYPE)
        };
    }

    /// <summary>
    /// Gets the value of an array uniform.
    /// </summary>
    /// <typeparam name="TUniform">The type of the array uniform.</typeparam>
    /// <param name="length">The length of the array</param>
    /// <returns>The array uniform.</returns>
    /// <exception cref="OpenGLException">Thrown when the array type couldn't be handled.</exception>
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
            Matrix2[] => (dynamic)FloatMatrix2Array(length),
            Matrix2x3[] => (dynamic)FloatMatrix2x3Array(length),
            Matrix2x4[] => (dynamic)FloatMatrix2x4Array(length),
            Matrix3[] => (dynamic)FloatMatrix3Array(length),
            Matrix3x2[] => (dynamic)FloatMatrix3x2Array(length),
            Matrix3x4[] => (dynamic)FloatMatrix3x4Array(length),
            Matrix4[] => (dynamic)FloatMatrix4Array(length),
            Matrix4x2[] => (dynamic)FloatMatrix4x2Array(length),
            Matrix4x3[] => (dynamic)FloatMatrix4x3Array(length),
            Matrix2d[] => (dynamic)DoubleMatrix2Array(length),
            Matrix2x3d[] => (dynamic)DoubleMatrix2x3Array(length),
            Matrix2x4d[] => (dynamic)DoubleMatrix2x4Array(length),
            Matrix3d[] => (dynamic)DoubleMatrix3Array(length),
            Matrix3x2d[] => (dynamic)DoubleMatrix3x2Array(length),
            Matrix3x4d[] => (dynamic)DoubleMatrix3x4Array(length),
            Matrix4d[] => (dynamic)DoubleMatrix4Array(length),
            Matrix4x2d[] => (dynamic)DoubleMatrix4x2Array(length),
            Matrix4x3d[] => (dynamic)DoubleMatrix4x3Array(length),
            _ => throw new OpenGLException(Constants.ERROR_INVALID_UNIFORM_TYPE)
        };
    }

    /// <summary>
    /// Gets the <see cref="int"/> value from the uniform.
    /// </summary>
    /// <returns>An <see cref="int"/> value.</returns>
    public static int Int1()
    {
        GL.GetUniform(ProgramId, UniformLocation, out int v0);

        return v0;
    }

    /// <summary>
    /// Gets the <see cref="Vector2i"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector2i"/> value.</returns>
    public static Vector2i Int2()
    {
        int[] v0 = new int[2];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2i(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector3i"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector3i"/> value.</returns>
    public static Vector3i Int3()
    {
        int[] v0 = new int[3];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3i(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector4i"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector4i"/> value.</returns>
    public static Vector4i Int4()
    {
        int[] v0 = new int[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4i(v0);
    }

    /// <summary>
    /// Gets the <see cref="uint"/> value from the uniform.
    /// </summary>
    /// <returns>An <see cref="uint"/> value.</returns>
    public static uint UnsignedInt1()
    {
        GL.GetUniform((uint)ProgramId, UniformLocation, out uint v0);

        return v0;
    }

    /// <summary>
    /// Gets the <see cref="Vector2ui"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector2ui"/> value.</returns>
    public static Vector2ui UnsignedInt2()
    {
        uint[] v0 = new uint[2];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2ui(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector3ui"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector3ui"/> value.</returns>
    public static Vector3ui UnsignedInt3()
    {
        uint[] v0 = new uint[3];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3ui(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector4ui"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector4ui"/> value.</returns>
    public static Vector4ui UnsignedInt4()
    {
        uint[] v0 = new uint[4];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4ui(v0);
    }

    /// <summary>
    /// Gets the <see cref="float"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="float"/> value.</returns>
    public static float Float1()
    {
        GL.GetUniform(ProgramId, UniformLocation, out float v0);

        return v0;
    }

    /// <summary>
    /// Gets the <see cref="Vector2"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector2"/> value.</returns>
    public static Vector2 Float2()
    {
        float[] v0 = new float[2];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector3"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector3"/> value.</returns>
    public static Vector3 Float3()
    {
        float[] v0 = new float[3];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector4"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector4"/> value.</returns>
    public static Vector4 Float4()
    {
        float[] v0 = new float[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4(v0);
    }

    /// <summary>
    /// Gets the <see cref="double"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="double"/> value.</returns>
    public static double Double1()
    {
        GL.GetUniform(ProgramId, UniformLocation, out double v0);

        return v0;
    }

    /// <summary>
    /// Gets the <see cref="Vector2d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector2d"/> value.</returns>
    public static Vector2d Double2()
    {
        double[] v0 = new double[2];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2d(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector3d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector3d"/> value.</returns>
    public static Vector3d Double3()
    {
        double[] v0 = new double[3];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3d(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector4d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector4d"/> value.</returns>
    public static Vector4d Double4()
    {
        double[] v0 = new double[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4d(v0);
    }

    /// <summary>
    /// Gets the <see cref="bool"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="bool"/> value.</returns>
    public static int Bool1()
    {
        GL.GetUniform(ProgramId, UniformLocation, out int v0);

        return v0;
    }

    /// <summary>
    /// Gets the <see cref="Vector2b"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector2b"/> value.</returns>
    public static Vector2b Bool2()
    {
        int[] v0 = new int[2];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2b(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector3b"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector3b"/> value.</returns>
    public static Vector3b Bool3()
    {
        int[] v0 = new int[3];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3b(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector4b"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Vector4b"/> value.</returns>
    public static Vector4b Bool4()
    {
        int[] v0 = new int[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4b(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix2"/> value.</returns>
    public static Matrix2 FloatMatrix2()
    {
        float[] v0 = new float[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2x3"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix2x3"/> value.</returns>
    public static Matrix2x3 FloatMatrix2x3()
    {
        float[] v0 = new float[6];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x3(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2x4"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix2x4"/> value.</returns>
    public static Matrix2x4 FloatMatrix2x4()
    {
        float[] v0 = new float[8];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x4(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix3"/> value.</returns>
    public static Matrix3 FloatMatrix3()
    {
        float[] v0 = new float[9];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3x2"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix3x2"/> value.</returns>
    public static Matrix3x2 FloatMatrix3x2()
    {
        float[] v0 = new float[6];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x2(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3x4"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix3x4"/> value.</returns>
    public static Matrix3x4 FloatMatrix3x4()
    {
        float[] v0 = new float[12];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x4(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix4"/> value.</returns>
    public static Matrix4 FloatMatrix4()
    {
        float[] v0 = new float[16];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4x2"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix4x2"/> value.</returns>
    public static Matrix4x2 FloatMatrix4x2()
    {
        float[] v0 = new float[8];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x2(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4x3"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix4x3"/> value.</returns>
    public static Matrix4x3 FloatMatrix4x3()
    {
        float[] v0 = new float[12];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x3(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix2d"/> value.</returns>
    public static Matrix2d DoubleMatrix2()
    {
        double[] v0 = new double[4];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2d(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2x3d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix2x3d"/> value.</returns>
    public static Matrix2x3d DoubleMatrix2x3()
    {
        double[] v0 = new double[6];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x3d(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2x4d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix2x4d"/> value.</returns>
    public static Matrix2x4d DoubleMatrix2x4()
    {
        double[] v0 = new double[8];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x4d(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix3d"/> value.</returns>
    public static Matrix3d DoubleMatrix3()
    {
        double[] v0 = new double[9];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3d(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3x2d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix3x2d"/> value.</returns>
    public static Matrix3x2d DoubleMatrix3x2()
    {
        double[] v0 = new double[6];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x2d(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3x4d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix3x4d"/> value.</returns>
    public static Matrix3x4d DoubleMatrix3x4()
    {
        double[] v0 = new double[12];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x4d(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix4d"/> value.</returns>
    public static Matrix4d DoubleMatrix4()
    {
        double[] v0 = new double[16];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4d(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4x2d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix4x2d"/> value.</returns>
    public static Matrix4x2d DoubleMatrix4x2()
    {
        double[] v0 = new double[8];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x2d(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4x3d"/> value from the uniform.
    /// </summary>
    /// <returns>A <see cref="Matrix4x3d"/> value.</returns>
    public static Matrix4x3d DoubleMatrix4x3()
    {
        double[] v0 = new double[12];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x3d(v0);
    }

    /// <summary>
    /// Gets the <see cref="int"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>An <see cref="int"/> array.</returns>
    public static int[] Int1Array(int length)
    {
        int[] v0 = new int[length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return v0;
    }

    /// <summary>
    /// Gets the <see cref="Vector2i"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector2i"/> array.</returns>
    public static Vector2i[] Int2Array(int length)
    {
        int[] v0 = new int[2 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2iArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector3i"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector3i"/> array.</returns>
    public static Vector3i[] Int3Array(int length)
    {
        int[] v0 = new int[3 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3iArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector4i"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector4i"/> array.</returns>
    public static Vector4i[] Int4Array(int length)
    {
        int[] v0 = new int[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4iArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="uint"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>An <see cref="uint"/> array.</returns>
    public static uint[] UnsignedInt1Array(int length)
    {
        uint[] v0 = new uint[length];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return v0;
    }

    /// <summary>
    /// Gets the <see cref="Vector2ui"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector2ui"/> array.</returns>
    public static Vector2ui[] UnsignedInt2Array(int length)
    {
        uint[] v0 = new uint[2 * length];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2uiArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector3ui"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector3ui"/> array.</returns>
    public static Vector3ui[] UnsignedInt3Array(int length)
    {
        uint[] v0 = new uint[3 * length];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3uiArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector4ui"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector4ui"/> array.</returns>
    public static Vector4ui[] UnsignedInt4Array(int length)
    {
        uint[] v0 = new uint[4 * length];

        GL.GetUniform((uint)ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4uiArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="float"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="float"/> array.</returns>
    public static float[] Float1Array(int length)
    {
        float[] v0 = new float[length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return v0;
    }

    /// <summary>
    /// Gets the <see cref="Vector2"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector2"/> array.</returns>
    public static Vector2[] Float2Array(int length)
    {
        float[] v0 = new float[2 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector3"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector3"/> array.</returns>
    public static Vector3[] Float3Array(int length)
    {
        float[] v0 = new float[3 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector4"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector4"/> array.</returns>
    public static Vector4[] Float4Array(int length)
    {
        float[] v0 = new float[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="double"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="double"/> array.</returns>
    public static double[] Double1Array(int length)
    {
        double[] v0 = new double[length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return v0;
    }

    /// <summary>
    /// Gets the <see cref="Vector2d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector2d"/> array.</returns>
    public static Vector2d[] Double2Array(int length)
    {
        double[] v0 = new double[2 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2dArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector3d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector3d"/> array.</returns>
    public static Vector3d[] Double3Array(int length)
    {
        double[] v0 = new double[3 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3dArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector4d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector4d"/> array.</returns>
    public static Vector4d[] Double4Array(int length)
    {
        double[] v0 = new double[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4dArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="bool"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="bool"/> array.</returns>
    public static bool[] Bool1Array(int length)
    {
        int[] v0 = new int[length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return v0.Select(x => x == 1).ToArray();
    }

    /// <summary>
    /// Gets the <see cref="Vector2b"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector2b"/> array.</returns>
    public static Vector2b[] Bool2Array(int length)
    {
        int[] v0 = new int[2 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector2bArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector3b"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector3b"/> array.</returns>
    public static Vector3b[] Bool3Array(int length)
    {
        int[] v0 = new int[3 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector3bArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Vector4b"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Vector4b"/> array.</returns>
    public static Vector4b[] Bool4Array(int length)
    {
        int[] v0 = new int[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToVector4bArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix2"/> array.</returns>
    public static Matrix2[] FloatMatrix2Array(int length)
    {
        float[] v0 = new float[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2x3"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix2x3"/> array.</returns>
    public static Matrix2x3[] FloatMatrix2x3Array(int length)
    {
        float[] v0 = new float[6 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x3Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2x4"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix2x4"/> array.</returns>
    public static Matrix2x4[] FloatMatrix2x4Array(int length)
    {
        float[] v0 = new float[8 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x4Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix3"/> array.</returns>
    public static Matrix3[] FloatMatrix3Array(int length)
    {
        float[] v0 = new float[9 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3x2"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix3x2"/> array.</returns>
    public static Matrix3x2[] FloatMatrix3x2Array(int length)
    {
        float[] v0 = new float[6 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x2Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3x4"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix3x4"/> array.</returns>
    public static Matrix3x4[] FloatMatrix3x4Array(int length)
    {
        float[] v0 = new float[12 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x4Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix4"/> array.</returns>
    public static Matrix4[] FloatMatrix4Array(int length)
    {
        float[] v0 = new float[16 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4x2"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix4x2"/> array.</returns>
    public static Matrix4x2[] FloatMatrix4x2Array(int length)
    {
        float[] v0 = new float[8 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x2Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4x3"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix4x3"/> array.</returns>
    public static Matrix4x3[] FloatMatrix4x3Array(int length)
    {
        float[] v0 = new float[12 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x3Array(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix2d"/> array.</returns>
    public static Matrix2d[] DoubleMatrix2Array(int length)
    {
        double[] v0 = new double[4 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2dArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2x3d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix2x3d"/> array.</returns>
    public static Matrix2x3d[] DoubleMatrix2x3Array(int length)
    {
        double[] v0 = new double[6 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x3dArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix2x4d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix2x4d"/> array.</returns>
    public static Matrix2x4d[] DoubleMatrix2x4Array(int length)
    {
        double[] v0 = new double[8 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix2x4dArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix3d"/> array.</returns>
    public static Matrix3d[] DoubleMatrix3Array(int length)
    {
        double[] v0 = new double[9 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3dArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3x2d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix3x2d"/> array.</returns>
    public static Matrix3x2d[] DoubleMatrix3x2Array(int length)
    {
        double[] v0 = new double[6 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x2dArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix3x4d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix3x4d"/> array.</returns>
    public static Matrix3x4d[] DoubleMatrix3x4Array(int length)
    {
        double[] v0 = new double[12 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix3x4dArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix4d"/> array.</returns>
    public static Matrix4d[] DoubleMatrix4Array(int length)
    {
        double[] v0 = new double[16 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4dArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4x2d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix4x2d"/> array.</returns>
    public static Matrix4x2d[] DoubleMatrix4x2Array(int length)
    {
        double[] v0 = new double[8 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x2dArray(v0);
    }

    /// <summary>
    /// Gets the <see cref="Matrix4x3d"/> array from the uniform.
    /// </summary>
    /// <param name="length">The length of the array.</param>
    /// <returns>A <see cref="Matrix4x3d"/> array.</returns>
    public static Matrix4x3d[] DoubleMatrix4x3Array(int length)
    {
        double[] v0 = new double[12 * length];

        GL.GetUniform(ProgramId, UniformLocation, v0);

        return GetTypeHelpers.ArrayToMatrix4x3dArray(v0);
    }
}
