//Console.WriteLine("Lütfen adınızı giriniz:");
//var isim=Console.ReadLine();

//Console.WriteLine($"Merhaba {isim}");

//----------------------------

//Console.WriteLine("Lütfen 1. sayıyı giriniz:");
//var s1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Lütfen 2. sayıyı giriniz:");
//var s2 = Convert.ToInt32(Console.ReadLine());

//if (s1 == s2)
//{
//    Console.WriteLine("Girilen sayılar eşittir.");
//}else if (s1 > s2)
//{
//    Console.WriteLine($"En büyük sayı: {s1}");
//}
//else
//{
//    Console.WriteLine($"En büyük sayı: {s2}");
//}

//----------------------------
// Otomatik dönüşüm
int kucukSayi = 100;
long buyukSayi = kucukSayi;    // Otomatik dönüşüm

float kucukOndalik = 3.14f;
double buyukOndalik = kucukOndalik; // Otomatik dönüşüm

//Açık Dönüşüm
double sayi = 125.26;
int sayi2 = (int)sayi; //Açık Dönüşüm

//Manuel Dönüşümler (Convert)

string sayiMetin = "123";
var sayi3 = Convert.ToInt32(sayiMetin);

string ondalikMetin = "45.67";
double ondalik = Convert.ToDouble(ondalikMetin);
Console.WriteLine(ondalik);

string cinsiyet = "True";
bool dogru = Convert.ToBoolean(cinsiyet);
