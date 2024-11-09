    Random random = new Random();

    int doğrusayı = random.Next(1, 101);

    Console.WriteLine("Bir sayı tahmin edin");
while (true)
{
    int tahmin = Convert.ToInt32(Console.ReadLine());

    if (doğrusayı == tahmin)
    {
        Console.WriteLine("Doğru tahmin ettin");
        break;
    }
    else if (doğrusayı < tahmin)
    {
        Console.WriteLine("Soğuk");
    }
    else
    {
        Console.WriteLine("Sıcak");
    }
}

