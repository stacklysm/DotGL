namespace Rendering.Shader;

public record struct GlslVariable(GlslDataType DataType, string Name)
{
    private object Value = new();

    public void SetValue(object value)
    {
        Value = value;
    }

    public T GetValue<T>()
       where T : struct
    {
        return (T)Value;
    }
}
