public class Entry
{
    public bool Value { get; set; }

    public void Connect(Port port)
    {
        if(port.E1 == null)
        {
            port.E1 = this;
        }
        else if(port.E2 == null)
        {
            port.E2 = this;
        }
        
    }

    public bool IsOn()
    {
        return Value;
    }
}