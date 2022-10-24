using System.Collections;

public class PlayerList : IEnumerable
{
   private Player[] values = new Player[10];
    private int count = 0;

    public Player this[int index]
    {
        get 
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();
            return values[index];
        }
        set
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();
            values[index] = value;
        }
    }

    public int Count => count;

    public void Add(Player player)
    {
        if (count == values.Length)
        {
            Player[] newValues = new Player[2 * values.Length];
            for (int i = 0; i < values.Length; i++)
                newValues[i] = values[i];
            this.values = newValues;
        }

        values [count] = player;
        count++;
    }

    public IEnumerator GetEnumerator()
    {
        PlayerListIterator enumerator = new PlayerListIterator(this);
        return enumerator;
    }
}

public class List<T> : IEnumerable
{
    private T[] values = new T[10];
    private int count = 0;

    public T this[int index]
    {
        get 
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();
            return values[index];
        }
        set
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();
            values[index] = value;
        }
    }

    public int Count => count;

    public void Add(T num)
    {
        if (count == values.Length)
        {
            T[] newValues = new T[2 * values.Length];
            for (int i = 0; i < values.Length; i++)
                newValues[i] = values[i];
            this.values = newValues;
        }

        values [count] = num;
        count++;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < Count; i++)
            yield return values[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public class ListIterator<T> : IEnumerator<T>
{
    private List<T> list;
    int index = -1;
    public ListIterator(List<T> list)
    {
        this.list = list;
    }
    public T Current => list[index];

    object IEnumerator.Current => this.Current;

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public bool MoveNext()
    {
        index++;
        return index < list.Count;
    }

    public void Reset() => index = -1;
}

public class PlayerListIterator : IEnumerator
{
    private PlayerList list;
    int index = -1;
    public PlayerListIterator(PlayerList list)
    {
        this.list = list;
    }
    public object Current => list[index];

    public bool MoveNext()
    {
        index++;
        return index < list.Count;
    }

    public void Reset() => index = -1;
}