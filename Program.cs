Console.Write("Bir cümle giriniz: ");
string cümle = Console.ReadLine();

string[] kelimeler = cümle.Split(' ');

int kelimesayısı = kelimeler.Length;

Console.WriteLine("Cümledeki kelime sayısı: " + kelimesayısı);