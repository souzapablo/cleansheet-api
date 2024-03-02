namespace CleanSheet.Domain.Primities;

public class Error(string code, string message)
{
    public string Code { get; init; } = code;
    public string Message { get; init; } = message;
}
