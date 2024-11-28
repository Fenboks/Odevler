class Program
{
    static void Main()
    {
        Console.WriteLine("Sonuç(yaş belirtilmedi): " + YaşFarkı());
        Console.WriteLine("Sonuç(yaş 25): " + YaşFarkı(25));
        Console.WriteLine("Sonuç(yaş 18): " + YaşFarkı(18));
    }
    static int YaşFarkı(int yaş = 18)
    {
        return yaş - 18;
    }
}