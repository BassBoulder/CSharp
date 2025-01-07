using System;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
    string colorlist = "";
        
        foreach (string color in colors){
            
            switch(color){
                    
                case "black":
                    colorlist += "0";
                    break;
                case "brown":
                    colorlist += "1";
                    break;    
                case "red":
                    colorlist += "2";
                    break;   
                case "orange":
                    colorlist += "3";
                    break;   
                case "yellow":
                    colorlist += "4";
                    break;   
                case "green":
                    colorlist += "5";
                    break;   
                case "blue":
                    colorlist += "6";
                    break;   
                case "violet":
                    colorlist += "7";
                    break;   
                case "grey":
                    colorlist += "8";
                    break;   
                case "white":
                    colorlist += "9";
                    break; 
            }
        }
    return Int32.Parse(colorlist.Substring(0,2));
    }
}
