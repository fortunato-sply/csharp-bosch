Console.Clear();
Clicker.printGame();
Console.WriteLine("Type anything to start the game.");
Console.ReadKey(true);

Store.FillStock();
char? x = null;
while(x != 'x')
{
    Console.Clear();
    Clicker.printGame();
    Console.WriteLine($"US${Clicker.Bitcoins} | Increments: {Clicker.Increment}");
    Console.WriteLine($"Type 1 to shop | Type 2 to view your GPUs | Type X to quit the game.");
    x = Console.ReadKey(true).KeyChar;
    if (x == '1')
    {
        int choice;
        while(true)
        {
            try
            {
                Store.ListStock();
                choice = int.Parse(Console.ReadLine());
                break;
            }
            catch
            {
                Console.WriteLine("Error: try again!");
            }
        }
        int? incrementGpu = Store.BuyGpu(choice);
        if (incrementGpu != null)
            Clicker.UpdateIncrement(incrementGpu);
    }
    else if (x == '2')
        Clicker.PrintGpus();
    else
        Clicker.Click();
}
