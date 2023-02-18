using OpenTK.Mathematics;

namespace Rendering;

public class Camera
{
    public static Vector3 Front => -Vector3.UnitZ;

    public static Vector3 Up => Vector3.UnitY;

    public static Vector3 Right => Vector3.UnitX;

    public Vector3 Position { get; set; }

    public Vector3 Target { get; set; }

    public float AspectRatio { get; set; }

    public float Fov { get; set; }

    public float NearPlane { get; set; }

    public float FarPlane { get; set; }

    public Camera(Vector3? position = null, Vector3? target = null, float fov = 60.0f, float nearPlane = 0.01f, float farPlane = 1000.0f)
    {
        Position = position ?? Vector3.UnitZ * 3;
        Target = target ?? new(0f, 0f, -1f);
        Fov = fov;
        NearPlane = nearPlane;
        FarPlane = farPlane;
    }

    public Matrix4 View()
    {
        return Matrix4.LookAt(Position, Position + Front, Up);
    }

    public Matrix4 Projection(float aspectRatio)
    {
        return Matrix4.CreatePerspectiveFieldOfView(Fov * (MathF.PI / 180.0f), aspectRatio, NearPlane, FarPlane);
    }
}
