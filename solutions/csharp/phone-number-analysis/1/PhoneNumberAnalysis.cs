public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string [] num= phoneNumber.Split("-");
        bool IsNewYork = num[0] == "212";
        bool IsFake = num[1] == "555";
        string LocalNumber = num[2];
        return (IsNewYork, IsFake, LocalNumber);
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.Analyze() method");
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
        throw new NotImplementedException($"Please implement the (static) PhoneNumber.IsFake() method");
    }
}
