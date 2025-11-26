//Diziler birden fazla değeri tek bir değişkende saklamaya yarayan tiplerdir.
/*
 Not: Dizi dizinleri 0 ile başlar: 
[0] ilk öğedir. [1] ikinci öğedir, vb.
son öğe ise dizinin eleman sayısının 1 (diziAdi.Length-1) eksiğidir.
*/
//Dizilerde değerler/elemanlar süslü parantez { } içerisine yazılır.
//Her bir eleman virgülle ayrılır.
string[] arabalar = { "Volvo", "BMW", "Ford", "Mazda" };
int[] sayilar = { 1, 5, 100, -150, 25};
bool[] dogruMu = { true, false, true, false };
double[] ondalikliSayilar = { 1, 5.4, 110.7 };
char[] harfler = {'A','Y','A','Z'};
//Dizideki belirli bir indexe erişme diziAdi[indexNumarası]
//şeklinde yazılmalıdır.
Console.WriteLine(sayilar[4]);

//Dizinin Eleman Sayısını / Uzunluğunu bulma
Console.WriteLine(ondalikliSayilar.Length);
//Not: index ile eleman sayısını karıştırmayın.

//Dizideki elemanın değerini değiştirme/güncelleme
sayilar[4] = -1255;
ondalikliSayilar[1] = -5.8;
ondalikliSayilar[2] = -5;
//Dizinin Son Indexi
Console.WriteLine(harfler[harfler.Length-1]);

// Dizi tanımlama biçimleri
// 1. yöntem:
// Dört öğeden oluşan bir dizi oluşturun ve daha sonra değerleri ekleyin
string[] cars1 = new string[4];
cars1[0] = "Toros";
cars1[1] = "Lada Samara";
cars1[2] = "Toyota Subra";
cars1[3] = "Range Rover";
// 2. yöntem
// Dört öğeden oluşan bir dizi oluşturun ve hemen değerler ekleyin
string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

// 3. Yöntem
// Boyutu belirtmeden dört öğeden oluşan bir dizi oluşturun
string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

// 4. Yöntem
// Yeni anahtar kelimesini atlayarak ve boyutu belirtmeden
// dört öğeden oluşan bir dizi oluşturun
// En Kısa Kullanım (Tavsiye Edilen)
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

