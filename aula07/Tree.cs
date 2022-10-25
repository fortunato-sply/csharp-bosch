public class Tree
{
    public int? Value { get; set; } = null;
    public Tree? Left { get; set; } = null;
    public Tree? Right { get; set; } = null;

    public void Add(int value, Tree crr)
    {
        if (crr.Value == null)
        {
            crr.Value = value;
            return;
        }
           
        Tree nt = new Tree();  
        if (value >= crr.Value)
        {
            if(crr.Right == null)
            {                    
                crr.Right = nt;
            }
            else
            {
                crr = crr.Right;
            }
        }
        else
        {
            if(crr.Left == null)
            {
                crr.Left = nt;
            }
            else
            {
                crr = crr.Left;
            }
        }

        Add(value, crr);
    }          

    public void Show()
    {
        Console.WriteLine($"VALUE: {Value}");
        if (Right != null)
        {
            Console.Write($"Direita: {Right.Value}");
        }
        if (Left != null)
        {
            Console.Write($"Esquerda: {Left.Value}");
        }      
    }

    public bool Contains(int value)
    {
        if (this.Value == value)
            return true;
        
        if (value < this.Value)
            if (this.Left != null)
                return Left.Contains(value);
            else return false;
        else
            if (this.Right != null)
                return Right.Contains(value);
            else return false;
    }

}