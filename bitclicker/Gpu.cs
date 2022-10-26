public abstract class Gpu
{
    public string Name { get; set; }
    public float Price { get; protected set; }
    public int Increment { get; protected set; }
    public int AvailableQuantity { get; set; }

    public Gpu(int quantity)
    {
        this.AvailableQuantity = quantity;
    }
}

public class GTX750TI : Gpu
{
    public GTX750TI(int quantity) : base(quantity)
    {
        this.Name = "GTX 750 TI";
        this.Price = 500;
        this.Increment = 8;
    }
}

public class GTX1050TI : Gpu
{
    public GTX1050TI(int quantity) : base(quantity)
    {
        this.Name = "GTX 1050 TI";
        this.Price = 600;
        this.Increment = 10;
    }
}

public class GTX1070 : Gpu
{
    public GTX1070(int quantity) : base(quantity)
    {
        this.Name = "GTX 1070";
        this.Price = 800;
        this.Increment = 15;
    }
}

public class RTX2070 : Gpu
{
    public RTX2070(int quantity) : base(quantity)
    {
        this.Name = "RTX 2070";
        this.Price = 1300;
        this.Increment = 25;
    }
}

public class RTX3080 : Gpu
{
    public RTX3080(int quantity) : base(quantity)
    {
        this.Name = "RTX 3080";
        this.Price = 2000;
        this.Increment = 50;
    }
}

public class RTX4090 : Gpu
{
    public RTX4090(int quantity) : base(quantity)
    {
        this.Name = "RTX 4090";
        this.Price = 5000;
        this.Increment = 200;
    }
}

public class TITAN : Gpu
{
    public TITAN(int quantity) : base(quantity)
    {
        this.Name = "NVIDIA TITAN";
        this.Price = 9000;
        this.Increment = 600;
    }
}
