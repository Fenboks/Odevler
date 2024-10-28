while (true)
{
    Console.WriteLine("Lütfen 10 ile 40 arası sıcaklığı giriniz:");
    int sıcaklık = Convert.ToInt32(Console.ReadLine());

    if (10 <= sıcaklık && sıcaklık <= 19)
    {
        Console.WriteLine("Normal.");
        break;
    }
    else if (sıcaklık == 20)
    {
        Console.WriteLine("Ne Normal Ne Yüksek.");
        break;
    }
    else if (20 <= sıcaklık && sıcaklık <= 29)
    {
        Console.WriteLine("Yüksek.");
        break;
    }
    else if (sıcaklık == 30)
    {
        Console.WriteLine("Ne Yüksek Ne Çok Yüksek.");
        break;
    }
    else if (30 <= sıcaklık && sıcaklık <= 40)
    {
        Console.WriteLine("Çok Yüksek.");
        break;
    }
    else
            Console.WriteLine("Geçersiz sıcaklık girdiniz.");
}
