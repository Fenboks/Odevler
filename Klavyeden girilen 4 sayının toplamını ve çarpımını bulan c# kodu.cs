Console.WriteLine("Lütfen birinci sayıyı giriniz:");
int sayı1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
int sayı2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen üçüncü sayıyı giriniz:");
int sayı3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen dördüncü sayıyı giriniz:");
int sayı4 = Convert.ToInt32(Console.ReadLine());

int toplam = sayı1 + sayı2 + sayı3 + sayı4;
int çarpım = sayı1 * sayı2 * sayı3 * sayı4;

Console.WriteLine("Sayıların toplamı:" + toplam+" ve çarpımı:" + çarpım);
