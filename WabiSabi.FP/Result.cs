namespace WabiSabi.FP;

public readonly union Result<TSuccess, TFailure>(ResultSuccess<TSuccess>, ResultFailure<TFailure>)
{
    public static ResultSuccess<TSuccess> Success(TSuccess value) => new(value);
    public static ResultFailure<TFailure> Failure(TFailure error) => new(error);
}

public sealed record ResultSuccess<TSuccess>(TSuccess Value);
public sealed record ResultFailure<TFailure>(TFailure Error);
