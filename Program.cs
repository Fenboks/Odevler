using System.Collections;

ArrayList isimler = new ArrayList();

for (int i = 0; i < 5; i++)
{
    Console.Write("Bir isim girin: ");
    string isim = Console.ReadLine();
    isimler.Add(isim);
}

isimler.Sort();

Console.WriteLine("\nAlfabetik Sıralama:");
foreach (var isim in isimler)
{
    Console.WriteLine(isim);
}