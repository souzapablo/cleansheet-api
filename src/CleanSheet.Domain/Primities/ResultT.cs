namespace CleanSheet.Domain.Primities;
public class Result<TValue> : Result
{
    protected Result(TValue data)
    {
        Data = data;
    }

    protected Result(Error error) 
        : base(error)
    {
    }

    public TValue? Data { get; private set; }

    public static Result<TValue> Success(TValue data) => new(data);
    public static new Result<TValue> Failure(Error error) => new(error);
}
