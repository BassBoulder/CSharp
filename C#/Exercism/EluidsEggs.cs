using System;
using System.Numerics;

public static class EliudsEggs
{
    public static int EggCount(int encodedCount) => BitOperations.PopCount((uint)encodedCount);
}
