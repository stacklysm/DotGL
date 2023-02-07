using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Backend.Graphics.OpenGL;

public class PngImageSource : ITextureSource
{
    private string ImagePath { get; set; }
    private Image<Rgba32>? Data { get; set; }
    private readonly int[] _Dimensions = new int[2];

    public int[] Dimensions => _Dimensions;
    public int Width { get; private set; }
    public int Height { get; private set; }
    public int Channels => 4;

    public PngImageSource(string imagePath)
    {
        ImagePath = imagePath;
    }

    public void Load()
    {
        Data = Image.Load<Rgba32>(ImagePath);

        _Dimensions[0] = Data.Width;
        _Dimensions[1] = Data.Height;
        Width = Data.Width;
        Height = Data.Height;
    }

    public byte[] GetData()
    {
        byte[] data = new byte[Width * Height * Channels];

        if (Data is not null)
        {
            uint counter = 0;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    data[counter++] = Data[i, j].R;
                    data[counter++] = Data[i, j].G;
                    data[counter++] = Data[i, j].B;
                    data[counter++] = Data[i, j].A;
                }
            }
        }

        return data;
    }
}
