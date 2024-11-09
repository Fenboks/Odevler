using System.ComponentModel.Design;

List<int> sayılar = new List<int>();
int toplam = 0;

Console.WriteLine("Pozitif tam sayılarınızı giriniz (Çıkmak için 0 değerini giriniz):");
int sayı = Convert.ToInt32(Console.ReadLine());

while (true)
{
    sayı = int.Parse(Console.ReadLine());

    if (sayı == 0) 
    break;

    if (sayı > 0)
    {
        sayılar.Add(sayı);
        toplam += sayı;
    }
    else
    {
        Console.WriteLine("Lütfen tam sayı giriniz:");
        break;
    }
}

Console.WriteLine("Girilen sayıların toplamı:"+toplam);

Console.WriteLine("Girilen sayılar:");
for (int i = 0; i < sayılar.Count; i++)
{
    Console.WriteLine(sayılar[i]);
}
