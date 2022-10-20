public class Entrada {
    public bool Bit2 { get; set; }
    public bool Bit0 { get; set; }
} 

public class Circuito
{
    private Entrada input1;
    public Entrada Input1
    {
        get { return input1; }
        set { input1 = value; }
    }

    private Entrada input2;
    public Entrada Input2
    {
        get { return input2; }
        set { input2 = value; }
    }

    public bool Output
    {
        get
        {
            if((input1.Bit2 && input2.Bit2) | (input1.Bit2 && input1.Bit0 && input2.Bit0) | (input1.Bit2 ^ input2.Bit2 && input1.Bit0 && input2.Bit0))
            {
                return true;
            }
            return false;
        }
        set{}
    }

    public bool Output2
    {
        get
        {
            if(input1.Bit0 && input1.Bit2 && input2.Bit0 && input2.Bit2) return true;
            if((input1.Bit2 && input1.Bit0 && input2.Bit0) || (input1.Bit2 ^ input2.Bit2 && input1.Bit0 && input2.Bit0)) return false;
            return (input1.Bit0 && input2.Bit0) || (input1.Bit2 ^ input2.Bit2);
        }
        set {}
    }

    public bool Output3
    {
        get
        {
            if(input1.Bit0 && input1.Bit2 && input2.Bit0 && input2.Bit2) return false;
            if(input1.Bit0 && input2.Bit0 && !input1.Bit2 | !input2.Bit2) return false;
            return input1.Bit0 ^ input2.Bit0;
        }
    }
    
}