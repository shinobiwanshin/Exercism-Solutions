static class LogLine
{
    private const string info = "[INFO]: ";
    private const string warning = "[WARNING]: ";
    private const string error = "[ERROR]: ";
    public static string getMessage(int replace1, string info, string logLine){
        string result = string.Empty;
        if(replace1 >= 0){
            result = logLine.Remove(replace1, info.Length);
        }
        string result1 = result.Trim();
        return result1;
    }
    public static string Message(string logLine)
    {
        int replace1 = logLine.IndexOf(info);
        int replace2 = logLine.IndexOf(warning);
        int replace3 = logLine.IndexOf(error);
        string ans = string.Empty;
        if(replace1 >= 0) ans = getMessage(replace1, info, logLine);
        else if(replace2 >= 0) ans = getMessage(replace2, warning, logLine);
        else ans = getMessage(replace3, error, logLine);
        string ans1 = ans.Trim();
        return ans1;
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int replace1 = logLine.IndexOf(info);
        int replace2 = logLine.IndexOf(warning);
        int replace3 = logLine.IndexOf(error);
        if(replace1 >= 0) return "info";
        else if(replace2 >= 0) return "warning";
        else return "error";
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        int replace1 = logLine.IndexOf(info);
        int replace2 = logLine.IndexOf(warning);
        int replace3 = logLine.IndexOf(error);
        string ans = string.Empty;
        string log = string.Empty;
        if(replace1 >= 0){
            ans = getMessage(replace1, info, logLine);
            log = "info";
        }
        else if(replace2 >= 0){
            ans = getMessage(replace2, warning, logLine);
            log = "warning";
        } 
        else{
            ans = getMessage(replace3, error, logLine);
            log = "error";
        }
        string res = $"{ans} ({log})";
        string ans1 = res.Trim();
        return ans1;
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
