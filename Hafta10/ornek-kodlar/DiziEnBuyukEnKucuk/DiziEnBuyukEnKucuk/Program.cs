int[] d = { 11, 22, 5, 44 };
//II.Yol
int enBuyuk = d[0];
int enKucuk = d[0];
int i = 1;
while (i < d.Length) {
    if (d[i] > enBuyuk) enBuyuk = d[i];
    if (d[i] < enKucuk) enKucuk = d[i];
    i++;
}
Console.WriteLine($"En büyük: {enBuyuk}, En küçük: {enKucuk}");
//III.Yol
int enb = d[0];
int enk = d[0];
foreach (var s in d)
{
    if (s > enb)
    {
        enb = s;
    }
    if (s < enk)
    {
        enk = s;
    }
}
Console.WriteLine($"En büyük: {enb}, En küçük: {enk}");
