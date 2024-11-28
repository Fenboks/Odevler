class Program
{
    static void Main()
    {
        Console.WriteLine("Ortalama:" + OrtalamaHesapla(4.5, 3.2, 8.1, 6.7));
        Console.WriteLine("Ortalama:" + OrtalamaHesapla(10.0, 20.0, 30.0, 40.0));
        Console.WriteLine("Ortalama:" + OrtalamaHesapla()); 
    }
    static double OrtalamaHesapla(params double[] sayılar)
    {
        if (sayilar.Length == 0)
        {
            return 0;
        }
        double toplam = 0;

        foreach (double sayı in sayılar)
        {
            toplam += sayı;
        }
        return toplam / sayilar.Length;
    }
}