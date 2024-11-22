public static class LogAnalysis
{
    public static string SubstringAfter(this string str){
        string[] afterwards = str.Split(':');
        return afterwards;
    }
}



LogAnalysis.SubstringAfter("Error: Help")