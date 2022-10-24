public static class MyExtensionMethods
{
    public static double Sqrt(this double x) => Math.Sqrt(x);

    public static void Print<T>(this T obj) => Console.WriteLine(obj);

    public static List<T> Take<T> (this List<T> list, int N)
    {
        List<T> result = new List<T>();
        for (int i = 0; i < N && i < list.Count; i++)
        {
            result.Add(list[i]);
        }

        return result;
    }

    public static List<T> Skip<T> (this List<T> list, int N)
    {
        List<T> result = new List<T>();
        for (int i = N; i < list.Count; i++)
        {
            result.Add(list[i]);
        }
        
        return result;
    }
}