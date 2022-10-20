public abstract class Port
{
    public Entry E1 { get; set; }
    public Entry E2 { get; set; }
    public abstract bool Output { get; set; }

    public Port()
    {
        this.E1 = null;
        this.E2 = null;
    }

    public void Connect(Port port)
    {
        Entry entry = new Entry();
        entry.Value = this.Output;

        if(port.E1 == null)
        {
            port.E1 = entry;
        }
        else if(port.E2 == null)
        {
            port.E2 = entry;
        }
    }
}

public class AndPort : Port
{
    private bool output;
    public override bool Output
    {
        get { return this.E1.IsOn() && this.E2.IsOn(); }
        set { output = this.E1.IsOn() && this.E2.IsOn(); }
    }
    
}

public class OrPort : Port
{
    private bool output;
    public override bool Output
    {
        get { return this.E1.IsOn() || this.E2.IsOn(); }
        set { output = this.E1.IsOn() || this.E2.IsOn(); }
    }

    public void ConnectAtNot(NotPort not)
    {
        Entry entry = new Entry();
        entry.Value = this.output;
        not.Entry = entry;
    }
}

public class NotPort
{
    public Entry Entry { get; set; }
    private bool output;
    public bool Output
    {
        get { return !this.Entry.Value; }
        set { output = !this.Entry.Value; }
    }
}