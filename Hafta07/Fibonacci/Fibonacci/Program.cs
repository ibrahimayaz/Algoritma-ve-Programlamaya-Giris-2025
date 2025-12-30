Console.WriteLine("Terim sayısını giriniz:");
int n = Convert.ToInt32(Console.ReadLine());

int n_2 = 0; // F(n-2)
int n_1 = 1; // F(n-1)

int i = 1;
while (i <= n)
{
    Console.Write(n_2 + " ");

    int n = n_2 + n_1; // F(n)
    n_2 = n_1;          // yeni F(n-2)
    n_1 = n;            // yeni F(n-1)

    i++;
}