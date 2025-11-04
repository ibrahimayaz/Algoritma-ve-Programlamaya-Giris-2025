/*
 Klavyeden girilen sayıya kadar olan 
    çift sayılardan 5 ile bölünebilen sayıları ekrana 
yazdıran programın C# kodunu yazınız
 */

Console.WriteLine("Lütfen bir tam sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i <= sayi; i = i + 2)
{
    if(i%5== 0)
    {
        Console.WriteLine(i);
    }
}
