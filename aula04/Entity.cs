public abstract class Entity
{
    public string Name { get; protected set; }
    public double Life { get; protected set; }
    public double Damage { get; protected set; } 
    public Weapon Weapon { get; protected set; }
    public double Armor { get; protected set; }
    public abstract void Attack(Entity target);
    public void ReceiveDamage(double damage)
    {
        double posMitigationDamage = damage * 100.0 / (100.0 + Armor);
        this.Life -= posMitigationDamage;
    }

    public void UpgradeWeapon()
    {
        this.Weapon.Upgrade();
    }

    public void Show()
    {
        Console.WriteLine($"NAME: {this.Name}\nHP: {this.Life}\n");
    }
}
