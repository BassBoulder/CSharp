using System;

public static class Identifier
{
    
    public static string Clean(string identifier)
    {
        string cleaned = "";
        bool nextChar = false;

        foreach (char c in identifier){
            if (c == ' '){
                cleaned += "_";
            }
            else if (c < 13) {
                cleaned += "CTRL";
            }   
            else if (c >= 'α' && c <= 'ω'){
                continue;
            }
            else if (c == '-'){
                nextChar = true;
            }
            else if (nextChar == true){
                cleaned += char.ToUpper(c);
                nextChar = false;
            }
            else if (char.IsLetter(c)){
                cleaned += c;
            }   
        }
        return cleaned;
    }
}