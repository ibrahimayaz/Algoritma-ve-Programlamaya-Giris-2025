int[] d = { 11, 22, 5, 44 };
int enBuyuk = d[0];
int enKucuk = d[0];
for (int i = 1; i < d.Length; i++)
{
    if (d[i] > enBuyuk) enBuyuk = d[i];
    if (d[i] < enKucuk) enKucuk = d[i];
}
Console.WriteLine("En büyük: {enBuyuk}, En küçük: {enKucuk}");
Console.WriteLine($"En büyük: {enBuyuk}, En küçük: {enKucuk}");
