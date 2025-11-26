string[] isimler = {"Ali","Veli","Mehmet"};
//1. Yöntem
for(int i = 0; i < isimler.Length; i++)
{
    Console.WriteLine(isimler[i]);
}
//2. Yöntem
foreach (string i in isimler)
{
    Console.WriteLine(i);
}
//3. Yöntem
int j = 0;
while (j < isimler.Length)
{
    Console.WriteLine(isimler[j]);
    j++;
}
