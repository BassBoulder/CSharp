using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `String` type
    public static String SubstringAfter(this String message, String delimiter){
        return message.Split(delimiter)[1];
    }
    
    // TODO: define the 'SubstringBetween()' extension method on the `String` type
    public static String SubstringBetween(this String message, String delimiter1, String delimiter2){
        return message.Split(delimiter1)[1].Split(delimiter2)[0];
    }
    
    // TODO: define the 'Message()' extension method on the `String` type
    public static String Message(this String message){
        return message.SubstringAfter(": ");    
    }
        
    // TODO: define the 'LogLevel()' extension method on the `String` type
    public static String LogLevel(this String message){
        return message.SubstringBetween("[", "]");    
    }
}