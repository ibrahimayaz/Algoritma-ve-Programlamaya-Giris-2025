int DiziToplam(int[] arr)
{
    int toplam = 0;
    for (int i = 0; i < arr.Length; i++)
        toplam += arr[i];
    return toplam;
}
int[] adiOnemliDegil = { 9, 4, 7, 8 };
Console.WriteLine(DiziToplam(adiOnemliDegil));