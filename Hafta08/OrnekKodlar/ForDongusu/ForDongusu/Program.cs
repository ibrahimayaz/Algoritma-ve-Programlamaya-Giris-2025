//Klayeden girilen sayıya kadar ekrana
//tüm sayıları (çift hariç)  yazdıran programı yazınız 
int n= Convert.ToInt32(Console.ReadLine());
for (int i=0; i <=n; i++)
{
	if (i%2==0)
	{
		continue;
	}
	Console.WriteLine(i);
}