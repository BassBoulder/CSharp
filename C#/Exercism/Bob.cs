using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement) {

        var trimmedStatement = statement.Trim();
        
        if (string.IsNullOrWhiteSpace(trimmedStatement)){
            return "Fine. Be that way!";
        }

        bool hasLetters = trimmedStatement.Any(char.IsLetter);
        bool question = trimmedStatement.EndsWith('?');
        bool shouting = hasLetters && trimmedStatement.ToUpperInvariant() == trimmedStatement;

        if (question && shouting) {
            return "Calm down, I know what I'm doing!";
        }
        if (question) {
            return "Sure.";
        }
        if (shouting) {
            return "Whoa, chill out!";
        }
        else {
            return "Whatever.";
        }
    }
}