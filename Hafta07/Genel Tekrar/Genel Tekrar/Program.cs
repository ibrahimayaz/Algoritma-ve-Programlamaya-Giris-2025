/*Klavyeden girilen sayının faktöriyelini hesaplayan C#*/
//n!=n*(n-1)*(n-2)...1

Console.Write("Lütfen bir tam sayı giriniz: ");
int n=Convert.ToInt32(Console.ReadLine());
int f = 1;
for (int i = 1; i <= n; i++)
{
    f *= i; //f=f*1
}
Console.WriteLine($"{n} faktöriyelin sonucu: {f}");
