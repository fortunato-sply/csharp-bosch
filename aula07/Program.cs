internal class Program
{
    private static void Main(string[] args)
    {
        Tree arvere1 = new Tree();
        arvere1.Add(20, arvere1);
        arvere1.Add(22, arvere1);
        arvere1.Add(18, arvere1);
        arvere1.Add(15, arvere1);
        Console.Write(arvere1.Contains(15));
        Console.Write(arvere1.Contains(230));
    }
}