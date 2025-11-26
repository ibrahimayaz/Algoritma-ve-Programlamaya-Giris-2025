for (int i = 1; i <=2; i++)        // 2 satır
{
    for (int j = 1; j <= 5; j++)    // Her satırda 1–5 arası sayılar
    {
        if (j % 2 == 0)             // j çift mi?
        {
            Console.Write(j + "(çift) ");
        }
        else
        {
            Console.Write(j + " ");
        }
    }
    Console.WriteLine();            // Satır sonu
}