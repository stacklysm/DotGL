using OpenTK.Graphics.OpenGL4;

namespace Backend.Graphics.OpenGL;

public class GlTexture2D : IBindableGlObject
{
    private ITextureSource TextureSource { get; set; }
    private TextureUnit Unit { get; set; }
    private int MipmapLevel { get; set; }

    public int Id { get; private set; }
    // FIXME: Add better validation for this type
    public bool Valid => TextureSource != null && Id != 0;

    public GlTexture2D(ITextureSource textureSource, TextureUnit unit, int mipmapLevel = 0)
    {
        TextureSource = textureSource;
        Unit = unit;
        MipmapLevel = mipmapLevel;
    }

    public void Create()
    {
        Id = GL.GenTexture();
        TextureSource.Load();
    }

    public void Delete()
    {
        GL.DeleteTexture(Id);
        Id = 0;
    }

    public void Bind()
    {
        GL.BindTexture(TextureTarget.Texture2D, Id);
    }

    public void Unbind()
    {
        GL.BindTexture(TextureTarget.Texture2D, 0);
    }

    public void TextureParameter<TParam>(TextureParameterName parameter, TParam value)
    {
        switch (value)
        {
            case int i:
                GL.TexParameter(TextureTarget.Texture2D, parameter, i);
                break;

            case int[] iv:
                GL.TexParameter(TextureTarget.Texture2D, parameter, iv);
                break;

            case float f:
                GL.TexParameter(TextureTarget.Texture2D, parameter, f);
                break;

            case float[] fv:
                GL.TexParameter(TextureTarget.Texture2D, parameter, fv);
                break;

            case TextureWrapMode wrap:
                GL.TexParameter(TextureTarget.Texture2D, parameter, (int)wrap);
                break;

            case TextureMagFilter mag:
                GL.TexParameter(TextureTarget.Texture2D, parameter, (int)mag);
                break;

            case TextureMinFilter min:
                GL.TexParameter(TextureTarget.Texture2D, parameter, (int)min);
                break;

            default:
                throw new OpenGLException(Constants.ERROR_TEXTURE_PARAMETER_NOT_SUPORTED);
        }
    }

    public void GenerateMipmaps()
    {
        GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);
    }

    public void TextureStorage(int textureLevels)
    {
        GL.TexStorage2D(TextureTarget2d.Texture2D, textureLevels, SizedInternalFormat.Rgba8ui, TextureSource.Dimensions[0], TextureSource.Dimensions[1]);
    }

    public void TextureImage()
    {
        GL.TexImage2D(TextureTarget.Texture2D, MipmapLevel, PixelInternalFormat.Rgba, TextureSource.Dimensions[0], TextureSource.Dimensions[1], 0, PixelFormat.Rgba, PixelType.UnsignedByte, TextureSource.GetData());
    }

    public void ActivateTexture()
    {
        GL.ActiveTexture(Unit);
    }
}
