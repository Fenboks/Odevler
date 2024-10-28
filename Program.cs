Console.WriteLine("Lütfen bir sayı giriniz");
int sayı=Convert.ToInt32(Console.ReadLine());

if (sayı % 2 == 0)
{
    Console.WriteLine("Girdiğiniz sayı çiftir.");
}

else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}