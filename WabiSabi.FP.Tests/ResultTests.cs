namespace WabiSabi.FP.Tests;

public class ResultTests
{
    [Fact]
    public void TestSuccess()
    {
        ResultSuccess<int> result = Result<int, string>.Success(42);
        Assert.Equal(42, result.Value);
    }

    [Fact]
    public void TestFailure()
    {
        ResultFailure<string> result = Result<int, string>.Failure("message");
        Assert.Equal("message", result.Error);
    }
}
