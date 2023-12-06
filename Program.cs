Console.WriteLine("tahmin oyununu oynamak ister misiniz? (E/H)");
string cevap = Console.ReadLine();

if (cevap == "E" || cevap == "e")
{
    Tahmin();
}
else
{
    Console.WriteLine("Uygulamadan Çıkış Yaptınız!");
    return;
}

static void Tahmin()
{
    int sayi = new Random().Next(1, 100);
    int tahmin = 0;

    Console.WriteLine("Tahmininizi yazın: ");

    tahmin = int.Parse(Console.ReadLine());

    if (tahmin == sayi)
    {
        Console.WriteLine("Tebrikler tahmin doğru!");
        Console.WriteLine($"Sayı: {sayi}");
        return;
    }
    else
    {
        Console.WriteLine("Tahmin yanlış!");
        Console.WriteLine($"Sayı: {sayi}");
        return;
    }
}

