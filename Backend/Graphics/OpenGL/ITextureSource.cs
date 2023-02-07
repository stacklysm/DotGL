namespace Backend.Graphics.OpenGL;

public interface ITextureSource
{
    int[] Dimensions { get; }
    int Channels { get; }

    void Load();
    byte[] GetData();
}
