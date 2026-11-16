namespace PracticeCalculator;

// Adds two numbers, and adds up a list of numbers. The C# version of the practice calculator.
public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Total(IEnumerable<int> numbers)
    {
        int result = 0;
        foreach (int n in numbers)
        {
            result = Add(result, n);
        }
        return result;
    }
}
