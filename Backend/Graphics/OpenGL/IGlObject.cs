namespace Backend.Graphics.OpenGL;

public interface IGlObject
{
    int Id { get; }
    void Create();
    void Delete();
}
