string doğru_kullanıcı_adı = "admin";
string doğru_şifre="Admin_32453@";

while (true)
{

    Console.WriteLine("Lütfen kullanıcı adını giriniz:");
    string kullanıcı_adı = Console.ReadLine();

    Console.WriteLine("Lütfen şifreyi giriniz");
    string şifre = Console.ReadLine();

    if (kullanıcı_adı == doğru_kullanıcı_adı && şifre == doğru_şifre)
    {
        Console.WriteLine("Giriş başarılı.");
        
    }
    else
        Console.WriteLine("Hatalı kullanıcı adı veya şifre.");

    break;
}
