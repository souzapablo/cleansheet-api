namespace CleanSheet.Domain.Primitives;
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
    public static Result<TValue> Success<TValue>(TValue value) => new(value);
    public static Result Failure(Error error) => new(error);
    public static Result<TValue> Failure<TValue>(Error error) => new(error);
    public static Result<TValue> Create<TValue>(TValue? data) => data is not null ? Success(data) : Failure<TValue>(Error.NullValue);
}
