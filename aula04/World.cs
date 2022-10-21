public class World
{
    public Player[] Players;
    public int Round = 0;
    public int Total { get; set; }
    public PlayerList Falidos = new PlayerList();

    public void verifyBreak(Player[] players)
    {
        foreach (Player player in players)
        {
            if (player.Coins <= 0) Falidos.Add(player);
        } 
    }

    public void Play(Player p1, Player p2)
    {
        bool p1Decision = p1.Decide();
        bool p2Decision = p2.Decide();

        if (p1Decision) p1.Coins--;
        if (p2Decision) p2.Coins--;

        if (p1Decision && p2Decision)
        {
            p1.Receive(2); p2.Receive(2);
            Total += 2;
        }
        else if (p1Decision && !p2Decision)
        {
            p2.Receive(5);
            Total += 4;
        }
        else if (!p1Decision && p2Decision)
        {
            p1.Receive(5);
            Total += 4;
        }
        Round ++;
    }

    public void Run()
    {
        var rnd = new Random();
        int repeat = 0;
        while(repeat < 20000)
        {
            Player p1;
            Player p2;
            do
            {
                p1 = Players[rnd.Next(0, Players.Length)];
                p2 = Players[rnd.Next(0, Players.Length)];
            } while (p1.Coins == 0 || p2.Coins == 0 || p1 == p2);

            
            
            Play(p1, p2); 
            repeat++;
        }
        verifyBreak(Players);
        Console.WriteLine($"RODADAS: {Round}\nTOTAL DE MOEDAS: {Total}\nFALIDOS: {Falidos.Count}\n");
    }
}