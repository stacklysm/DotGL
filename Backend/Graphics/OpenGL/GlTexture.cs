using Backend.Graphics.OpenGL.Helper;

using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

public class GlTexture : IBindableGlObject
{
    public TextureTarget Target { get; }

    public GenerateMipmapTarget? MipmapTarget { get; }

    public int Id { get; private set; }
    
    public bool Valid { get; }

    public GlTexture(TextureTarget target, bool generateMipmaps)
    {
        Target = target;
        MipmapTarget = generateMipmaps ? target switch
        {
            TextureTarget.Texture1D => GenerateMipmapTarget.Texture1D,
            TextureTarget.Texture1DArray => GenerateMipmapTarget.Texture1DArray,
            TextureTarget.Texture2D => GenerateMipmapTarget.Texture2D,
            TextureTarget.Texture2DArray => GenerateMipmapTarget.Texture2DArray,
            TextureTarget.Texture2DMultisample => GenerateMipmapTarget.Texture2DMultisample,
            TextureTarget.Texture2DMultisampleArray => GenerateMipmapTarget.Texture2DMultisampleArray,
            TextureTarget.Texture3D => GenerateMipmapTarget.Texture3D,
            TextureTarget.TextureCubeMap => GenerateMipmapTarget.TextureCubeMap,
            TextureTarget.TextureCubeMapArray => GenerateMipmapTarget.TextureCubeMapArray,
            _ => throw new InvalidOperationException(Constants.ERROR_INVALID_MIPMAP_TYPE)
        } : null;
    }

    public void Create()
    {
        Id = GL.GenTexture();
    }

    public void Delete()
    {
        GL.DeleteTexture(Id);
        Id = 0;
    }

    public void Bind()
    {
        GL.BindTexture(Target, Id);
    }

    public static void Unbind(TextureTarget target)
    {
        GL.BindTexture(target, 0);
    }
    
    public static void ActiveUnit(TextureUnit unit)
    {
        GL.ActiveTexture(unit);
    }

    public void TextureParameter<T>(TextureParameterName parameter, T value)
    {
        switch (value)
        {
            case int i:
                GL.TexParameter(Target, parameter, i);
                break;

            case int[] iv:
                GL.TexParameter(Target, parameter, iv);
                break;

            case float f:
                GL.TexParameter(Target, parameter, f);
                break;

            case float[] fv:
                GL.TexParameter(Target, parameter, fv);
                break;

            case TextureWrapMode wrap:
                GL.TexParameter(Target, parameter, (int)wrap);
                break;

            case TextureMagFilter mag:
                GL.TexParameter(Target, parameter, (int)mag);
                break;

            case TextureMinFilter min:
                GL.TexParameter(Target, parameter, (int)min);
                break;

            default:
                throw new OpenGLException(Constants.ERROR_TEXTURE_PARAMETER_NOT_SUPORTED);
        }
    }

    public void GenerateMipmaps()
    {
        if (MipmapTarget is null)
        {
            throw new InvalidOperationException(Constants.ERROR_INVALID_MIPMAP_TYPE);
        }

        GL.GenerateMipmap((GenerateMipmapTarget)MipmapTarget);
    }

    public void TextureImage<T>(int mipmapLevel, PixelInternalFormat pixelInternalFormat, PixelFormat pixelFormat, PixelType pixelType, int[] dimensions, T[] data)
        where T : struct
    {
        TexImageHelper.Target = Target;
        TexImageHelper.MipmapLevel = mipmapLevel;
        TexImageHelper.PixelInternalFormat = pixelInternalFormat;
        TexImageHelper.PixelFormat = pixelFormat;
        TexImageHelper.PixelType = pixelType;

        TexImageHelper.TextureImage(dimensions, data);
    }
}
