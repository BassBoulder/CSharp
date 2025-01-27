using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input){
        char[] InputCharArray = input.ToCharArray();
        
        Array.Reverse(InputCharArray);

        string ReversedInputStringArray = new String(InputCharArray);
        
        return ReversedInputStringArray;
    }
}