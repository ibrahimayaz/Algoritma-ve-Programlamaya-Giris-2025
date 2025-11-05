/*
 Klavyeden girilen sayının asal olup olmadığını bulan program
 */
Console.WriteLine("Lütfen bir tam sayı giriniz");
int n=Convert.ToInt32(Console.ReadLine());

if (n<2)
{
    Console.WriteLine("2den küçük asal sayı olamaz.");
    Console.WriteLine("Lütfen tekrar tam sayı giriniz");
    n = Convert.ToInt32(Console.ReadLine());
}
bool asalMi = false;
for (int i = 2; i < n; i++)
{
    if (n % i == 0)
    {
        asalMi=false;
        break;
    }
    else
    {
        asalMi= true;
    }
}

if (asalMi==true)
{
    Console.Write("Girilen sayı asaldır.");
}
else
{
    Console.Write("Girilen sayı asal değildir.");
}