World mundo1 = new World();
Player[] players1 = new Player[1000];
for(int i = 0; i<500; i++)
{
    RandomPlayer player = new RandomPlayer();
    players1[i] = player;
}
for(int i = 500; i<1000; i++)
{
    TricksterPlayer player = new TricksterPlayer();
    players1[i] = player;
}
mundo1.Players = players1;

World mundo2 = new World();
Player[] players2 = new Player[1000];
for(int i = 0; i<500; i++)
{
    CollaboratorPlayer player = new CollaboratorPlayer();
    players2[i] = player;
}
for(int i = 500; i<1000; i++)
{
    SafePlayer player = new SafePlayer();
    players2[i] = player;
}
mundo2.Players = players2;

mundo1.Run();
mundo2.Run();