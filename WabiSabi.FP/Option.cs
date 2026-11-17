namespace WabiSabi.FP;

public readonly union Option<T>(OptionSome<T>, OptionNone)
{
    public static Option<T> None() => new OptionNone();
    public static Option<T> Some(T value) => new OptionSome<T>(value);

    public void Match(Action<T> onSome, Action? onNone = null)
    {
        if (this is OptionSome<T> some)
            onSome.Invoke(some.Value);
        else
            onNone?.Invoke();
    }
}

public sealed record OptionSome<T>(T Value);
public sealed record OptionNone();