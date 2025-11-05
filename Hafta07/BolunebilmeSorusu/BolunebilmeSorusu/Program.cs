/*
 1'den girilen sayıya kadar 2 ye bölünebilen 
ancak 7 ye bölünmeyen sayıları
ekrana yazdıran programın c# kodunu yazınız.
 */

Console.WriteLine("Lütfen bir tam sayı giriniz:");
int s=Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= s; i++)
{
	if ((i%2)==0 && (i%7)!=0)
	{
		Console.WriteLine(i);
	}
}