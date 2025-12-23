int Faktoriyel(int n)
{
    // Taban durum
    if (n == 0 || n == 1)
    {
        return 1;
    }

    // Özyinelemeli adım
    return n * Faktoriyel(n - 1);
}

Console.WriteLine(Faktoriyel(5));