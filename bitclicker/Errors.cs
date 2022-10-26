public class NoMoneyException : Exception
{
   public NoMoneyException() { }

   public NoMoneyException(string message)
        : base(message) { } 
}

public class NoStockException : Exception
{
   public NoStockException() { }

   public NoStockException(string message)
        : base(message) { } 
}