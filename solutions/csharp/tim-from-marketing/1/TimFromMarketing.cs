static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string own = "OWNER";
        if(id == null){
            if(department == null) return $"{name} - {own.ToUpper()}";
            return $"{name} - {department.ToUpper()}";
        }
        if(department == null) return $"[{id}] - {name} - {own.ToUpper()}";
        return $"[{id}] - {name} - {department.ToUpper()}";
        throw new NotImplementedException("Please implement the (static) Badge.Print() method");
    }
}
