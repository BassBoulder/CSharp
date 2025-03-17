public enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42
}
static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine){
        
        return logLine switch 
        {
            string stringy when stringy.Contains("[TRC]") => LogLevel.Trace,
            string stringy when stringy.Contains("[DBG]") => LogLevel.Debug,
            string stringy when stringy.Contains("[INF]") => LogLevel.Info,
            string stringy when stringy.Contains("[WRN]") => LogLevel.Warning,
            string stringy when stringy.Contains("[ERR]") => LogLevel.Error,
            string stringy when stringy.Contains("[FTL]") => LogLevel.Fatal,
            _ => LogLevel.Unknown
        };     
    }

    public static string OutputForShortLog(LogLevel logLevel, string message){

        return $"{(int)logLevel}:{message}";
    }
}
