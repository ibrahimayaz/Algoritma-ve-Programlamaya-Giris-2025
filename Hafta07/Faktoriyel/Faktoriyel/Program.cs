Console.WriteLine("Lütfen bir tam sayı giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
int f = 1;
for (int i = 1; i <= n; i++)
{
    
    f = f * i;
}
Console.WriteLine($"Sonuç: {f}");