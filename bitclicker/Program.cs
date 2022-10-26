Console.Clear();
Console.WriteLine(@"""$$\       $$\   $$\                         $$\                                                                               $$\                         
$$ |      \__|  $$ |                        \__|                                                                              $$ |                        
$$$$$$$\  $$\ $$$$$$\    $$$$$$$\  $$$$$$\  $$\ $$$$$$$\         $$$$$$\   $$$$$$\  $$$$$$$\   $$$$$$\   $$$$$$\   $$$$$$\  $$$$$$\    $$$$$$\   $$$$$$\  
$$  __$$\ $$ |\_$$  _|  $$  _____|$$  __$$\ $$ |$$  __$$\       $$  __$$\ $$  __$$\ $$  __$$\ $$  __$$\ $$  __$$\  \____$$\ \_$$  _|  $$  __$$\ $$  __$$\ 
$$ |  $$ |$$ |  $$ |    $$ /      $$ /  $$ |$$ |$$ |  $$ |      $$ /  $$ |$$$$$$$$ |$$ |  $$ |$$$$$$$$ |$$ |  \__| $$$$$$$ |  $$ |    $$ /  $$ |$$ |  \__|
$$ |  $$ |$$ |  $$ |$$\ $$ |      $$ |  $$ |$$ |$$ |  $$ |      $$ |  $$ |$$   ____|$$ |  $$ |$$   ____|$$ |      $$  __$$ |  $$ |$$\ $$ |  $$ |$$ |      
$$$$$$$  |$$ |  \$$$$  |\$$$$$$$\ \$$$$$$  |$$ |$$ |  $$ |      \$$$$$$$ |\$$$$$$$\ $$ |  $$ |\$$$$$$$\ $$ |      \$$$$$$$ |  \$$$$  |\$$$$$$  |$$ |      
\_______/ \__|   \____/  \_______| \______/ \__|\__|  \__|       \____$$ | \_______|\__|  \__| \_______|\__|       \_______|   \____/  \______/ \__|      
                                                                $$\   $$ |                                                                                
                                                                \$$$$$$  |                                                                                
                                                                 \______/                                                                                 """);
Console.WriteLine("Type anything to start the game.");
Console.ReadKey(true);

Store.FillStock();
char? x = null;
while(x != 'x')
{
    Console.Clear();
    Console.WriteLine($"BTC {Clicker.Bitcoins} | Increments: {Clicker.Increment}");
    x = Console.ReadKey(true).KeyChar;
    if (x == '1')
    {
        Store.ListStock();
        int choice = int.Parse(Console.ReadLine());
        Console.ReadKey(true);
        Store.BuyGpu(choice);
        Clicker.UpdateIncrement();
    }
    else
        Clicker.Click();
}
