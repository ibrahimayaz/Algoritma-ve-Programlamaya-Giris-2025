int FibonacciTek(int n)
{
    if (n <= 1) return n;
    return FibonacciTek(n - 1) + FibonacciTek(n - 2);
}


Console.WriteLine(FibonacciTek(8));