namespace WabiSabi.FP;

public class Option<T>
{
    private readonly T? _value;
    private readonly bool _isSome;

    private Option(T? value, bool isSome)
    {
        _value = value;
        _isSome = isSome;
    }

    public static Option<T> None() => new(default, false);
    public static Option<T> Some(T value) => new(value, true);

    public void Match(Action<T> onSome, Action? onNone = null)
    {
        if (_isSome)
            onSome.Invoke(_value!);
        else
            onNone?.Invoke();
    }
}
