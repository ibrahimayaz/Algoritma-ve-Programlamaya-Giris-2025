//I. YOL
int[] d = { 7, 8, 9 };
for (int i = 0; i < d.Length; i++)
    Console.WriteLine(d[i]);

//II.YOL
foreach (var s in d)
{
    Console.WriteLine(s);
}

//III.YOL
int j = 0;
while (j < d.Length)
{
    Console.WriteLine(d[j]);
    j++;
}