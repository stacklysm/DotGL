using OpenTK.Mathematics;

namespace Backend.Graphics.OpenGL.Helper;

/// <summary>
/// Contains helper functions to transform arrays into structured data.
/// </summary>
public static class GetTypeHelpers
{
    /// <summary>
    /// Transforms an <see cref="int"/> sequence into a <see cref="Vector2i"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 2.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector2i"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 2.</exception>
    public static Vector2i ArrayToVector2i(int[] array)
    {
        return new(array[0], array[1]);
    }

    /// <summary>
    /// Transforms an <see cref="int"/> sequence into a <see cref="Vector3i"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 3.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector3i"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 3.</exception>
    public static Vector3i ArrayToVector3i(int[] array)
    {
        return new(array[0], array[1], array[2]);
    }

    /// <summary>
    /// Transforms an <see cref="int"/> sequence into a <see cref="Vector4i"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector4i"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 4.</exception>
    public static Vector4i ArrayToVector4i(int[] array)
    {
        return new(array[0], array[1], array[2], array[3]);
    }

    /// <summary>
    /// Transforms an <see cref="uint"/> sequence into a <see cref="Vector2ui"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 2.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector2ui"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 2.</exception>
    public static Vector2ui ArrayToVector2ui(uint[] array)
    {
        return new(array[0], array[1]);
    }

    /// <summary>
    /// Transforms an <see cref="uint"/> sequence into a <see cref="Vector3ui"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 3.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector3ui"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 3.</exception>
    public static Vector3ui ArrayToVector3ui(uint[] array)
    {
        return new(array[0], array[1], array[2]);
    }

    /// <summary>
    /// Transforms an <see cref="uint"/> sequence into a <see cref="Vector4ui"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector4ui"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 4.</exception>
    public static Vector4ui ArrayToVector4ui(uint[] array)
    {
        return new(array[0], array[1], array[2], array[3]);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Vector2"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 2.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector2"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 2.</exception>
    public static Vector2 ArrayToVector2(float[] array)
    {
        return new(array[0], array[1]);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Vector3"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 3.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector3"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 3.</exception>
    public static Vector3 ArrayToVector3(float[] array)
    {
        return new(array[0], array[1], array[2]);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Vector4"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector4"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 4.</exception>
    public static Vector4 ArrayToVector4(float[] array)
    {
        return new(array[0], array[1], array[2], array[3]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Vector2d"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 2.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector2d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 2.</exception>
    public static Vector2d ArrayToVector2d(double[] array)
    {
        return new(array[0], array[1]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Vector3d"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 3.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector3d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 3.</exception>
    public static Vector3d ArrayToVector3d(double[] array)
    {
        return new(array[0], array[1], array[2]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Vector4d"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector4d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 4.</exception>
    public static Vector4d ArrayToVector4d(double[] array)
    {
        return new(array[0], array[1], array[2], array[3]);
    }

    /// <summary>
    /// Transforms a <see cref="bool"/> sequence into a <see cref="Vector2b"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 2.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector2b"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 2.</exception>
    public static Vector2b ArrayToVector2b(int[] array)
    {
        return new(array[0] == 1, array[1] == 1);
    }

    /// <summary>
    /// Transforms a <see cref="bool"/> sequence into a <see cref="Vector3b"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 3.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector3b"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 3.</exception>
    public static Vector3b ArrayToVector3b(int[] array)
    {
        return new(array[0] == 1, array[1] == 1, array[2] == 1);
    }

    /// <summary>
    /// Transforms a <see cref="bool"/> sequence into a <see cref="Vector4b"/>.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector4b"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 4.</exception>
    public static Vector4b ArrayToVector4b(int[] array)
    {
        return new(array[0] == 1, array[1] == 1, array[2] == 1, array[3] == 1);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Matrix2"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 4.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix2"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 4.</exception>
    public static Matrix2 ArrayToMatrix2(float[] array)
    {
        return new(
            array[0], array[1],
            array[2], array[3]);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Matrix2x3"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 6.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix2x3"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 6.</exception>
    public static Matrix2x3 ArrayToMatrix2x3(float[] array)
    {
        return new(
            array[0], array[1], array[2],
            array[3], array[4], array[5]);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Matrix2x4"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 8.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix2x4"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 8.</exception>
    public static Matrix2x4 ArrayToMatrix2x4(float[] array)
    {
        return new(
            array[0], array[1], array[2], array[3],
            array[4], array[5], array[6], array[7]);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Matrix3"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 9.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix3"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 9.</exception>
    public static Matrix3 ArrayToMatrix3(float[] array)
    {
        return new(
            array[0], array[1], array[2],
            array[3], array[4], array[5],
            array[6], array[7], array[8]);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Matrix3x2"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 6.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix3x2"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 6.</exception>
    public static Matrix3x2 ArrayToMatrix3x2(float[] array)
    {
        return new(
            array[0], array[1],
            array[2], array[3],
            array[4], array[5]);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Matrix3x4"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 12.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix3x4"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 12.</exception>
    public static Matrix3x4 ArrayToMatrix3x4(float[] array)
    {
        return new(
            array[0], array[1], array[2], array[3],
            array[4], array[5], array[6], array[7],
            array[8], array[9], array[10], array[11]);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Matrix4"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 16.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix4"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 16.</exception>
    public static Matrix4 ArrayToMatrix4(float[] array)
    {
        return new(
            array[0], array[1], array[2], array[3],
            array[4], array[5], array[6], array[7],
            array[8], array[9], array[10], array[11],
            array[12], array[13], array[14], array[15]);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Matrix4x2"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 8.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix4x2"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 8.</exception>
    public static Matrix4x2 ArrayToMatrix4x2(float[] array)
    {
        return new(
            array[0], array[1],
            array[2], array[3],
            array[4], array[5],
            array[6], array[7]);
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into a <see cref="Matrix4x3"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 12.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix4x3"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 12.</exception>
    public static Matrix4x3 ArrayToMatrix4x3(float[] array)
    {
        return new(
            array[0], array[1], array[2],
            array[3], array[4], array[5],
            array[6], array[7], array[8],
            array[9], array[10], array[11]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Matrix2d"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 4.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix2d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 4.</exception>
    public static Matrix2d ArrayToMatrix2d(double[] array)
    {
        return new(
            array[0], array[1],
            array[2], array[3]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Matrix2x3d"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 6.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix2x3d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 6.</exception>
    public static Matrix2x3d ArrayToMatrix2x3d(double[] array)
    {
        return new(
            array[0], array[1], array[2],
            array[3], array[4], array[5]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Matrix2x4d"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 8.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix2x4d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 8.</exception>
    public static Matrix2x4d ArrayToMatrix2x4d(double[] array)
    {
        return new(
            array[0], array[1], array[2], array[3],
            array[4], array[5], array[6], array[7]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Matrix3d"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 9.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix3d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 9.</exception>
    public static Matrix3d ArrayToMatrix3d(double[] array)
    {
        return new(
            array[0], array[1], array[2],
            array[3], array[4], array[5],
            array[6], array[7], array[8]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Matrix3x2d"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 6.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix3x2d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 6.</exception>
    public static Matrix3x2d ArrayToMatrix3x2d(double[] array)
    {
        return new(
            array[0], array[1],
            array[2], array[3],
            array[4], array[5]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Matrix3x4d"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 12.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix3x4d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 12.</exception>
    public static Matrix3x4d ArrayToMatrix3x4d(double[] array)
    {
        return new(
            array[0], array[1], array[2], array[3],
            array[4], array[5], array[6], array[7],
            array[8], array[9], array[10], array[11]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Matrix4d"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 16.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix4d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 16.</exception>
    public static Matrix4d ArrayToMatrix4d(double[] array)
    {
        return new(
            array[0], array[1], array[2], array[3],
            array[4], array[5], array[6], array[7],
            array[8], array[9], array[10], array[11],
            array[12], array[13], array[14], array[15]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Matrix4x2d"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 8.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix4x2d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 8.</exception>
    public static Matrix4x2d ArrayToMatrix4x2d(double[] array)
    {
        return new(
            array[0], array[1],
            array[2], array[3],
            array[4], array[5],
            array[6], array[7]);
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into a <see cref="Matrix4x3d"/> with row-major ordering.
    /// </summary>
    /// <remarks>This function will fail if the array length is less than 12.</remarks>
    /// <param name="array">The array to be transformed</param>
    /// <returns>A <see cref="Matrix4x3d"/> object.</returns>
    /// <exception cref="IndexOutOfRangeException">Thrown if the array length is less than 12.</exception>
    public static Matrix4x3d ArrayToMatrix4x3d(double[] array)
    {
        return new(
            array[0], array[1], array[2],
            array[3], array[4], array[5],
            array[6], array[7], array[8],
            array[9], array[10], array[11]);
    }

    /// <summary>
    /// Transforms an <see cref="int"/> sequence into an array of <see cref="Vector2i"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 2.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector2i"/> array.</returns>
    public static Vector2i[] ArrayToVector2iArray(int[] array)
    {
        Vector2i[] result = new Vector2i[array.Length / 2];

        for (int i = 0; i < array.Length / 2; i++)
        {
            result[i].X = array[i * 2];
            result[i].Y = array[(i * 2) + 1];
        }

        return result;
    }

    /// <summary>
    /// Transforms an <see cref="int"/> sequence into an array of <see cref="Vector3i"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 3.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector3i"/> array.</returns>
    public static Vector3i[] ArrayToVector3iArray(int[] array)
    {
        Vector3i[] result = new Vector3i[array.Length / 3];

        for (int i = 0; i < array.Length / 3; i++)
        {
            result[i].X = array[i * 3];
            result[i].Y = array[(i * 3) + 1];
            result[i].Z = array[(i * 3) + 2];
        }

        return result;
    }

    /// <summary>
    /// Transforms an <see cref="int"/> sequence into an array of <see cref="Vector4i"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector4i"/> array.</returns>
    public static Vector4i[] ArrayToVector4iArray(int[] array)
    {
        Vector4i[] result = new Vector4i[array.Length / 4];

        for (int i = 0; i < array.Length / 4; i++)
        {
            result[i].X = array[i * 4];
            result[i].Y = array[(i * 4) + 1];
            result[i].Y = array[(i * 4) + 2];
            result[i].Y = array[(i * 4) + 3];
        }

        return result;
    }

    /// <summary>
    /// Transforms an <see cref="uint"/> sequence into an array of <see cref="Vector2ui"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 2.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector2ui"/> array.</returns>
    public static Vector2ui[] ArrayToVector2uiArray(uint[] array)
    {
        Vector2ui[] result = new Vector2ui[array.Length / 2];

        for (int i = 0; i < array.Length / 2; i++)
        {
            result[i].Item1 = array[i * 2];
            result[i].Item2 = array[(i * 2) + 1];
        }

        return result;
    }

    /// <summary>
    /// Transforms an <see cref="uint"/> sequence into an array of <see cref="Vector3ui"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 3.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector3ui"/> array.</returns>
    public static Vector3ui[] ArrayToVector3uiArray(uint[] array)
    {
        Vector3ui[] result = new Vector3ui[array.Length / 3];

        for (int i = 0; i < array.Length / 3; i++)
        {
            result[i].Item1 = array[i * 3];
            result[i].Item2 = array[(i * 3) + 1];
            result[i].Item3 = array[(i * 3) + 2];
        }

        return result;
    }

    /// <summary>
    /// Transforms an <see cref="uint"/> sequence into an array of <see cref="Vector4ui"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector4ui"/> array.</returns>
    public static Vector4ui[] ArrayToVector4uiArray(uint[] array)
    {
        Vector4ui[] result = new Vector4ui[array.Length / 4];

        for (int i = 0; i < array.Length / 4; i++)
        {
            result[i].Item1 = array[i * 4];
            result[i].Item2 = array[(i * 4) + 1];
            result[i].Item3 = array[(i * 4) + 2];
            result[i].Item4 = array[(i * 4) + 3];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Vector2"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 2.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector2"/> array.</returns>
    public static Vector2[] ArrayToVector2Array(float[] array)
    {
        Vector2[] result = new Vector2[array.Length / 2];

        for (int i = 0; i < array.Length / 2; i++)
        {
            result[i].X = array[i * 2];
            result[i].Y = array[(i * 2) + 1];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Vector3"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 3.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector3"/> array.</returns>
    public static Vector3[] ArrayToVector3Array(float[] array)
    {
        Vector3[] result = new Vector3[array.Length / 3];

        for (int i = 0; i < array.Length / 3; i++)
        {
            result[i].X = array[i * 3];
            result[i].Y = array[(i * 3) + 1];
            result[i].Z = array[(i * 3) + 2];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Vector4"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector4"/> array.</returns>
    public static Vector4[] ArrayToVector4Array(float[] array)
    {
        Vector4[] result = new Vector4[array.Length / 4];

        for (int i = 0; i < array.Length / 4; i++)
        {
            result[i].X = array[i * 4];
            result[i].Y = array[(i * 4) + 1];
            result[i].Y = array[(i * 4) + 2];
            result[i].Y = array[(i * 4) + 3];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Vector2d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 2.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector2d"/> array.</returns>
    public static Vector2d[] ArrayToVector2dArray(double[] array)
    {
        Vector2d[] result = new Vector2d[array.Length / 2];

        for (int i = 0; i < array.Length / 2; i++)
        {
            result[i].X = array[i * 2];
            result[i].Y = array[(i * 2) + 1];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Vector3d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 3.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector3d"/> array.</returns>
    public static Vector3d[] ArrayToVector3dArray(double[] array)
    {
        Vector3d[] result = new Vector3d[array.Length / 3];

        for (int i = 0; i < array.Length / 3; i++)
        {
            result[i].X = array[i * 3];
            result[i].Y = array[(i * 3) + 1];
            result[i].Z = array[(i * 3) + 2];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Vector4d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector4d"/> array.</returns>
    public static Vector4d[] ArrayToVector4dArray(double[] array)
    {
        Vector4d[] result = new Vector4d[array.Length / 4];

        for (int i = 0; i < array.Length / 4; i++)
        {
            result[i].X = array[i * 4];
            result[i].Y = array[(i * 4) + 1];
            result[i].Y = array[(i * 4) + 2];
            result[i].Y = array[(i * 4) + 3];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="bool"/> sequence into an array of <see cref="Vector2b"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 2.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector2b"/> array.</returns>
    public static Vector2b[] ArrayToVector2bArray(int[] array)
    {
        Vector2b[] result = new Vector2b[array.Length / 2];

        for (int i = 0; i < array.Length / 2; i++)
        {
            result[i].Item1 = array[i * 2] == 1;
            result[i].Item2 = array[(i * 2) + 1] == 1;
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="bool"/> sequence into an array of <see cref="Vector3b"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 3.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector3b"/> array.</returns>
    public static Vector3b[] ArrayToVector3bArray(int[] array)
    {
        Vector3b[] result = new Vector3b[array.Length / 3];

        for (int i = 0; i < array.Length / 3; i++)
        {
            result[i].Item1 = array[i * 3] == 1;
            result[i].Item2 = array[(i * 3) + 1] == 1;
            result[i].Item3 = array[(i * 3) + 2] == 1;
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="bool"/> sequence into an array of <see cref="Vector4b"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Vector4b"/> array.</returns>
    public static Vector4b[] ArrayToVector4bArray(int[] array)
    {
        Vector4b[] result = new Vector4b[array.Length / 4];

        for (int i = 0; i < array.Length / 4; i++)
        {
            result[i].Item1 = array[i * 4] == 1;
            result[i].Item2 = array[(i * 4) + 1] == 1;
            result[i].Item3 = array[(i * 4) + 2] == 1;
            result[i].Item4 = array[(i * 4) + 3] == 1;
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Matrix2"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix2"/> array.</returns>
    public static Matrix2[] ArrayToMatrix2Array(float[] array)
    {
        Matrix2[] result = new Matrix2[array.Length / 4];

        for (int i = 0; i < array.Length / 4; i++)
        {
            result[i].M11 = array[i * 4];
            result[i].M12 = array[(i * 4) + 1];
            result[i].M21 = array[(i * 4) + 2];
            result[i].M22 = array[(i * 4) + 3];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Matrix2x3"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 6.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix2x3"/> array.</returns>
    public static Matrix2x3[] ArrayToMatrix2x3Array(float[] array)
    {
        Matrix2x3[] result = new Matrix2x3[array.Length / 6];

        for (int i = 0; i < array.Length / 6; i++)
        {
            result[i].M11 = array[i * 6];
            result[i].M12 = array[(i * 6) + 1];
            result[i].M13 = array[(i * 6) + 2];
            result[i].M21 = array[(i * 6) + 3];
            result[i].M22 = array[(i * 6) + 4];
            result[i].M23 = array[(i * 6) + 5];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Matrix2x4"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 8.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix2x4"/> array.</returns>
    public static Matrix2x4[] ArrayToMatrix2x4Array(float[] array)
    {
        Matrix2x4[] result = new Matrix2x4[array.Length / 8];

        for (int i = 0; i < array.Length / 8; i++)
        {
            result[i].M11 = array[i * 8];
            result[i].M12 = array[(i * 8) + 1];
            result[i].M13 = array[(i * 8) + 2];
            result[i].M14 = array[(i * 8) + 3];
            result[i].M21 = array[(i * 8) + 4];
            result[i].M22 = array[(i * 8) + 5];
            result[i].M23 = array[(i * 8) + 6];
            result[i].M24 = array[(i * 8) + 7];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Matrix3"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 9.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix3"/> array.</returns>
    public static Matrix3[] ArrayToMatrix3Array(float[] array)
    {
        Matrix3[] result = new Matrix3[array.Length / 9];

        for (int i = 0; i < array.Length / 9; i++)
        {
            result[i].M11 = array[i * 9];
            result[i].M12 = array[(i * 9) + 1];
            result[i].M13 = array[(i * 9) + 2];
            result[i].M21 = array[(i * 9) + 3];
            result[i].M22 = array[(i * 9) + 4];
            result[i].M23 = array[(i * 9) + 5];
            result[i].M31 = array[(i * 9) + 6];
            result[i].M32 = array[(i * 9) + 7];
            result[i].M33 = array[(i * 9) + 8];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Matrix3x2"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 6.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix3x2"/> array.</returns>
    public static Matrix3x2[] ArrayToMatrix3x2Array(float[] array)
    {
        Matrix3x2[] result = new Matrix3x2[array.Length / 6];

        for (int i = 0; i < array.Length / 6; i++)
        {
            result[i].M11 = array[i * 6];
            result[i].M12 = array[(i * 6) + 1];
            result[i].M21 = array[(i * 6) + 2];
            result[i].M22 = array[(i * 6) + 3];
            result[i].M31 = array[(i * 6) + 4];
            result[i].M32 = array[(i * 6) + 5];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Matrix3x4"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 12.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix3x4"/> array.</returns>
    public static Matrix3x4[] ArrayToMatrix3x4Array(float[] array)
    {
        Matrix3x4[] result = new Matrix3x4[array.Length / 12];

        for (int i = 0; i < array.Length / 12; i++)
        {
            result[i].M11 = array[i * 12];
            result[i].M12 = array[(i * 12) + 1];
            result[i].M13 = array[(i * 12) + 2];
            result[i].M14 = array[(i * 12) + 3];
            result[i].M21 = array[(i * 12) + 4];
            result[i].M22 = array[(i * 12) + 5];
            result[i].M23 = array[(i * 12) + 6];
            result[i].M24 = array[(i * 12) + 7];
            result[i].M31 = array[(i * 12) + 8];
            result[i].M32 = array[(i * 12) + 9];
            result[i].M33 = array[(i * 12) + 10];
            result[i].M34 = array[(i * 12) + 11];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Matrix4"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 16.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix4"/> array.</returns>
    public static Matrix4[] ArrayToMatrix4Array(float[] array)
    {
        Matrix4[] result = new Matrix4[array.Length / 16];

        for (int i = 0; i < array.Length / 16; i++)
        {
            result[i].M11 = array[i * 16];
            result[i].M12 = array[(i * 16) + 1];
            result[i].M13 = array[(i * 16) + 2];
            result[i].M14 = array[(i * 16) + 3];
            result[i].M21 = array[(i * 16) + 4];
            result[i].M22 = array[(i * 16) + 5];
            result[i].M23 = array[(i * 16) + 6];
            result[i].M24 = array[(i * 16) + 7];
            result[i].M31 = array[(i * 16) + 8];
            result[i].M32 = array[(i * 16) + 9];
            result[i].M33 = array[(i * 16) + 10];
            result[i].M34 = array[(i * 16) + 11];
            result[i].M41 = array[(i * 16) + 12];
            result[i].M42 = array[(i * 16) + 13];
            result[i].M43 = array[(i * 16) + 14];
            result[i].M44 = array[(i * 16) + 15];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Matrix4x2"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 8.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix4x2"/> array.</returns>
    public static Matrix4x2[] ArrayToMatrix4x2Array(float[] array)
    {
        Matrix4x2[] result = new Matrix4x2[array.Length / 8];

        for (int i = 0; i < array.Length / 8; i++)
        {
            result[i].M11 = array[i * 8];
            result[i].M12 = array[(i * 8) + 1];
            result[i].M21 = array[(i * 8) + 2];
            result[i].M22 = array[(i * 8) + 3];
            result[i].M31 = array[(i * 8) + 4];
            result[i].M32 = array[(i * 8) + 5];
            result[i].M41 = array[(i * 8) + 6];
            result[i].M42 = array[(i * 8) + 7];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="float"/> sequence into an array of <see cref="Matrix4x3"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 12.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix4x3"/> array.</returns>
    public static Matrix4x3[] ArrayToMatrix4x3Array(float[] array)
    {
        Matrix4x3[] result = new Matrix4x3[array.Length / 12];

        for (int i = 0; i < array.Length / 12; i++)
        {
            result[i].M11 = array[i * 12];
            result[i].M12 = array[(i * 12) + 1];
            result[i].M13 = array[(i * 12) + 2];
            result[i].M21 = array[(i * 12) + 3];
            result[i].M22 = array[(i * 12) + 4];
            result[i].M23 = array[(i * 12) + 5];
            result[i].M31 = array[(i * 12) + 6];
            result[i].M32 = array[(i * 12) + 7];
            result[i].M33 = array[(i * 12) + 8];
            result[i].M41 = array[(i * 12) + 9];
            result[i].M42 = array[(i * 12) + 10];
            result[i].M43 = array[(i * 12) + 11];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Matrix2d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 4.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix2d"/> array.</returns>
    public static Matrix2d[] ArrayToMatrix2dArray(double[] array)
    {
        Matrix2d[] result = new Matrix2d[array.Length / 4];

        for (int i = 0; i < array.Length / 4; i++)
        {
            result[i].M11 = array[i * 4];
            result[i].M12 = array[(i * 4) + 1];
            result[i].M21 = array[(i * 4) + 2];
            result[i].M22 = array[(i * 4) + 3];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Matrix2x3d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 6.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix2x3d"/> array.</returns>
    public static Matrix2x3d[] ArrayToMatrix2x3dArray(double[] array)
    {
        Matrix2x3d[] result = new Matrix2x3d[array.Length / 6];

        for (int i = 0; i < array.Length / 6; i++)
        {
            result[i].M11 = array[i * 6];
            result[i].M12 = array[(i * 6) + 1];
            result[i].M13 = array[(i * 6) + 2];
            result[i].M21 = array[(i * 6) + 3];
            result[i].M22 = array[(i * 6) + 4];
            result[i].M23 = array[(i * 6) + 5];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Matrix2x4d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 8.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix2x4d"/> array.</returns>
    public static Matrix2x4d[] ArrayToMatrix2x4dArray(double[] array)
    {
        Matrix2x4d[] result = new Matrix2x4d[array.Length / 8];

        for (int i = 0; i < array.Length / 8; i++)
        {
            result[i].M11 = array[i * 8];
            result[i].M12 = array[(i * 8) + 1];
            result[i].M13 = array[(i * 8) + 2];
            result[i].M14 = array[(i * 8) + 3];
            result[i].M21 = array[(i * 8) + 4];
            result[i].M22 = array[(i * 8) + 5];
            result[i].M23 = array[(i * 8) + 6];
            result[i].M24 = array[(i * 8) + 7];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Matrix3d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 9.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix3d"/> array.</returns>
    public static Matrix3d[] ArrayToMatrix3dArray(double[] array)
    {
        Matrix3d[] result = new Matrix3d[array.Length / 9];

        for (int i = 0; i < array.Length / 9; i++)
        {
            result[i].M11 = array[i * 9];
            result[i].M12 = array[(i * 9) + 1];
            result[i].M13 = array[(i * 9) + 2];
            result[i].M21 = array[(i * 9) + 3];
            result[i].M22 = array[(i * 9) + 4];
            result[i].M23 = array[(i * 9) + 5];
            result[i].M31 = array[(i * 9) + 6];
            result[i].M32 = array[(i * 9) + 7];
            result[i].M33 = array[(i * 9) + 8];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Matrix3x2d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 6.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix3x2d"/> array.</returns>
    public static Matrix3x2d[] ArrayToMatrix3x2dArray(double[] array)
    {
        Matrix3x2d[] result = new Matrix3x2d[array.Length / 6];

        for (int i = 0; i < array.Length / 6; i++)
        {
            result[i].M11 = array[i * 6];
            result[i].M12 = array[(i * 6) + 1];
            result[i].M21 = array[(i * 6) + 2];
            result[i].M22 = array[(i * 6) + 3];
            result[i].M31 = array[(i * 6) + 4];
            result[i].M32 = array[(i * 6) + 5];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Matrix3x4d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 12.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix3x4d"/> array.</returns>
    public static Matrix3x4d[] ArrayToMatrix3x4dArray(double[] array)
    {
        Matrix3x4d[] result = new Matrix3x4d[array.Length / 12];

        for (int i = 0; i < array.Length / 12; i++)
        {
            result[i].M11 = array[i * 12];
            result[i].M12 = array[(i * 12) + 1];
            result[i].M13 = array[(i * 12) + 2];
            result[i].M14 = array[(i * 12) + 3];
            result[i].M21 = array[(i * 12) + 4];
            result[i].M22 = array[(i * 12) + 5];
            result[i].M23 = array[(i * 12) + 6];
            result[i].M24 = array[(i * 12) + 7];
            result[i].M31 = array[(i * 12) + 8];
            result[i].M32 = array[(i * 12) + 9];
            result[i].M33 = array[(i * 12) + 10];
            result[i].M34 = array[(i * 12) + 11];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Matrix4d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 16.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix4d"/> array.</returns>
    public static Matrix4d[] ArrayToMatrix4dArray(double[] array)
    {
        Matrix4d[] result = new Matrix4d[array.Length / 16];

        for (int i = 0; i < array.Length / 16; i++)
        {
            result[i].M11 = array[i * 16];
            result[i].M12 = array[(i * 16) + 1];
            result[i].M13 = array[(i * 16) + 2];
            result[i].M14 = array[(i * 16) + 3];
            result[i].M21 = array[(i * 16) + 4];
            result[i].M22 = array[(i * 16) + 5];
            result[i].M23 = array[(i * 16) + 6];
            result[i].M24 = array[(i * 16) + 7];
            result[i].M31 = array[(i * 16) + 8];
            result[i].M32 = array[(i * 16) + 9];
            result[i].M33 = array[(i * 16) + 10];
            result[i].M34 = array[(i * 16) + 11];
            result[i].M41 = array[(i * 16) + 12];
            result[i].M42 = array[(i * 16) + 13];
            result[i].M43 = array[(i * 16) + 14];
            result[i].M44 = array[(i * 16) + 15];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Matrix4x2d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 8.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix4x2d"/> array.</returns>
    public static Matrix4x2d[] ArrayToMatrix4x2dArray(double[] array)
    {
        Matrix4x2d[] result = new Matrix4x2d[array.Length / 8];

        for (int i = 0; i < array.Length / 8; i++)
        {
            result[i].M11 = array[i * 8];
            result[i].M12 = array[(i * 8) + 1];
            result[i].M21 = array[(i * 8) + 2];
            result[i].M22 = array[(i * 8) + 3];
            result[i].M31 = array[(i * 8) + 4];
            result[i].M32 = array[(i * 8) + 5];
            result[i].M41 = array[(i * 8) + 6];
            result[i].M42 = array[(i * 8) + 7];
        }

        return result;
    }

    /// <summary>
    /// Transforms a <see cref="double"/> sequence into an array of <see cref="Matrix4x3d"/> values.
    /// </summary>
    /// <remarks>This function won't work as expected if the array length is not divisible by 12.</remarks>
    /// <param name="array">The array to be transformed.</param>
    /// <returns>A <see cref="Matrix4x3d"/> array.</returns>
    public static Matrix4x3d[] ArrayToMatrix4x3dArray(double[] array)
    {
        Matrix4x3d[] result = new Matrix4x3d[array.Length / 12];

        for (int i = 0; i < array.Length / 12; i++)
        {
            result[i].M11 = array[i * 12];
            result[i].M12 = array[(i * 12) + 1];
            result[i].M13 = array[(i * 12) + 2];
            result[i].M21 = array[(i * 12) + 3];
            result[i].M22 = array[(i * 12) + 4];
            result[i].M23 = array[(i * 12) + 5];
            result[i].M31 = array[(i * 12) + 6];
            result[i].M32 = array[(i * 12) + 7];
            result[i].M33 = array[(i * 12) + 8];
            result[i].M41 = array[(i * 12) + 9];
            result[i].M42 = array[(i * 12) + 10];
            result[i].M43 = array[(i * 12) + 11];
        }

        return result;
    }
}
