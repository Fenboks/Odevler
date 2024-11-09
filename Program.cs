Console.WriteLine("Bir sayı giriniz:");

int n = int.Parse(Console.ReadLine());

int a = 0, b = 1;

Console.Write("Fibonacci serisi: ");

for (int i = 0; i < n; i++)
{
    if (i == 0)
        Console.Write(a + " ");
    else if (i == 1)
        Console.Write(b + " ");
    else
    {
        int next = a + b;
        Console.Write(next + " ");
        a = b;
        b = next; 
    }
}