using System.Collections;

ArrayList sayilar = new ArrayList { 9, 80, 59, 15, 37 };

int toplam = 0; 

foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
    toplam += sayi;
}

Console.WriteLine("Sayıların Toplamı: " + toplam);