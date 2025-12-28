public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string log, string delimiter){
        // string [] val = log.Split(delimiter);
        return log.Split(delimiter)[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string log, string d1, string d2){
        // string []val = log.Split(d1);
        // string []val2 = val[1].Split(d2);
        return log.Split(d1)[1].Split(d2)[0];
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