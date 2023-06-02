using System;

public class ImplementISimpleCalculator : ISimpleCalculators
{
    public int Add(int start, int amount)
    {
        return (start + amount);
    }
    public int Subtract(int start, int amount)
    {
        return (start - amount);
    }
}
