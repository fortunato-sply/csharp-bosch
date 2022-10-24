public class Tree
{
    public int Value { get; set; }
    public Tree Left { get; set; } = null;
    public Tree Right { get; set; } = null;

    public void Add(int value)
    {
        Tree nt = new Tree();
        nt.Value = value;
        if (value >= Value)
        {
            if(Right != null)
            {
                Right = nt;
            }
            else
            {
                Console.WriteLine("Posição ocupada!");
            } 
        }
        else
        {
            if(Left != null)
            {
                Left = nt;
            }
            else
            {
                Console.WriteLine("Posição ocupada!");
            }
        }
            
    }

    public void Show()
    {
        Console.WriteLine($"VALUE: {Value}");
        if (Right != null)
        {
            Console.Write($"Esquerda: {Right.Value}");
        }
        if (Left != null)
        {
            Console.Write($"Esquerda: {Left.Value}");
        }      
    }

}