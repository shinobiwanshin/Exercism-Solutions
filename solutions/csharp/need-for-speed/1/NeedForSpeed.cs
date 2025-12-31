class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public int distance;
    public int battery;
    public int speed;
    public int batteryDrain;
    public RemoteControlCar(int speed, int batteryDrain){
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        distance = 0;
        battery = 100;
    }

    public bool BatteryDrained()
    {
        if(battery < batteryDrain) return true;
        return false;
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDrained() method");
    }

    public int DistanceDriven()
    {
        return distance;
        throw new NotImplementedException("Please implement the RemoteControlCar.DistanceDriven() method");
    }

    public void Drive()
    {
        if(BatteryDrained()) return;
        distance += speed;
        battery -= batteryDrain;
        return;
        throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
        throw new NotImplementedException("Please implement the (static) RemoteControlCar.Nitro() method");
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    int distance;
    public RaceTrack(int distance){
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained()) car.Drive();
        return car.DistanceDriven() >= distance;
        throw new NotImplementedException("Please implement the RaceTrack.TryFinishTrack() method");
    }
}
