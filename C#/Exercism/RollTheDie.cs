using System;

public class Player
{
    public int RollDie()
    {
        Random rand = new Random();
        return rand.Next(1,10);
    }

    public double GenerateSpellStrength()
    {
        Random randdouble = new Random();
        return randdouble.NextDouble();
    }
}
