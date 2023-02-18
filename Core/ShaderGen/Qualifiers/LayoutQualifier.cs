namespace Core.ShaderGen.Qualifiers;

// NOTE: Add a "category" value to the dictionary in order to implement mutual exclusivity within qualifiers (think of RANK() OVER() in SQL)
// TODO: Add layout qualifiers for image types
public class LayoutQualifier : IQualifier
{
    private Dictionary<string, int?> Value { get; } = new();

    private string QualifierIdList => Value
        .OrderBy(x => (x.Value, x.Key))
        .Select(y => $"{y.Key}{(y.Value is not null ? $" = {y.Key}" : "")}")
        .Aggregate((x, y) => $"{x}, {y}");

    public LayoutQualifier Shared()
    {
        Value.Add("shared", null);
        return this;
    }

    public LayoutQualifier Packed()
    {
        Value.Add("packed", null);
        return this;
    }

    public LayoutQualifier Std140()
    {
        Value.Add("std140", null);
        return this;
    }

    public LayoutQualifier Std430()
    {
        Value.Add("std430", null);
        return this;
    }

    public LayoutQualifier RowMajor()
    {
        Value.Add("row_major", null);
        return this;
    }

    public LayoutQualifier ColumnMajor()
    {
        Value.Add("column_major", null);
        return this;
    }

    public LayoutQualifier Binding(int bindingIndex)
    {
        Value.Add("binding", bindingIndex);
        return this;
    }

    public LayoutQualifier Offset(int offset)
    {
        Value.Add("offset", offset);
        return this;
    }

    public LayoutQualifier Align(int alignment)
    {
        Value.Add("align", alignment);
        return this;
    }

    public LayoutQualifier Set(int descriptorSet)
    {
        Value.Add("set", descriptorSet);
        return this;
    }

    public LayoutQualifier PushConstant()
    {
        Value.Add("push_constant", null);
        return this;
    }

    public LayoutQualifier InputAttachmentIndex(int attachmentIndex)
    {
        Value.Add("input_attachment_index", attachmentIndex);
        return this;
    }

    public LayoutQualifier Location(int location)
    {
        Value.Add("location", location);
        return this;
    }

    public LayoutQualifier Component(int component)
    {
        Value.Add("component", component);
        return this;
    }

    public LayoutQualifier Index(int index)
    {
        Value.Add("index", index);
        return this;
    }

    public LayoutQualifier Triangles()
    {
        Value.Add("triangles", null);
        return this;
    }

    public LayoutQualifier Quads()
    {
        Value.Add("quads", null);
        return this;
    }

    public LayoutQualifier Isolines()
    {
        Value.Add("isolines", null);
        return this;
    }

    public LayoutQualifier EqualSpacing()
    {
        Value.Add("equal_spacing", null);
        return this;
    }

    public LayoutQualifier FractionalEvenSpacing()
    {
        Value.Add("fractional_even_spacing", null);
        return this;
    }

    public LayoutQualifier FractionalOddSpacing()
    {
        Value.Add("fractional_odd_spacing", null);
        return this;
    }

    public LayoutQualifier Cw()
    {
        Value.Add("cw", null);
        return this;
    }

    public LayoutQualifier Ccw()
    {
        Value.Add("ccw", null);
        return this;
    }

    public LayoutQualifier PointMode()
    {
        Value.Add("point_mode", null);
        return this;
    }

    public LayoutQualifier Points()
    {
        Value.Add("points", null);
        return this;
    }

    public LayoutQualifier Lines()
    {
        Value.Add("lines", null);
        return this;
    }

    public LayoutQualifier LinesAdjacency()
    {
        Value.Add("lines_adjacency", null);
        return this;
    }

    public LayoutQualifier TrianglesAdjacency()
    {
        Value.Add("triangles_adjacency", null);
        return this;
    }

    public LayoutQualifier Invocations(int invocations)
    {
        Value.Add("invocations", invocations);
        return this;
    }

    public LayoutQualifier OriginUpperLeft()
    {
        Value.Add("origin_upper_left", null);
        return this;
    }

    public LayoutQualifier PixelCenterInteger()
    {
        Value.Add("pixel_center_integer", null);
        return this;
    }

    public LayoutQualifier EarlyFragmentTests()
    {
        Value.Add("early_fragment_tests", null);
        return this;
    }

    public LayoutQualifier LocalSizeXId(int sizeXId)
    {
        Value.Add("local_size_x_id", sizeXId);
        return this;
    }

    public LayoutQualifier LocalSizeYId(int sizeYId)
    {
        Value.Add("local_size_y_id", sizeYId);
        return this;
    }

    public LayoutQualifier LocalSizeZId(int sizeZId)
    {
        Value.Add("local_size_z_id", sizeZId);
        return this;
    }

    public LayoutQualifier XfbBuffer(int buffer)
    {
        Value.Add("xfb_buffer", buffer);
        return this;
    }

    public LayoutQualifier XfbStride(int stride)
    {
        Value.Add("xfb_stride", stride);
        return this;
    }

    public LayoutQualifier XfbOffset(int offset)
    {
        Value.Add("xfb_offset", offset);
        return this;
    }

    public LayoutQualifier Vertices(int vertices)
    {
        Value.Add("vertices", vertices);
        return this;
    }

    public LayoutQualifier LineStrip()
    {
        Value.Add("line_strip", null);
        return this;
    }

    public LayoutQualifier TriangleStrip()
    {
        Value.Add("triangle_strip", null);
        return this;
    }

    public LayoutQualifier MaxVertices(int maxVertices)
    {
        Value.Add("max_vertices", maxVertices);
        return this;
    }

    public LayoutQualifier Stream(int stream)
    {
        Value.Add("stream", stream);
        return this;
    }

    public LayoutQualifier DepthAny()
    {
        Value.Add("depth_any", null);
        return this;
    }

    public LayoutQualifier DepthGreater()
    {
        Value.Add("depth_greater", null);
        return this;
    }

    public LayoutQualifier DepthLess()
    {
        Value.Add("depth_less", null);
        return this;
    }

    public LayoutQualifier DepthUnchanged()
    {
        Value.Add("depth_unchanged", null);
        return this;
    }

    public LayoutQualifier ConstantId(int id)
    {
        Value.Add("constant_id", id);
        return this;
    }

    public LayoutQualifier ImageType(LayoutQualifierImageType imageType)
    {
        string qualifier = imageType switch
        {
            LayoutQualifierImageType.Rgba32f => "rgba32f",
            LayoutQualifierImageType.Rgba16f => "rgba16f",
            LayoutQualifierImageType.Rg32f => "rg32f",
            LayoutQualifierImageType.Rg16f => "rg16f",
            LayoutQualifierImageType.R11fg11fb10f => "r11f_g11f_b10f",
            LayoutQualifierImageType.R32f => "r32f",
            LayoutQualifierImageType.R16f => "r16f",
            LayoutQualifierImageType.Rgba16 => "rgba16",
            LayoutQualifierImageType.Rgb10a2 => "rgb10_a2",
            LayoutQualifierImageType.Rgba8 => "rgba8",
            LayoutQualifierImageType.Rg16 => "rg16",
            LayoutQualifierImageType.Rg8 => "rg8",
            LayoutQualifierImageType.R16 => "r16",
            LayoutQualifierImageType.R8 => "r8",
            LayoutQualifierImageType.Rgba16snorm => "rgba16_snorm",
            LayoutQualifierImageType.Rgba8snorm => "rgba8_snorm",
            LayoutQualifierImageType.Rg16snorm => "rg16_snorm",
            LayoutQualifierImageType.Rg8snorm => "rg8_snorm",
            LayoutQualifierImageType.R16snorm => "r16_snorm",
            LayoutQualifierImageType.R8snorm => "r8_snorm",
            LayoutQualifierImageType.Rgba32i => "rgba32i",
            LayoutQualifierImageType.Rgba16i => "rgba16i",
            LayoutQualifierImageType.Rgba8i => "rgba8i",
            LayoutQualifierImageType.Rg32i => "rg32i",
            LayoutQualifierImageType.Rg16i => "rg16i",
            LayoutQualifierImageType.Rg8i => "rg8i",
            LayoutQualifierImageType.R32i => "r32i",
            LayoutQualifierImageType.R16i => "r16i",
            LayoutQualifierImageType.R8i => "r8i",
            LayoutQualifierImageType.Rgba32ui => "rgba32ui",
            LayoutQualifierImageType.Rgba16ui => "rgba16ui",
            LayoutQualifierImageType.Rgb10a2ui => "rgb10_a2ui",
            LayoutQualifierImageType.Rgba8ui => "rgba8ui",
            LayoutQualifierImageType.Rg32ui => "rg32ui",
            LayoutQualifierImageType.Rg16ui => "rg16ui",
            LayoutQualifierImageType.Rg8ui => "rg8ui",
            LayoutQualifierImageType.R32ui => "r32ui",
            LayoutQualifierImageType.R16ui => "r16ui",
            LayoutQualifierImageType.R8ui => "r8ui",
            _ => throw new NotImplementedException()
        };

        Value.Add(qualifier, null);
        return this;
    }

    public string GetQualifier() => $"layout({QualifierIdList})";
}