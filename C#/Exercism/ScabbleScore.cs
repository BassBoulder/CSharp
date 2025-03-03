using System;

public static class ScrabbleScore
{
    public static int Score(string input) {

        int result = 0;
        string word = input.ToUpper();
    
        foreach (char c in word){
    
            result += c switch 
            {
                'Q' or 'Z' => 10, 
                'J' or 'X' => 8,
                'K' => 5,
                'F' or 'H' or 'V' or 'W' or 'Y' => 4,
                'B' or 'C' or 'M' or 'P' => 3,
                'D' or 'G' => 2,
                _ => 1
            };
        }
        return result;
    }
}