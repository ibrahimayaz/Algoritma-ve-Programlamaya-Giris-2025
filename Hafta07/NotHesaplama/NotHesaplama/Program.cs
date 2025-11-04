Console.WriteLine("Lütfen vize notunuzu giriniz:");
double v=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Lütfen final notunuzu giriniz:");
double f = Convert.ToDouble(Console.ReadLine());
//Vizenin %40 ile Finalin %60
double ort = v * 0.4 + f * 0.6;
string harfNotu = "";
if (ort>=90)
{
    harfNotu = "AA";
}else if (ort >= 80)
{
    harfNotu = "BA";
}else if (ort >= 70)
{
    harfNotu = "BB";
}else if (ort >= 60)
{
    harfNotu = "CC";
}else
{
    harfNotu = "FF";
}


Console.WriteLine(harfNotu);