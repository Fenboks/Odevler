

class Program
{
    static void Main()
    {
        int toplam1 = CalculateSum(10, 20);
        Console.WriteLine("İki int sayının toplamı:"+toplam1);

        double toplam2 = CalculateSum(15.5, 10.3);
        Console.WriteLine("İki double sayının toplamı:"+toplam2);

        int toplam3 = CalculateSum(5, 15, 25);
        Console.WriteLine("Üç int sayının toplamı:"+toplam3);
    }

    static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    static double CalculateSum(double a, double b)
    {
        return a + b;
    }

    static int CalculateSum(int a, int b, int c)
    {
        return a + b + c;
    }
}