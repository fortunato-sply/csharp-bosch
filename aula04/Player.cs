public abstract class Player
{
    public int Coins {  get; set; } = 1;

    public abstract bool Decide();

    public void Receive(int coins) => Coins += coins;
}

public class RandomPlayer : Player
{
    public override bool Decide()
    {
        Random rnd = new Random();
        bool decision = rnd.NextDouble() > 0.5;

        return decision;
    }
}

public class TricksterPlayer : Player
{
    public override bool Decide() => false;
}

public class CollaboratorPlayer : Player
{
    public override bool Decide() => true;
}

public class SafePlayer : Player
{
    public override bool Decide() => this.Coins > 1 ? true : false;
}