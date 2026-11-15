namespace WabiSabi.FP.Tests;

public class OptionTests
{
    [Theory]
    [InlineData(null, false)] 
    [InlineData(42, true)] 
    public void TestOptionValueType(int? value, bool expected)
    {
        bool hasValue = false;
        bool isSome = true;

        Option<int> option = value.HasValue
            ? Option<int>.Some(value.Value)
            : Option<int>.None();
        option.Match(x => hasValue = true, () => isSome = false);

        Assert.Equal(expected, hasValue);
        Assert.Equal(expected, isSome);
    }

    [Theory]
    [InlineData(null, false)]
    [InlineData("value", true)]
    public void TestOptionReferenceType(string? value, bool expected)
    {
        bool hasValue = false;
        bool isSome = true;

        Option<string> option = value is not null
            ? Option<string>.Some(value)
            : Option<string>.None();
        option.Match(x => hasValue = true, () => isSome = false);

        Assert.Equal(expected, hasValue);
        Assert.Equal(expected, isSome);
    }
}
