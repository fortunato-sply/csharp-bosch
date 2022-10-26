public static class Clicker
{
    public static float Bitcoins { get; set; } = 0;
    public static float Increment { get; set; } = 1;
    public static List<Gpu> Gpus { get; set; } = new List<Gpu>();

    public static void UpdateIncrement()
    {
        foreach (Gpu gpu in Gpus)
        {
            Increment += gpu.Increment;
        }
    }

    public static void Click()
    {
        Bitcoins += Increment;
    }
}