public abstract class Weapon 
{
    public string Name { get; protected set; }
    public int Damage { get; protected set; }

    public void Upgrade()
    {
        this.Damage += 5;
    }
}

public class Longsword : Weapon
{
    public Longsword()
    {
        this.Name = "Longsword";
        this.Damage = 25;
    }
}

public class Hammer : Weapon
{
    public Hammer()
    {
        this.Name = "Hammer";
        this.Damage = 15;
    }
}