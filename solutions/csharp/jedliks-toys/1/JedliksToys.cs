class RemoteControlCar
{
    private int meters = 0;
    private int percentage = 100;
    public static RemoteControlCar Buy()
    {
        RemoteControlCar Car = new RemoteControlCar();
        return Car;
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Buy() method");
    }

    public string DistanceDisplay()
    {
        return $"Driven {meters} meters";
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDisplay() method");
    }

    public string BatteryDisplay()
    {
        if(percentage == 0) return "Battery empty";
        return $"Battery at {percentage}%";
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

    public void Drive()
    {
        if(percentage == 0) return;
        meters += 20;
        percentage -= 1;
        return;
        throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }
}
