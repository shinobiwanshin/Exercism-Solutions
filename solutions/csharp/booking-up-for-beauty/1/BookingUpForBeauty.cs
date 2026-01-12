static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
        throw new NotImplementedException("Please implement the (static) Appointment.Schedule() method");
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now;
        throw new NotImplementedException("Please implement the (static) Appointment.HasPassed() method");
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        int hr = appointmentDate.Hour;
        return hr >= 12 && hr < 18;
        throw new NotImplementedException("Please implement the (static) Appointment.IsAfternoonAppointment() method");
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate}.";
        throw new NotImplementedException("Please implement the (static) Appointment.Description() method");
    }

    public static DateTime AnniversaryDate()
    {
        int date = DateTime.Now.Year;
        return new DateTime(date, 9, 15);
        throw new NotImplementedException("Please implement the (static) Appointment.AnniversaryDate() method");
    }
}
