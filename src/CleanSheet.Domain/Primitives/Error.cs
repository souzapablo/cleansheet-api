namespace CleanSheet.Domain.Primitives;

public class Error(string code, string message)
{
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error NullValue = new("Error.NullValue", "The specified result value is null.");

    public string Code { get; init; } = code;
    public string Message { get; init; } = message;
}
