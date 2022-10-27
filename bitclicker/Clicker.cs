public static class Clicker
{
    public static float Bitcoins { get; set; } = 0;
    public static int? Increment { get; set; } = 1;
    public static List<Gpu> Gpus { get; set; } = new List<Gpu>();

    public static void printGame()
    {
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
    }

    public static void UpdateIncrement(int? increment)
    {
        Increment += increment;
    }

    public static void Click()
    {
        Bitcoins += (float)Increment;
    }

    public static void PrintGpus()
    {
        Console.Clear();
        if(Gpus.Count > 0)
        {
            Console.WriteLine("--- BOUGHT GPU ---");
            foreach(Gpu gpu in Gpus)
            {
                Console.WriteLine($"Model: {gpu.Name} - Increment: {gpu.Increment}");
            }
        }
        else
            Console.WriteLine("You don't have any GPU yet!");
            
        Console.WriteLine("Type anything to comeback...");
        Console.ReadKey(true);
    }
}