class Program
{
    static void Main()
    {
        string[] kelimeler = { "Hasan", "Berkay", "Muhammed", "Emir", "Ali", "Ahmet" };

        List<string> uzunKelimeler = Filtrele(kelimeler);

        Console.WriteLine("Uzunluğu 5'ten büyük kelimeler:");
        foreach (string kelime in uzunKelimeler)
        {
            Console.WriteLine(kelime);
        }
    }
    static List<string> Filtrele(string[] dizi)
    {
        List<string> sonuç = new List<string>();

        foreach (string kelime in dizi)
        {
            if (kelime.Length > 5)
            {
                sonuç.Add(kelime);
            }
        }

        return sonuç;
    }
}
