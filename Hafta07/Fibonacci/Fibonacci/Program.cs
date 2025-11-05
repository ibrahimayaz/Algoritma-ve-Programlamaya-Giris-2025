Console.WriteLine("Terim sayısını giriniz:");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
int i = 1;
while (i <= n)
{
    Console.Write(a + " ");
    var temp = a + b;
    a = b;
    b= temp;
    i++;

}