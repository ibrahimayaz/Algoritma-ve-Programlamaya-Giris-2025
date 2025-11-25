string gun="";
do
{
    Console.WriteLine("Lütfen bir gün giriniz.");
    gun=Console.ReadLine().ToLower();
    if (gun != "pazartesi")
    {
        Console.WriteLine($"Girdiğiniz gün: {gun}");
    }
}while (gun != "pazartesi");