using System;

static class LogLine
{
    public static string Message(string logLine) => logLine.Split(":")[1].Trim();

    public static string LogLevel(string logLine) => logLine.Substring(1).Split("]")[0].Trim().ToLower();

    public static string Reformat(string logLine) => LogLine.Message(logLine) + " (" + LogLine.LogLevel(logLine) + ")";
}
