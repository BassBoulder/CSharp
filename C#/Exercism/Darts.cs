using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double result = Math.Sqrt(x * x + y * y);

        return result switch
        {
            <= 1  => 10,
            <= 5  => 5,
            <= 10 => 1,
            _ => 0
        };
    }
}
