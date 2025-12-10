int[] d = { 1, 2, 3, 4, 9, 20, 22, 25 };
int adet = 0;
Console.WriteLine("Lütfen alt sınırı giriniz:");
int alt =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen üst sınırı giriniz:");
int ust = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < d.Length; i++)
{
    if (d[i] >= alt && d[i] <= ust)
    {
        adet++;
    }
}
Console.WriteLine(adet);