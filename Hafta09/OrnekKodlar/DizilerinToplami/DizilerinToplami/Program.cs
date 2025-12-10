//I.Yol
int[] d = { 2, 4, 6, 8 };
int toplam = 0;
for (int i = 0; i < d.Length; i++)
    toplam += d[i];//toplam=toplam+d[i];
Console.WriteLine(toplam);
//II.Yol
int j = 0;
while (j < d.Length)
{
    toplam += d[j];
    j++;
}
Console.WriteLine(toplam);

//III.Yol
foreach (int i in d)
{
    toplam += i;
}
Console.WriteLine(toplam);