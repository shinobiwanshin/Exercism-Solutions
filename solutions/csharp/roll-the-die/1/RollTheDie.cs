public class Player
{
    public int RollDie()
    {
        Random rw = new();
        return rw.Next(1, 19);
        throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
        Random rw = new();
        return  rw.NextDouble() * 100;
        throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}
