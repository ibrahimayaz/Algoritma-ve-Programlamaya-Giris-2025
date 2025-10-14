//İlk Ders - 14.10.2025

int yas = 4;
double sayi = 4.5;
bool evliMi = true;
string cumle = "Merhaba Tatvan MYO";
char karakter = 'A';

Console.WriteLine("Mesaj: " + evliMi +" : "+cumle+ " : " + (yas + sayi));


//String Interpolation
Console.WriteLine($"Mesaj: {evliMi} : {cumle} : {yas+sayi}");

/*
 Klavyeden girilen sayırının karesini hesaplayan programın C# kodunu yaz.
 */
/* SÖZDE KOD:
 * BAŞLA
 *      sayi <- kullanıcından sayı al
 *      sonuc=sayi*sayi
 *      YAZDIR sonuc
 * BİTİR
 * 
 */

Console.Write("Kullanıcıdan sayı al: ");
int SAYI = int.Parse(Console.ReadLine());

var sonuc = SAYI * SAYI;

Console.WriteLine($"Sonuç:{sonuc}");

