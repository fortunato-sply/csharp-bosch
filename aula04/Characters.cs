public class Yasuo : Entity
{
    public Yasuo()
    {
        this.Name = "Yasuo";
        this.Damage = 125;
        this.Armor = 50;
        this.Life = 590;
        this.Weapon = new Longsword();
    }
    public override void Attack(Entity target)
    {
        double damage = this.Damage / 2 + this.Weapon.Damage * 2;
        target.ReceiveDamage(damage);
    }
}

public class Poppy : Entity
{
    public Poppy()
    {
        this.Name = "Poppy";
        this.Damage = 75;
        this.Armor = 80;
        this.Life = 890;
        this.Weapon = new Hammer();
    }
    public override void Attack(Entity target)
    {
        double damage = this.Damage + this.Weapon.Damage + 15;
        target.ReceiveDamage(damage);
    }
}