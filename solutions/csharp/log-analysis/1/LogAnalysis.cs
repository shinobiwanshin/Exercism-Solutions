public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string log, string val){
        int ind1 = log.IndexOf(val);
        if(ind1 == -1) return string.Empty;
        return log.Substring(ind1 + val.Length);
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string log, string d1, string d2){
        int val1 = log.IndexOf(d1);
        val1 += d1.Length;
        int val2 = log.IndexOf(d2);
        return log.Substring(val1, val2 - val1);
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string log){
        return log.SubstringAfter(": ");
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string log){
        return log.SubstringBetween("[", "]");
    }
}