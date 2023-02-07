namespace Backend.Graphics.OpenGL;

public class OpenGLException : Exception
{
	public int ErrorCode { get; set; }

	public OpenGLException(string message, int errorCode = 0)
		: base(PrepareMessage(message, errorCode))
	{
		ErrorCode = errorCode;
	}

	public static string PrepareMessage(string message, int errorCode)
	{
		return $"{(errorCode == 0 ? "[Internal]" : $"[OpenGL/{errorCode}]")} {message}";
	}
}
