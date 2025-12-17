
/*
 - Fonksiyon syntax
 dönüşTipi fonksiyonAdi(varsa alacağı parametre){
    çağrıldığında çalışacak kod bloğu
}

- Eğer dönüş tipi void ise değer döndermez manasına gelir. 
    Yani kod bloğunda return yer almaz!
- Eğer dönüş tipinde void haricinde 
    (int, double, bool, char, string, float...) veri tipi gelirse
    return olmak zorundadır.
- dönüş tipi ile returnden sonra gelecek ifade 
    aynı tipde olmalıdır. Aksi durumda hata verir.

- Fonksiyon çağırma işlemi aşağıdaki gibidir:
fonksiyonAdi();

Önemli Not: Ekrana yazı yazdırmak ile değer döndermek aynı kavramlar değildir !
Ekrana bir ifadeyi yazdırmak değer döndermek manasına gelmez !

Fonksiyon adları camelCase veya PascalCase göre yazılabilir. 

Matematik dersindeki fonksiyonlar konusunun aynısıdır. 
Matematikdeki fonksiyonlar değer dönderirler.
*/


// f(x)=x+1
// int tipinde parametre alan ve int değerini
// dönderen f adında bir fonksiyon.
int f(int x){
    return x + 1;
}
//Değer dönderdiği için işlem içinde kullanabilirim.
int y=f(3) + f(4); // 4+5


void Selamla()
{
    Console.WriteLine("Merhaba Tatvan MYO !");
}

//Fonksiyonun tanımlanması
void Yazdir(string mesaj)
{
    Console.WriteLine(mesaj);
}

//Fonksiyonun çağrılmassı: Function Call
Yazdir("Merhaba Bitlis");


//Topla(x,y)=x+y
int Topla(int x, int y)
{
    return x + y;
}

Topla(5, 6);

string Birlestir(string mesaj, int y)
{
    return $"{mesaj} {y}";
}

Console.WriteLine(Birlestir("SBST", 1));


int Kare(int x)
{
    return x * x;
}

Console.WriteLine(Kare(2));