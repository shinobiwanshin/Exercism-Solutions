static class LogLine
{
    public static string Message(string logLine)
    {
        string[] message = logLine.Split(":");
        string val = message[1].Trim();
        return val;
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf("[")+1;
        int end = logLine.IndexOf("]");
        return logLine.Substring(start, end - start).ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        String val1 = Message(logLine);
        String val2 = LogLevel(logLine);
        return $"{val1} ({val2})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
