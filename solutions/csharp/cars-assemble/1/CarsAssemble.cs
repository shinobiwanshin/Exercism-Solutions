static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed == 0) return 0;
        else if(speed >= 1 && speed <= 4) return 1.00;
        else if (speed >= 5 && speed <= 8) return 0.90;
        else if(speed == 9) return 0.80;
        else return 0.77;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double success = SuccessRate(speed);
        return (double) speed * 221 * success;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double perMinute = 221.0/60;
        double cars = perMinute * speed;
        double success = SuccessRate(speed);
        return (int) (cars * success);
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
