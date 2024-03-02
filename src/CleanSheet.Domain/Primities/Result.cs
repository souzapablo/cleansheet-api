namespace CleanSheet.Domain.Primities;
public class Result
{
    protected Result()
    {
        IsSuccess = true;
    }

    protected Result(Error error)
    {
        Error = error;
        IsSuccess = false;
    }

    public bool IsSuccess { get; init; }
    public Error? Error { get; init; }

    public static Result Success() => new();

    public static Result Failure(Error error) => new(error);
}
