int sayi = 0;
do
{
    Console.Write("Bir sayı giriniz (Çıkmak için 0): ");
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi != 0)
    {
        Console.WriteLine("Girdiğiniz sayı: " + sayi);
    }
} while (sayi != 0);