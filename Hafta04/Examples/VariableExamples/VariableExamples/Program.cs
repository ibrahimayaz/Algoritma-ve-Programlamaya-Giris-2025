//Bir tam sayı değişkeni tanımlayınız.
int a = 9;
// ondalıklı veri tipi ile bir değişken tanımlayınız.
float x = 5.4f;
double y = 4.5;
decimal z = 3.4m;
//metinsel veri tipi ile bir değişken tanımlayınız.
string cumle = "Merhaba Tatvan MYO";
//tek karakter veri tipi ile bir değişken tanımlayınız.
char k = 'a';
//mantıksal veri tipi ile bir değişken tanımlayınız.
bool cinsiyet = true;

int sayi1 = 4;
int sayi2 = 9;
var toplam = sayi1 + sayi2;
Console.WriteLine("Sonuç:" + toplam + " " + cumle); //değişken bileştirme
Console.WriteLine($"Sonuç:{toplam} {cumle} {a}"); //String interpolation
