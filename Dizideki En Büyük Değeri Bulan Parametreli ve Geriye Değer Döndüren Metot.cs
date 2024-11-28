int[] sayılar = { 10, 25, 3, 42, 15 };

int enbüyük = enbüyükdeğer(sayılar);

    int enbüyükdeğer(int[] dizi)
{
    int enbüyük = dizi[0];

    foreach (int sayı in dizi)
    {
        if (sayı > enbüyük)
        {
            enbüyük = sayı;
        }
    }

    return enbüyük;
}

Console.WriteLine($"Dizideki en büyük değer: {enbüyük}");