
int MaxBul(int a, int b)
{
    return (a > b) ? a : b;
}
Console.WriteLine("Lütfen birinci sayıyı gir:");
int sayi1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı gir:");
int sayi2 =Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"En büyük sayı: {MaxBul(sayi1, sayi2)}");