Console.WriteLine("Fibonacci dizisindeki kaçıncı sayıyı görmek istiyorsun?");
int n = Convert.ToInt32(Console.ReadLine());

int sonuç = Fibonacci(n);

int Fibonacci(int n)
{
    if (n == 0)
        return 0;
    if (n == 1)
        return 1;

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
Console.WriteLine("Fibonacci sayısı:" + sonuç);