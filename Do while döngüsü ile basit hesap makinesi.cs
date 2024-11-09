string input;
do //while(true) da kullanılabilir buraya. Bir de ondalık sayılarda hata veriyor double ı nasıl kullanacağımı çözemedim.
{
    Console.WriteLine("İşlem seçin (+, -, *, /) veya 'çıkış' yazarak programdan çıkın:");
    input = Console.ReadLine();

    if (input == "çıkış")
        break;

    Console.Write("İlk sayıyı giriniz: ");
    double sayı1=Convert.ToInt32(Console.ReadLine());
    
    Console.Write("İkinci sayıyı giriniz: ");
    double sayı2 =Convert.ToInt32(Console.ReadLine());

    switch (input)
    {
        case "+":
            Console.WriteLine("Sonuç:"+(sayı1+sayı2));
            break;
        case "-":
            Console.WriteLine("Sonuç:"+ (sayı1 - sayı2));
            break;
        case "*":
            Console.WriteLine("Sonuç:"+(sayı1 * sayı2));
            break;
        case "/":
            if (sayı2 != 0)
                Console.WriteLine("Sonuç:"+(sayı1 / sayı2));
            else
                Console.WriteLine("Hata: Bir sayıyı sıfıra bölünemezsin.");
            break;
        default:
            Console.WriteLine("Geçersiz işlem türü girdin.");
            break;
    }

} 
while (input != "çıkış");

Console.WriteLine("Program kapanıyor..");
