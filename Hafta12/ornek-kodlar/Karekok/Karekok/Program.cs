int EnBuyukBul(int[] dizi)
{
    int enBuyuk = dizi[0];

    for (int i = 1; i < dizi.Length; i++)
    {
        if (dizi[i] > enBuyuk)
        {
            enBuyuk = dizi[i];
        }
    }

    return enBuyuk;
}
int[] tamSayiDizisi = { 5, 8, 9, 500265, 699880 };
Console.WriteLine(EnBuyukBul(tamSayiDizisi));