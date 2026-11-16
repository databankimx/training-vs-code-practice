using PracticeCalculator;
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void AddTwoNumbers()
    {
        Assert.Equal(5, Calculator.Add(2, 3));
    }

    [Fact]
    public void TotalOfAList()
    {
        Assert.Equal(6, Calculator.Total(new[] { 1, 2, 3 }));
    }

    [Fact]
    public void TotalOfPricesIsSeven()
    {
        // Deliberately wrong, like the Python test of the same name. The Testing chapter uses this failure.
        Assert.Equal(7, Calculator.Total(new[] { 1, 2, 3 }));
    }
}
