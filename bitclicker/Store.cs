public static class Store
{
    private static List<Gpu> GpuStock = new List<Gpu>();

    public static void FillStock()
    {
        GpuStock.Add(new GTX750TI(5));
        GpuStock.Add(new GTX1050TI(3));
        GpuStock.Add(new GTX1070(6));
        GpuStock.Add(new RTX2070(5));
        GpuStock.Add(new RTX3080(7));
        GpuStock.Add(new RTX4090(3));
        GpuStock.Add(new TITAN(2));
    }

    public static void ListStock()
    {
        int n = 1;
        foreach (Gpu gpu in GpuStock)
        {
            Console.WriteLine($"{n}. Model: {gpu.Name} - Price: US${gpu.Price} - Increment: {gpu.Increment} - Available Quantity: {gpu.AvailableQuantity}");
            n++;
        }

        Console.WriteLine("Type the number of GPU: ");
    }

    public static int? BuyGpu(int position)
    {
        try
        {
            Gpu gpu = GpuStock[position - 1];
            if (gpu.AvailableQuantity < 1)
                throw new NoStockException();

            if (Clicker.Bitcoins < gpu.Price)
                throw new NoMoneyException();

            gpu.AvailableQuantity--; 
            Clicker.Gpus.Add(gpu);
            Clicker.Bitcoins -= gpu.Price;
            Console.WriteLine($"{gpu.Name} was bougth successfull! Type anything to comeback.");
            Console.ReadKey(true);
            return gpu.Increment;
        }
        catch (NoMoneyException)
        {
            Console.WriteLine("You don't have money to buy this GPU!\nType anything to comeback.");
            Console.ReadKey(true);
            return null;
        }
        catch (NoStockException)
        {
            Console.WriteLine("Insufficient stock!");
            Console.ReadKey(true);
            return null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.StackTrace);
            Console.ReadKey(true);
            return null;
        }
    }
}