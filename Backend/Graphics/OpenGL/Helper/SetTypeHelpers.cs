using OpenTK.Mathematics;

namespace Backend.Graphics.OpenGL.Helper;

public static class SetTypeHelpers
{
    public static int[] Vector2iArrayToArray(Vector2i[] vectors)
    {
        int[] result = new int[2 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[2 * i] = vectors[i].X;
            result[(2 * i) + 1] = vectors[i].Y;
        }

        return result;
    }

    public static int[] Vector3iArrayToArray(Vector3i[] vectors)
    {
        int[] result = new int[3 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[3 * i] = vectors[i].X;
            result[(3 * i) + 1] = vectors[i].Y;
            result[(3 * i) + 2] = vectors[i].Z;
        }

        return result;
    }

    public static int[] Vector4iArrayToArray(Vector4i[] vectors)
    {
        int[] result = new int[4 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[4 * i] = vectors[i].X;
            result[(4 * i) + 1] = vectors[i].Y;
            result[(4 * i) + 2] = vectors[i].Z;
            result[(4 * i) + 3] = vectors[i].W;
        }

        return result;
    }

    public static uint[] Vector2uiArrayToArray(Vector2ui[] vectors)
    {
        uint[] result = new uint[2 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[2 * i] = vectors[i].Item1;
            result[(2 * i) + 1] = vectors[i].Item2;
        }

        return result;
    }

    public static uint[] Vector3uiArrayToArray(Vector3ui[] vectors)
    {
        uint[] result = new uint[3 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[3 * i] = vectors[i].Item1;
            result[(3 * i) + 1] = vectors[i].Item2;
            result[(3 * i) + 2] = vectors[i].Item3;
        }

        return result;
    }

    public static uint[] Vector4uiArrayToArray(Vector4ui[] vectors)
    {
        uint[] result = new uint[4 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[4 * i] = vectors[i].Item1;
            result[(4 * i) + 1] = vectors[i].Item2;
            result[(4 * i) + 2] = vectors[i].Item3;
            result[(4 * i) + 3] = vectors[i].Item4;
        }

        return result;
    }

    public static float[] Vector2ArrayToArray(Vector2[] vectors)
    {
        float[] result = new float[2 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[2 * i] = vectors[i].X;
            result[(2 * i) + 1] = vectors[i].Y;
        }

        return result;
    }

    public static float[] Vector3ArrayToArray(Vector3[] vectors)
    {
        float[] result = new float[3 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[3 * i] = vectors[i].X;
            result[(3 * i) + 1] = vectors[i].Y;
            result[(3 * i) + 2] = vectors[i].Z;
        }

        return result;
    }

    public static float[] Vector4ArrayToArray(Vector4[] vectors)
    {
        float[] result = new float[4 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[4 * i] = vectors[i].X;
            result[(4 * i) + 1] = vectors[i].Y;
            result[(4 * i) + 2] = vectors[i].Z;
            result[(4 * i) + 3] = vectors[i].W;
        }

        return result;
    }

    public static double[] Vector2dArrayToArray(Vector2d[] vectors)
    {
        double[] result = new double[2 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[2 * i] = vectors[i].X;
            result[(2 * i) + 1] = vectors[i].Y;
        }

        return result;
    }

    public static double[] Vector3dArrayToArray(Vector3d[] vectors)
    {
        double[] result = new double[3 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[3 * i] = vectors[i].X;
            result[(3 * i) + 1] = vectors[i].Y;
            result[(3 * i) + 2] = vectors[i].Z;
        }

        return result;
    }

    public static double[] Vector4dArrayToArray(Vector4d[] vectors)
    {
        double[] result = new double[4 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[4 * i] = vectors[i].X;
            result[(4 * i) + 1] = vectors[i].Y;
            result[(4 * i) + 2] = vectors[i].Z;
            result[(4 * i) + 3] = vectors[i].W;
        }

        return result;
    }

    public static int[] Vector2bArrayToArray(Vector2b[] vectors)
    {
        int[] result = new int[2 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[2 * i] = vectors[i].Item1 ? 1 : 0;
            result[(2 * i) + 1] = vectors[i].Item2 ? 1 : 0;
        }

        return result;
    }

    public static int[] Vector3bArrayToArray(Vector3b[] vectors)
    {
        int[] result = new int[3 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[3 * i] = vectors[i].Item1 ? 1 : 0;
            result[(3 * i) + 1] = vectors[i].Item2 ? 1 : 0;
            result[(3 * i) + 2] = vectors[i].Item3 ? 1 : 0;
        }

        return result;
    }

    public static int[] Vector4bArrayToArray(Vector4b[] vectors)
    {
        int[] result = new int[4 * vectors.Length];

        for (int i = 0; i < vectors.Length; i++)
        {
            result[4 * i] = vectors[i].Item1 ? 1 : 0;
            result[(4 * i) + 1] = vectors[i].Item2 ? 1 : 0;
            result[(4 * i) + 2] = vectors[i].Item3 ? 1 : 0;
            result[(4 * i) + 3] = vectors[i].Item4 ? 1 : 0;
        }

        return result;
    }

    public static float[] Matrix2ArrayToArray(Matrix2[] matrices)
    {
        float[] result = new float[4 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[4 * i] = matrices[0].M11;
            result[(4 * i) + 1] = matrices[0].M12;
            result[(4 * i) + 2] = matrices[0].M21;
            result[(4 * i) + 3] = matrices[0].M22;
        }

        return result;
    }

    public static float[] Matrix2x3ArrayToArray(Matrix2x3[] matrices)
    {
        float[] result = new float[6 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[6 * i] = matrices[0].M11;
            result[(6 * i) + 1] = matrices[0].M12;
            result[(6 * i) + 2] = matrices[0].M13;
            result[(6 * i) + 3] = matrices[0].M21;
            result[(6 * i) + 4] = matrices[0].M22;
            result[(6 * i) + 5] = matrices[0].M23;
        }

        return result;
    }

    public static float[] Matrix2x4ArrayToArray(Matrix2x4[] matrices)
    {
        float[] result = new float[8 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[8 * i] = matrices[0].M11;
            result[(8 * i) + 1] = matrices[0].M12;
            result[(8 * i) + 2] = matrices[0].M13;
            result[(8 * i) + 3] = matrices[0].M24;
            result[(8 * i) + 4] = matrices[0].M21;
            result[(8 * i) + 5] = matrices[0].M22;
            result[(8 * i) + 6] = matrices[0].M23;
            result[(8 * i) + 7] = matrices[0].M22;
        }

        return result;
    }

    public static float[] Matrix3ArrayToArray(Matrix3[] matrices)
    {
        float[] result = new float[9 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[9 * i] = matrices[0].M11;
            result[(9 * i) + 1] = matrices[0].M12;
            result[(9 * i) + 2] = matrices[0].M13;
            result[(9 * i) + 3] = matrices[0].M21;
            result[(9 * i) + 4] = matrices[0].M22;
            result[(9 * i) + 5] = matrices[0].M23;
            result[(9 * i) + 6] = matrices[0].M31;
            result[(9 * i) + 7] = matrices[0].M32;
            result[(9 * i) + 8] = matrices[0].M33;
        }

        return result;
    }

    public static float[] Matrix3x2ArrayToArray(Matrix3x2[] matrices)
    {
        float[] result = new float[6 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[6 * i] = matrices[0].M11;
            result[(6 * i) + 1] = matrices[0].M12;
            result[(6 * i) + 2] = matrices[0].M21;
            result[(6 * i) + 3] = matrices[0].M22;
            result[(6 * i) + 4] = matrices[0].M31;
            result[(6 * i) + 5] = matrices[0].M32;
        }

        return result;
    }

    public static float[] Matrix3x4ArrayToArray(Matrix3x4[] matrices)
    {
        float[] result = new float[12 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[12 * i] = matrices[0].M11;
            result[(12 * i) + 1] = matrices[0].M12;
            result[(12 * i) + 2] = matrices[0].M13;
            result[(12 * i) + 3] = matrices[0].M14;
            result[(12 * i) + 4] = matrices[0].M21;
            result[(12 * i) + 5] = matrices[0].M22;
            result[(12 * i) + 6] = matrices[0].M23;
            result[(12 * i) + 7] = matrices[0].M24;
            result[(12 * i) + 8] = matrices[0].M31;
            result[(12 * i) + 9] = matrices[0].M32;
            result[(12 * i) + 10] = matrices[0].M33;
            result[(12 * i) + 11] = matrices[0].M34;
        }

        return result;
    }

    public static float[] Matrix4ArrayToArray(Matrix4[] matrices)
    {
        float[] result = new float[16 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[16 * i] = matrices[0].M11;
            result[(16 * i) + 1] = matrices[0].M12;
            result[(16 * i) + 2] = matrices[0].M13;
            result[(16 * i) + 3] = matrices[0].M14;
            result[(16 * i) + 4] = matrices[0].M21;
            result[(16 * i) + 5] = matrices[0].M22;
            result[(16 * i) + 6] = matrices[0].M23;
            result[(16 * i) + 7] = matrices[0].M24;
            result[(16 * i) + 8] = matrices[0].M31;
            result[(16 * i) + 9] = matrices[0].M32;
            result[(16 * i) + 10] = matrices[0].M33;
            result[(16 * i) + 11] = matrices[0].M34;
            result[(16 * i) + 12] = matrices[0].M41;
            result[(16 * i) + 13] = matrices[0].M42;
            result[(16 * i) + 14] = matrices[0].M43;
            result[(16 * i) + 15] = matrices[0].M44;
        }

        return result;
    }

    public static float[] Matrix4x2ArrayToArray(Matrix4x2[] matrices)
    {
        float[] result = new float[8 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[8 * i] = matrices[0].M11;
            result[(8 * i) + 1] = matrices[0].M12;
            result[(8 * i) + 2] = matrices[0].M21;
            result[(8 * i) + 3] = matrices[0].M22;
            result[(8 * i) + 4] = matrices[0].M31;
            result[(8 * i) + 5] = matrices[0].M32;
            result[(8 * i) + 6] = matrices[0].M41;
            result[(8 * i) + 7] = matrices[0].M42;
        }

        return result;
    }

    public static float[] Matrix4x3ArrayToArray(Matrix4x3[] matrices)
    {
        float[] result = new float[12 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[12 * i] = matrices[0].M11;
            result[(12 * i) + 1] = matrices[0].M12;
            result[(12 * i) + 2] = matrices[0].M13;
            result[(12 * i) + 3] = matrices[0].M21;
            result[(12 * i) + 4] = matrices[0].M22;
            result[(12 * i) + 5] = matrices[0].M23;
            result[(12 * i) + 6] = matrices[0].M31;
            result[(12 * i) + 7] = matrices[0].M32;
            result[(12 * i) + 8] = matrices[0].M33;
            result[(12 * i) + 9] = matrices[0].M41;
            result[(12 * i) + 10] = matrices[0].M42;
            result[(12 * i) + 11] = matrices[0].M43;
        }

        return result;
    }

    public static double[] Matrix2dArrayToArray(Matrix2d[] matrices)
    {
        double[] result = new double[4 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[4 * i] = matrices[0].M11;
            result[(4 * i) + 1] = matrices[0].M12;
            result[(4 * i) + 2] = matrices[0].M21;
            result[(4 * i) + 3] = matrices[0].M22;
        }

        return result;
    }

    public static double[] Matrix2x3dArrayToArray(Matrix2x3d[] matrices)
    {
        double[] result = new double[6 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[6 * i] = matrices[0].M11;
            result[(6 * i) + 1] = matrices[0].M12;
            result[(6 * i) + 2] = matrices[0].M13;
            result[(6 * i) + 3] = matrices[0].M21;
            result[(6 * i) + 4] = matrices[0].M22;
            result[(6 * i) + 5] = matrices[0].M23;
        }

        return result;
    }

    public static double[] Matrix2x4dArrayToArray(Matrix2x4d[] matrices)
    {
        double[] result = new double[8 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[8 * i] = matrices[0].M11;
            result[(8 * i) + 1] = matrices[0].M12;
            result[(8 * i) + 2] = matrices[0].M13;
            result[(8 * i) + 3] = matrices[0].M24;
            result[(8 * i) + 4] = matrices[0].M21;
            result[(8 * i) + 5] = matrices[0].M22;
            result[(8 * i) + 6] = matrices[0].M23;
            result[(8 * i) + 7] = matrices[0].M22;
        }

        return result;
    }

    public static double[] Matrix3dArrayToArray(Matrix3d[] matrices)
    {
        double[] result = new double[9 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[9 * i] = matrices[0].M11;
            result[(9 * i) + 1] = matrices[0].M12;
            result[(9 * i) + 2] = matrices[0].M13;
            result[(9 * i) + 3] = matrices[0].M21;
            result[(9 * i) + 4] = matrices[0].M22;
            result[(9 * i) + 5] = matrices[0].M23;
            result[(9 * i) + 6] = matrices[0].M31;
            result[(9 * i) + 7] = matrices[0].M32;
            result[(9 * i) + 8] = matrices[0].M33;
        }

        return result;
    }

    public static double[] Matrix3x2dArrayToArray(Matrix3x2d[] matrices)
    {
        double[] result = new double[6 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[6 * i] = matrices[0].M11;
            result[(6 * i) + 1] = matrices[0].M12;
            result[(6 * i) + 2] = matrices[0].M21;
            result[(6 * i) + 3] = matrices[0].M22;
            result[(6 * i) + 4] = matrices[0].M31;
            result[(6 * i) + 5] = matrices[0].M32;
        }

        return result;
    }

    public static double[] Matrix3x4dArrayToArray(Matrix3x4d[] matrices)
    {
        double[] result = new double[12 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[12 * i] = matrices[0].M11;
            result[(12 * i) + 1] = matrices[0].M12;
            result[(12 * i) + 2] = matrices[0].M13;
            result[(12 * i) + 3] = matrices[0].M14;
            result[(12 * i) + 4] = matrices[0].M21;
            result[(12 * i) + 5] = matrices[0].M22;
            result[(12 * i) + 6] = matrices[0].M23;
            result[(12 * i) + 7] = matrices[0].M24;
            result[(12 * i) + 8] = matrices[0].M31;
            result[(12 * i) + 9] = matrices[0].M32;
            result[(12 * i) + 10] = matrices[0].M33;
            result[(12 * i) + 11] = matrices[0].M34;
        }

        return result;
    }

    public static double[] Matrix4dArrayToArray(Matrix4d[] matrices)
    {
        double[] result = new double[16 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[16 * i] = matrices[0].M11;
            result[(16 * i) + 1] = matrices[0].M12;
            result[(16 * i) + 2] = matrices[0].M13;
            result[(16 * i) + 3] = matrices[0].M14;
            result[(16 * i) + 4] = matrices[0].M21;
            result[(16 * i) + 5] = matrices[0].M22;
            result[(16 * i) + 6] = matrices[0].M23;
            result[(16 * i) + 7] = matrices[0].M24;
            result[(16 * i) + 8] = matrices[0].M31;
            result[(16 * i) + 9] = matrices[0].M32;
            result[(16 * i) + 10] = matrices[0].M33;
            result[(16 * i) + 11] = matrices[0].M34;
            result[(16 * i) + 12] = matrices[0].M41;
            result[(16 * i) + 13] = matrices[0].M42;
            result[(16 * i) + 14] = matrices[0].M43;
            result[(16 * i) + 15] = matrices[0].M44;
        }

        return result;
    }

    public static double[] Matrix4x2dArrayToArray(Matrix4x2d[] matrices)
    {
        double[] result = new double[8 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[8 * i] = matrices[0].M11;
            result[(8 * i) + 1] = matrices[0].M12;
            result[(8 * i) + 2] = matrices[0].M21;
            result[(8 * i) + 3] = matrices[0].M22;
            result[(8 * i) + 4] = matrices[0].M31;
            result[(8 * i) + 5] = matrices[0].M32;
            result[(8 * i) + 6] = matrices[0].M41;
            result[(8 * i) + 7] = matrices[0].M42;
        }

        return result;
    }

    public static double[] Matrix4x3dArrayToArray(Matrix4x3d[] matrices)
    {
        double[] result = new double[12 * matrices.Length];

        for (int i = 0; i < matrices.Length; i++)
        {
            result[12 * i] = matrices[0].M11;
            result[(12 * i) + 1] = matrices[0].M12;
            result[(12 * i) + 2] = matrices[0].M13;
            result[(12 * i) + 3] = matrices[0].M21;
            result[(12 * i) + 4] = matrices[0].M22;
            result[(12 * i) + 5] = matrices[0].M23;
            result[(12 * i) + 6] = matrices[0].M31;
            result[(12 * i) + 7] = matrices[0].M32;
            result[(12 * i) + 8] = matrices[0].M33;
            result[(12 * i) + 9] = matrices[0].M41;
            result[(12 * i) + 10] = matrices[0].M42;
            result[(12 * i) + 11] = matrices[0].M43;
        }

        return result;
    }
}
