using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL.Helper;

public static class TexImageHelper
{
    public static TextureTarget Target { get; set; }

    public static int MipmapLevel { get; set; }

    public static PixelInternalFormat PixelInternalFormat { get; set; }

    public static PixelFormat PixelFormat { get; set; }

    public static PixelType PixelType { get; set; }

    private static bool ValidatePixelType<T>()
        where T : struct
    {
        return new T() switch
        {
            sbyte => PixelType == PixelType.Byte,
            float => PixelType == PixelType.Float,
            Half => PixelType == PixelType.HalfFloat,
            int => PixelType == PixelType.Int,
            short => PixelType == PixelType.Short,
            byte => PixelType == PixelType.UnsignedByte,
            uint => PixelType == PixelType.UnsignedInt,
            ushort => PixelType == PixelType.UnsignedShort,
            _ => false
        };
    }

    private static bool ValidateTextureTarget(int[] dimensions)
    {
        return dimensions switch
        {
            [> 0] => Target == TextureTarget.Texture1D,
            [> 0, > 0] => Target == TextureTarget.Texture2D,
            [> 0, > 0, > 0] => Target == TextureTarget.Texture3D,
            _ => false
        };
    }

    public static void TextureImage<T>(int[] dimensions, T[] data)
        where T : struct
    {
        if (!ValidatePixelType<T>())
        {
            throw new InvalidOperationException(Constants.ERROR_INVALID_PIXEL_TYPE);
        }

        if (!ValidateTextureTarget(dimensions))
        {
            throw new InvalidOperationException(Constants.ERROR_INVALID_DIMENSIONS);
        }

        if (dimensions.Aggregate((x, y) => x * y) != data.Length)
        {
            throw new InvalidOperationException(Constants.ERROR_INVALID_DATA_LENGTH);
        }

        switch (dimensions.Length)
        {
            case 1:
                TexImage1D(dimensions[0], data);
                break;

            case 2:
                TexImage2D(dimensions[0], dimensions[1], data);
                break;

            case 3:
                TexImage3D(dimensions[0], dimensions[1], dimensions[2], data);
                break;
        }
    }

    private static void TexImage1D<T>(int width, T[] data)
        where T : struct
    {
        GL.TexImage1D(Target, MipmapLevel, PixelInternalFormat, width, 0, PixelFormat, PixelType, data);
    }

    private static void TexImage2D<T>(int width, int height, T[] data)
        where T : struct
    {
        GL.TexImage2D(Target, MipmapLevel, PixelInternalFormat, width, height, 0, PixelFormat, PixelType, data);
    }

    private static void TexImage3D<T>(int width, int height, int depth, T[] data)
        where T : struct
    {
        GL.TexImage3D(Target, MipmapLevel, PixelInternalFormat, width, height, depth, 0, PixelFormat, PixelType, data);
    }
}
