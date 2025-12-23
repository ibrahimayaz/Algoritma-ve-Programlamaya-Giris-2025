int[] FibonacciSerisi(int n)
{
    //n elemanlı bir tam sayı dizi oluşturur.
    int[] dizi = new int[n];

    for (int i = 0; i < n; i++)
    {
        if (i <= 1)
            dizi[i] = i;
        else
            dizi[i] = dizi[i - 1] + dizi[i - 2];
    }

    return dizi;
}

foreach (var item in FibonacciSerisi(5))
{
    Console.Write(item + " ");
}