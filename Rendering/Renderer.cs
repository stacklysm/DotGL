using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Rendering;

public class Renderer
{
    private readonly GameWindowSettings WindowSettings1 = new()
    {
        RenderFrequency = 60d,
        UpdateFrequency = 60d,
    };

    private readonly NativeWindowSettings WindowSettings2 = new()
    {
        API = ContextAPI.OpenGL,
        APIVersion = new(4, 6),
        AutoLoadBindings = true,
        Profile = ContextProfile.Core,
        StartFocused = true,
        StartVisible = true,
        Title = "Render Output",
        WindowState = WindowState.Normal
    };

    private void DefaultResizeHandler(ResizeEventArgs obj)
    {
        GL.Viewport(0, 0, obj.Width, obj.Height);
        ViewportWidth = obj.Width;
        ViewportHeight = obj.Height;
    }

    private static void DefaultDebugProcedure(DebugSource source, DebugType type, int id, DebugSeverity severity, int length, IntPtr message, IntPtr userParam)
    {
        string msg = Marshal.PtrToStringAnsi(message, length);
        Trace.WriteLine($"[{severity}][{source}/{type}:{id}] {msg}", "OpenGL");
    }

    private static Renderer? Instance;

    private GameWindow? RenderOutput;
    private Color4 ClearColor;

    public int WindowLocationX { get; private set; }
    public int WindowLocationY { get; private set; }
    public int ViewportWidth { get; private set; }
    public int ViewportHeight { get; private set; }

    public static Renderer GetInstance()
    {
        return Instance ??= new();
    }

    public static void EnableCapability(EnableCap capability)
    {
        GL.Enable(capability);
    }

    public static void DisableCapability(EnableCap capability)
    {
        GL.Disable(capability);
    }

    public static void Clear()
    {
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
    }

    public static void EnableDebugProcedure(DebugProc? handler = null)
    {
        GL.DebugMessageCallback(handler ?? DefaultDebugProcedure, 0);
    }

    private Renderer()
    {
        ClearColor = Color4.Gainsboro;

        RenderOutput = new(WindowSettings1, WindowSettings2);
        RenderOutput.MakeCurrent();
    }

    public void SetViewportLocation(int locationX, int locationY)
    {
        WindowLocationX = locationX;
        WindowLocationY = locationY;
    }

    public void SetViewportDimensions(int width, int height)
    {
        ViewportWidth = width;
        ViewportHeight = height;
    }

    public void SetClearColor(Color4 color)
    {
        ClearColor = color;
        GL.ClearColor(color);
    }

    public void SetWindowTitle(string title)
    {
        WindowSettings2.Title = title;
        RenderOutput!.Title = title;
    }

    public void SetRefreshRate(double fps)
    {
        WindowSettings1.RenderFrequency = fps;
        RenderOutput!.RenderFrequency = fps;
    }

    public void SetUpdateRate(double fps)
    {
        WindowSettings1.UpdateFrequency = fps;
        RenderOutput!.RenderFrequency = fps;
    }

    public void SwapBuffers()
    {
        RenderOutput!.SwapBuffers();
    }

    public void Start(Action<FrameEventArgs> renderHandler, Action? loadRenderer = null, Action? unloadRenderer = null, Action<FrameEventArgs>? updateHandler = null, Action<ResizeEventArgs>? resizeHandler = null)
    {
        RenderOutput!.RenderFrame += renderHandler;

        if (updateHandler is not null)
        {
            RenderOutput!.UpdateFrame += updateHandler;
        }

        if (loadRenderer is not null)
        {
            RenderOutput!.Load += loadRenderer;
        }

        if (unloadRenderer is not null)
        {
            RenderOutput!.Unload += unloadRenderer;
        }

        RenderOutput!.Resize += resizeHandler ?? DefaultResizeHandler;

        RenderOutput!.Run();
    }
}
