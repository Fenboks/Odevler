double taban, yükseklik, alan;

Console.WriteLine("Bu kod üçgenin alanını hesaplıyor");

while (true)
{

    Console.WriteLine("Lütfen taban uzunluğunu giriniz:");
    taban = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Lütfen yüksekliği giriniz:");
    yükseklik = Convert.ToDouble(Console.ReadLine());

    alan = taban * yükseklik / 2;

    Console.WriteLine(alan);

    Console.WriteLine("Programdan çıkmak için 'çıkış' yazın, devam etmek için herhangi bir tuşa basın");
    string çıkış = Console.ReadLine();

    if (çıkış == "çıkış")
    {
        break;
    }

}
Console.WriteLine("İşlem sonlandırılıyor..");
