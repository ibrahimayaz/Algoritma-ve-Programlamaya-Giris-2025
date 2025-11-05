/*
 Klavyeden girilen sayının pozitif mi negatif mi yada sıfır mı 
 olduğunu bulan programın C# kodunu yazınız. 
 */
Console.WriteLine("Lütfen bir tam sayı giriniz:");
int sayi=Convert.ToInt32(Console.ReadLine());

if (sayi>0)
{
    Console.WriteLine($"Girilen sayı pozitiftir: {sayi}");
}else if (sayi < 0)
{
    Console.WriteLine($"Girilen sayı negatif: {sayi}");
}
else
{
    Console.WriteLine($"Girilen sayı sıfırdır: {sayi}");
}