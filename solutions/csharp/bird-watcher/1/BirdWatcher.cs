class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeek = {0, 2, 5, 3, 7, 8, 4};
        return lastWeek;
        throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length-1];
        throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length-1]++;
        return;
        throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int it in birdsPerDay){
            if(it == 0) return true;
        }
        return false;
        throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int ans = 0;
        for(int i = 0; i<numberOfDays; i++){
            ans+=birdsPerDay[i];
        }
        return ans;
        throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        int ans = 0;
        foreach(int it in birdsPerDay){
            if(it >= 5) ans++;
        }
        return ans;
        throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}
