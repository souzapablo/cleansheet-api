namespace CleanSheet.Domain.Primitives;
public class Result<TValue> : Result
{
    public Result(TValue data)
        : base()
    {
        Data = data;
    }

    public Result(Error error)
        : base(error)
    {
    }

    public TValue? Data { get; private set; }

    public static implicit operator Result<TValue>(TValue value) => Create(value);
}
