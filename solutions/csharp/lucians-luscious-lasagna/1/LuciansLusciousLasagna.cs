class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    int time = 40;
    public int ExpectedMinutesInOven(){
        return time;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeElapsed){
        return time - timeElapsed;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers){
        return 2 * layers;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int timeElapsed){
        return (2 * layers) + timeElapsed;
    }
}
