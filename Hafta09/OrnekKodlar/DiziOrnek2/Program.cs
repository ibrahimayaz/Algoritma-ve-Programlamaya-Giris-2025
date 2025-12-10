int[] sayilar={1,2,5,6,7,8,9,10};
int toplam=0;
int i=0;
while(i < sayilar.Length)
{
    if (sayilar[i] % 3 == 0)
    {
        toplam += sayilar[i];
    } 
    i++;
}
Console.WriteLine("Toplam: " + toplam);