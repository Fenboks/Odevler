class Program
{
    static void Main()
    {
        int[] sayılar = { 10, 15, 20, 25, 30 };
        int filtre = 18;
        int toplam = FiltreToplam(sayılar, filtre);
        Console.WriteLine("Toplam: " + toplam);
    }
    static int FiltreToplam(int[] dizi, int filtre)
    {
        int toplam = 0;

        foreach (int sayı in dizi)
        {
            if (sayı > filtre)
            {
                toplam += sayı;
            }
        }
        return toplam;
    }
}