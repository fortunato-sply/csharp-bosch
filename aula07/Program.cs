internal class Program
{
    private static void Main(string[] args)
    {
        IntLinkedList list = new IntLinkedList();
        list.Add(4);
        list.Add(2);
        list.Add(1);

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}