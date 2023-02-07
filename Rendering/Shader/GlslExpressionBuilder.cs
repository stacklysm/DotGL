global using Vector2ui = System.ValueTuple<uint, uint>;
global using Vector3ui = System.ValueTuple<uint, uint, uint>;
global using Vector4ui = System.ValueTuple<uint, uint, uint, uint>;
global using Vector2b = System.ValueTuple<bool, bool>;
global using Vector3b = System.ValueTuple<bool, bool, bool>;
global using Vector4b = System.ValueTuple<bool, bool, bool, bool>;

using OpenTK.Mathematics;
using System.Text;

namespace Rendering.Shader;

public static class GlslExpressionBuilder
{
    // TODO: Add sampler types
    public static string GetTypeName(GlslDataType dataType)
    {
        return dataType switch
        {
            GlslDataType.Int => "int",
            GlslDataType.IntVector2 => "ivec2",
            GlslDataType.IntVector3 => "ivec3",
            GlslDataType.IntVector4 => "ivec4",
            GlslDataType.UInt => "uint",
            GlslDataType.UIntVector2 => "uvec2",
            GlslDataType.UIntVector3 => "uvec3",
            GlslDataType.UIntVector4 => "uvec4",
            GlslDataType.Float => "float",
            GlslDataType.FloatVector2 => "vec2",
            GlslDataType.FloatVector3 => "vec3",
            GlslDataType.FloatVector4 => "vec4",
            GlslDataType.Double => "double",
            GlslDataType.DoubleVector2 => "dvec2",
            GlslDataType.DoubleVector3 => "dvec3",
            GlslDataType.DoubleVector4 => "dvec4",
            GlslDataType.Bool => "bool",
            GlslDataType.BoolVector2 => "bvec2",
            GlslDataType.BoolVector3 => "bvec3",
            GlslDataType.BoolVector4 => "bvec4",
            GlslDataType.Matrix2 => "mat2",
            GlslDataType.Matrix2x3 => "mat2x3",
            GlslDataType.Matrix2x4 => "mat2x4",
            GlslDataType.Matrix3 => "mat3",
            GlslDataType.Matrix3x2 => "mat3x2",
            GlslDataType.Matrix3x4 => "mat3x4",
            GlslDataType.Matrix4 => "mat4",
            GlslDataType.Matrix4x2 => "mat4x2",
            GlslDataType.Matrix4x3 => "mat4x3",
            GlslDataType.DoubleMatrix2 => "dmat2",
            GlslDataType.DoubleMatrix2x3 => "dmat2x3",
            GlslDataType.DoubleMatrix2x4 => "dmat2x4",
            GlslDataType.DoubleMatrix3 => "dmat3",
            GlslDataType.DoubleMatrix3x2 => "dmat3x2",
            GlslDataType.DoubleMatrix3x4 => "dmat3x4",
            GlslDataType.DoubleMatrix4 => "dmat4",
            GlslDataType.DoubleMatrix4x2 => "dmat4x2",
            GlslDataType.DoubleMatrix4x3 => "dmat4x3",
            GlslDataType.Sampler1d => "sampler1D",
            GlslDataType.Sampler2d => "sampler2D",
            GlslDataType.Sampler3d => "sampler3D",
            GlslDataType.SamplerCube => "samplerCube",
            GlslDataType.Sampler2DRect => "sampler2DRect",
            GlslDataType.Sampler1DArray => "sampler1DArray",
            GlslDataType.Sampler2DArray => "sampler2DArray",
            GlslDataType.SamplerCubeArray => "samplerCubeArray",
            GlslDataType.SamplerBuffer => "samplerBuffer",
            GlslDataType.Sampler2DMS => "sampler2DMS",
            GlslDataType.Sampler2DMSArray => "sampler2DMSArray",
            GlslDataType.IntSampler1d => "isampler1D",
            GlslDataType.IntSampler2d => "isampler2D",
            GlslDataType.IntSampler3d => "isampler3D",
            GlslDataType.IntSamplerCube => "isamplerCube",
            GlslDataType.IntSampler2DRect => "isampler2DRect",
            GlslDataType.IntSampler1DArray => "isampler1DArray",
            GlslDataType.IntSampler2DArray => "isampler2DArray",
            GlslDataType.IntSamplerCubeArray => "isamplerCubeArray",
            GlslDataType.IntSamplerBuffer => "isamplerBuffer",
            GlslDataType.IntSampler2DMS => "isampler2DMS",
            GlslDataType.IntSampler2DMSArray => "isampler2DMSArray",
            GlslDataType.UIntSampler1d => "usampler1D",
            GlslDataType.UIntSampler2d => "usampler2D",
            GlslDataType.UIntSampler3d => "usampler3D",
            GlslDataType.UIntSamplerCube => "usamplerCube",
            GlslDataType.UIntSampler2DRect => "usampler2DRect",
            GlslDataType.UIntSampler1DArray => "usampler1DArray",
            GlslDataType.UIntSampler2DArray => "usampler2DArray",
            GlslDataType.UIntSamplerCubeArray => "usamplerCubeArray",
            GlslDataType.UIntSamplerBuffer => "usamplerBuffer",
            GlslDataType.UIntSampler2DMS => "usampler2DMS",
            GlslDataType.UIntSampler2DMSArray => "usampler2DMSArray",
            GlslDataType.Sampler1dShadow => "sampler1DShadow",
            GlslDataType.Sampler2dShadow => "sampler2DShadow",
            GlslDataType.SamplerCubeShadow => "samplerCubeShadow",
            GlslDataType.Sampler2DRectShadow => "sampler2DRectShadow",
            GlslDataType.Sampler1DArrayShadow => "sampler1DArrayShadow",
            GlslDataType.Sampler2DArrayShadow => "sampler2DArrayShadow",
            GlslDataType.SamplerCubeArrayShadow => "samplerCubeArrayShadow",
            GlslDataType.IntArray => "int[]",
            GlslDataType.IntVector2Array => "ivec2[]",
            GlslDataType.IntVector3Array => "ivec3[]",
            GlslDataType.IntVector4Array => "ivec4[]",
            GlslDataType.UIntArray => "uint[]",
            GlslDataType.UIntVector2Array => "uvec2[]",
            GlslDataType.UIntVector3Array => "uvec3[]",
            GlslDataType.UIntVector4Array => "uvec4[]",
            GlslDataType.FloatArray => "float[]",
            GlslDataType.FloatVector2Array => "vec2[]",
            GlslDataType.FloatVector3Array => "vec3[]",
            GlslDataType.FloatVector4Array => "vec4[]",
            GlslDataType.DoubleArray => "double[]",
            GlslDataType.DoubleVector2Array => "dvec2[]",
            GlslDataType.DoubleVector3Array => "dvec3[]",
            GlslDataType.DoubleVector4Array => "dvec4[]",
            GlslDataType.BoolArray => "bool[]",
            GlslDataType.BoolVector2Array => "bvec2[]",
            GlslDataType.BoolVector3Array => "bvec3[]",
            GlslDataType.BoolVector4Array => "bvec4[]",
            GlslDataType.Matrix2Array => "mat2[]",
            GlslDataType.Matrix2x3Array => "mat2x3[]",
            GlslDataType.Matrix2x4Array => "mat2x4[]",
            GlslDataType.Matrix3Array => "mat3[]",
            GlslDataType.Matrix3x2Array => "mat3x2[]",
            GlslDataType.Matrix3x4Array => "mat3x4[]",
            GlslDataType.Matrix4Array => "mat4[]",
            GlslDataType.Matrix4x2Array => "mat4x2[]",
            GlslDataType.Matrix4x3Array => "mat4x3[]",
            GlslDataType.DoubleMatrix2Array => "dmat2[]",
            GlslDataType.DoubleMatrix2x3Array => "dmat2x3[]",
            GlslDataType.DoubleMatrix2x4Array => "dmat2x4[]",
            GlslDataType.DoubleMatrix3Array => "dmat3[]",
            GlslDataType.DoubleMatrix3x2Array => "dmat3x2[]",
            GlslDataType.DoubleMatrix3x4Array => "dmat3x4[]",
            GlslDataType.DoubleMatrix4Array => "dmat4[]",
            GlslDataType.DoubleMatrix4x2Array => "dmat4x2[]",
            GlslDataType.DoubleMatrix4x3Array => "dmat4x3[]",
            _ => throw new InvalidOperationException()
        };
    }

    public static string GetInitializerFromValue<T>(T value)
        where T : struct
    {
        return value switch
        {
            int v0 => $"{v0}",
            Vector2i v0 => $"ivec2({v0.X}, {v0.Y})",
            Vector3i v0 => $"ivec3({v0.X}, {v0.Y}, {v0.Z})",
            Vector4i v0 => $"ivec4({v0.X}, {v0.Y}, {v0.Z}, {v0.W})",
            uint v0 => $"{v0}",
            Vector2ui v0 => $"uvec2({v0.Item1}, {v0.Item2})",
            Vector3ui v0 => $"uvec3({v0.Item1}, {v0.Item2}, {v0.Item3})",
            Vector4ui v0 => $"uvec4({v0.Item1}, {v0.Item2}, {v0.Item3}, {v0.Item4})",
            float v0 => $"{v0}",
            Vector2 v0 => $"vec2({v0.X}, {v0.Y})",
            Vector3 v0 => $"vec3({v0.X}, {v0.Y}, {v0.Z})",
            Vector4 v0 => $"vec4({v0.X}, {v0.Y}, {v0.Z}, {v0.W})",
            double v0 => $"{v0}",
            Vector2d v0 => $"dvec2({v0.X}, {v0.Y})",
            Vector3d v0 => $"dvec3({v0.X}, {v0.Y}, {v0.Z})",
            Vector4d v0 => $"dvec4({v0.X}, {v0.Y}, {v0.Z}, {v0.W})",
            bool v0 => $"{v0}",
            Vector2b v0 => $"bvec2({v0.Item1}, {v0.Item2})",
            Vector3b v0 => $"bvec3({v0.Item1}, {v0.Item2}, {v0.Item3})",
            Vector4b v0 => $"bvec4({v0.Item1}, {v0.Item2}, {v0.Item3}, {v0.Item4})",
            Matrix2 v0 => $"mat2({string.Join(", ", new Vector2[] { v0.Column0, v0.Column1 }.Select(v => $"{v.X}, {v.Y}"))})",
            Matrix2x3 v0 => $"mat2x3({string.Join(", ", new Vector2[] { v0.Column0, v0.Column1, v0.Column2 }.Select(v => $"{v.X}, {v.Y}"))})",
            Matrix2x4 v0 => $"mat2x4({string.Join(", ", new Vector2[] { v0.Column0, v0.Column1, v0.Column2, v0.Column3 }.Select(v => $"{v.X}, {v.Y}"))})",
            Matrix3 v0 => $"mat3({string.Join(", ", new Vector3[] { v0.Column0, v0.Column1, v0.Column2 }.Select(v => $"{v.X}, {v.Y}, {v.Z}"))})",
            Matrix3x2 v0 => $"mat3x2({string.Join(", ", new Vector3[] { v0.Column0, v0.Column1 }.Select(v => $"{v.X}, {v.Y}, {v.Z}"))})",
            Matrix3x4 v0 => $"mat3x4({string.Join(", ", new Vector3[] { v0.Column0, v0.Column1, v0.Column2, v0.Column3 }.Select(v => $"{v.X}, {v.Y}, {v.Z}"))})",
            Matrix4 v0 => $"mat4({string.Join(", ", new Vector4[] { v0.Column0, v0.Column1, v0.Column2, v0.Column3 }.Select(v => $"{v.X}, {v.Y}, {v.Z}, {v.W}"))})",
            Matrix4x2 v0 => $"mat4x2({string.Join(", ", new Vector4[] { v0.Column0, v0.Column1 }.Select(v => $"{v.X}, {v.Y}, {v.Z}, {v.W}"))})",
            Matrix4x3 v0 => $"mat4x3({string.Join(", ", new Vector4[] { v0.Column0, v0.Column1, v0.Column2 }.Select(v => $"{v.X}, {v.Y}, {v.Z}, {v.W}"))})",
            Matrix2d v0 => $"dmat2({string.Join(", ", new Vector2d[] { v0.Column0, v0.Column1 }.Select(v => $"{v.X}, {v.Y}"))})",
            Matrix2x3d v0 => $"dmat2x3({string.Join(", ", new Vector2d[] { v0.Column0, v0.Column1, v0.Column2 }.Select(v => $"{v.X}, {v.Y}"))})",
            Matrix2x4d v0 => $"dmat2x4({string.Join(", ", new Vector2d[] { v0.Column0, v0.Column1, v0.Column2, v0.Column3 }.Select(v => $"{v.X}, {v.Y}"))})",
            Matrix3d v0 => $"dmat3({string.Join(", ", new Vector3d[] { v0.Column0, v0.Column1, v0.Column2 }.Select(v => $"{v.X}, {v.Y}, {v.Z}"))})",
            Matrix3x2d v0 => $"dmat3x2({string.Join(", ", new Vector3d[] { v0.Column0, v0.Column1 }.Select(v => $"{v.X}, {v.Y}, {v.Z}"))})",
            Matrix3x4d v0 => $"dmat3x4({string.Join(", ", new Vector3d[] { v0.Column0, v0.Column1, v0.Column2, v0.Column3 }.Select(v => $"{v.X}, {v.Y}, {v.Z}"))})",
            Matrix4d v0 => $"dmat4({string.Join(", ", new Vector4d[] { v0.Column0, v0.Column1, v0.Column2, v0.Column3 }.Select(v => $"{v.X}, {v.Y}, {v.Z}, {v.W}"))})",
            Matrix4x2d v0 => $"dmat4x2({string.Join(", ", new Vector4d[] { v0.Column0, v0.Column1 }.Select(v => $"{v.X}, {v.Y}, {v.Z}, {v.W}"))})",
            Matrix4x3d v0 => $"dmat4x3({string.Join(", ", new Vector4d[] { v0.Column0, v0.Column1, v0.Column2 }.Select(v => $"{v.X}, {v.Y}, {v.Z}, {v.W}"))})",
            _ => throw new InvalidOperationException()
        };
    }

    public static string GetBuiltinVariableName(GlslBuiltinVariable name)
    {
        return name switch
        {
            GlslBuiltinVariable.BaseInstance => "gl_BaseInstance",
            GlslBuiltinVariable.BaseVertex => "gl_BaseVertex",
            GlslBuiltinVariable.ClipDistance => "gl_ClipDistance",
            GlslBuiltinVariable.DrawId => "gl_DrawID",
            GlslBuiltinVariable.InstanceId => "gl_InstanceID",
            GlslBuiltinVariable.PointSize => "gl_PointSize",
            GlslBuiltinVariable.Position => "gl_Position",
            GlslBuiltinVariable.VertexId => "gl_VertexID",
            _ => throw new InvalidOperationException()
        };
    }

    public static string BeginMain()
    {
        return "void main() {";
    }

    public static string EndMain()
    {
        return "}";
    }

    public static string DeclareVariable(GlslVariableType variableType, GlslDataType dataType, string name, int vertexAttributeLocation = 0)
    {
        return variableType switch
        {
            GlslVariableType.VertexInput => $"layout (location = {vertexAttributeLocation}) in {GetTypeName(dataType)} {name};",
            GlslVariableType.Input => $"in {GetTypeName(dataType)} {name};",
            GlslVariableType.Output => $"out {GetTypeName(dataType)} {name};",
            GlslVariableType.Uniform => $"uniform {GetTypeName(dataType)} {name};",
            _ => throw new InvalidOperationException()
        };
    }

    public static string AssignToVariable<T>(string name, T value)
        where T : struct
    {
        return $"{name} = {GetInitializerFromValue(value)}";
    }

    public static string AssignToVariableRaw<T>(string name, string value)
        where T : struct
    {
        return $"{name} = {value}";
    }

    public static string AssignToVariable<T>(GlslBuiltinVariable name, T value)
        where T : struct
    {
        return $"{GetBuiltinVariableName(name)} = {GetInitializerFromValue(value)}";
    }

    public static string DeclareAndAssignVariable<T>(GlslDataType dataType, string name, T value)
        where T : struct
    {
        return $"{GetTypeName(dataType)} {name} = {GetInitializerFromValue(value)}";
    }

    public static string DeclareAndAssignVariableRaw<T>(string dataType, string name, string value)
        where T : struct
    {
        return $"{dataType} {name} = {value}";
    }
}
