# Hafta 04: C# ile Programlamaya Giriş

## Ders Hedefleri
Bu dersin sonunda öğrenciler:
- C# programlama dilini tanıyacak
- İlk C# programını yazabilecek
- Temel veri türlerini kullanabilecek
- Console uygulamaları geliştirebilecek

## 1. C# Nedir?

**C# (C Sharp)**, Microsoft tarafından geliştirilen modern, nesne yönelimli bir programlama dilidir.

### C# Özellikleri
- **Tip Güvenli:** Hataları önceden yakalar
- **Nesne Yönelimli:** Büyük projelerde düzenli kod
- **Çoklu Platform:** Windows, Linux, MacOS'da çalışır
- **Güçlü Kütüphane:** .NET Framework zengin özellikleri
- **Kolay Öğrenim:** Anlaşılır söz dizimi

### C# vs Diğer Diller
```
| Özellik        | C#     | Java   | Python    | C++        |
|----------------|--------|--------|-----------|------------|
| Öğrenme        | Kolay  | Orta   | Çok Kolay | Zor        |
| Performans     | Yüksek | Yüksek | Orta      | Çok Yüksek |
| Platform       | Çoklu  | Çoklu  | Çoklu     | Çoklu      |
| Tip Güvenliği  | Var    | Var    | Yok       | Kısmi      |
```

## 2. C# Geliştirme Ortamı

### Gerekli Yazılımlar
1. **Visual Studio 2022** (Ücretsiz Community Edition)
2. **Visual Studio Code** (Hafif editör)
3. **.NET SDK** (Çalışma ortamı)

### Kurulum Adımları
1. Microsoft Visual Studio Community 2022'yi indirin
2. Kurulum sırasında ".NET desktop development" workload'ını seçin
3. Kurulumu tamamlayın
4. İlk projeyi oluşturun

## 3. İlk C# Programı

### Console Application Oluşturma
```csharp
using System;

namespace IlkProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya!");
            Console.ReadKey();
        }
    }
}
```

### Kod Açıklaması
- `using System;` → Sistem kütüphanesini kullan
- `namespace İlkProgram` → Program gruplandırması
- `class Program` → Ana sınıf tanımı
- `static void Main()` → Programın başlangıç noktası
- `Console.WriteLine()` → Ekrana yazı yazdır
- `Console.ReadKey()` → Tuşa basma bekle

## 4. C# Temel Söz Dizimi

### 4.1 Büyük/Küçük Harf Duyarlılığı
C# büyük/küçük harf duyarlıdır:
```csharp
int sayi = 5;    // Doğru
int Sayi = 10;   // Farklı değişken
int SAYI = 15;   // Yine farklı değişken
```

### 4.2 Noktalı Virgül (;)
Her komut noktalı virgül ile biter:
```csharp
int a = 5;
string isim = "Ahmet";
Console.WriteLine("Merhaba");
```

### 4.3 Süslü Parantezler { }
Kod blokları süslü parantezlerle belirtilir:
```csharp
if (koşul)
{
    // Bu blok koşul doğruysa çalışır
    komut1;
    komut2;
}
```

### 4.4 Yorum Satırları
```csharp
// Tek satır yorum

/*
   Çok satırlı
   yorum bloğu
*/

```

## 5. Veri Türleri

### 5.1 Tam Sayı Türleri
```csharp
// Küçük tam sayılar
byte yas = 25;           // 0-255 arası
sbyte sicaklik = -10;    // -128 ile 127 arası

// Normal tam sayılar  
short kisaSayi = 1000;   // -32,768 ile 32,767
ushort pozitifKisa = 2000; // 0 ile 65,535

// Büyük tam sayılar
int sayi = 1000000;      // -2 milyar ile +2 milyar
uint pozitifSayi = 3000000; // 0 ile 4 milyar

// Çok büyük tam sayılar
long uzunSayi = 9000000000; // Çok büyük aralık
ulong pozitifUzun = 18000000000; // Pozitif çok büyük
```

### 5.2 Ondalık Sayı Türleri
```csharp
float pi = 3.14f;        // 7 haneli hassasiyet
double ePi = 2.718281828; // 15-17 haneli hassasiyet  
decimal para = 1234.56m; // 28-29 haneli, para için ideal
```

### 5.3 Karakter ve Metin Türleri
```csharp
char harf = 'A';         // Tek karakter
string isim = "Mehmet";  // Metin (string)
string bosMetin = "";    // Boş string
string nullMetin = null; // Null string
```

### 5.4 Mantıksal Tür
```csharp
bool dogru = true;       // Doğru
bool yanlis = false;     // Yanlış
bool sonuc = (5 > 3);    // true
```

### 5.5 Diğer Önemli Türler
```csharp
DateTime simdi = DateTime.Now;     // Tarih-saat
TimeSpan sure = TimeSpan.FromHours(2); // Zaman aralığı
object hersey = "Bu bir string";   // Her türü tutabilir
var otomatik = 123;               // Otomatik tür belirleme (int)
```

## 6. Değişken Tanımlama

### 6.1 Temel Tanımlama
```csharp
// Tür değişkenAdı = değer;
int yas = 18;
string ad = "Ayşe";
bool ogrenciMi = true;
double not = 85.5;
```

### 6.2 Çoklu Tanımlama
```csharp
// Aynı türde birden fazla değişken
int a, b, c;
int x = 1, y = 2, z = 3;

// Farklı türlerde
string isim = "Ali";
int yas = 20;
bool aktif = true;
```

### 6.3 Sabitler (Constants)
```csharp
const double PI = 3.14159;
const string OKUL_ADI = "İstanbul Üniversitesi";
const int MAX_OGRENCI = 100;

// Sabitleri değiştirmeye çalışırsan hata alırsın
// PI = 3.14; // HATA!
```

### 6.4 Değişken Adlandırma Kuralları
```csharp
// DOĞRU adlandırmalar
int ogrenciSayisi;      // Camel Case (önerilen)
string kullaniciAdi;
bool islemTamamMi;

// YANLIŞ adlandırmalar
// int 123sayı;         // Sayı ile başlayamaz
// string class;        // Anahtar kelime kullanılamaz
// bool öğrenci-aktif;  // Tire kullanılamaz
```

## 7. Ekrana Yazma ve Okuma

### 7.1 Ekrana Yazma
```csharp
// Basit yazma
Console.Write("Merhaba ");      // Satır sonu yok
Console.WriteLine("Dünya!");    // Satır sonu var

// Değişken yazdırma
string isim = "Fatma";
int yas = 22;
Console.WriteLine("İsim: " + isim);
Console.WriteLine("Yaş: " + yas);

// String interpolation (modern yöntem)
Console.WriteLine($"İsim: {isim}, Yaş: {yas}");

// Formatted string
Console.WriteLine("İsim: {0}, Yaş: {1}", isim, yas);
```

### 7.2 Kullanıcıdan Veri Alma
```csharp
// String olarak alma
Console.Write("Adınızı girin: ");
string kullaniciAdi = Console.ReadLine();

// Sayı olarak alma (dönüştürme gerekli)
Console.Write("Yaşınızı girin: ");
string yasMetin = Console.ReadLine();
int yas = Convert.ToInt32(yasMetin);

// Daha güvenli yöntem
Console.Write("Notunuzu girin: ");
string notMetin = Console.ReadLine();
if (int.TryParse(notMetin, out int not))
{
    Console.WriteLine($"Notunuz: {not}");
}
else
{
    Console.WriteLine("Geçersiz not girdiniz!");
}
```

## 8. Tip Dönüşümleri

### 8.1 Otomatik Dönüşüm (Implicit)
```csharp
int kucukSayi = 100;
long buyukSayi = kucukSayi;    // Otomatik dönüşüm

float kucukOndalik = 3.14f;
double buyukOndalik = kucukOndalik; // Otomatik dönüşüm
```

### 8.2 Açık Dönüşüm (Explicit)
```csharp
double buyuk = 123.456;
int kucuk = (int)buyuk;        // 123 (ondalık kısmı kaybolur)

long uzun = 1000;
int normal = (int)uzun;        // Güvenli aralıkta
```

### 8.3 Convert Sınıfı
```csharp
string sayiMetin = "123";
int sayi = Convert.ToInt32(sayiMetin);

string ondalikMetin = "45.67";
double ondalik = Convert.ToDouble(ondalikMetin);

bool dogru = Convert.ToBoolean("True");
```

### 8.4 Parse Metodu
```csharp
string sayiStr = "789";
int sayi = int.Parse(sayiStr);

string ondalikStr = "12.34";
double ondalik = double.Parse(ondalikStr);

string boolStr = "True";
bool boool = bool.Parse(boolStr);
```

### 8.5 TryParse (Güvenli Dönüşüm)
```csharp
string kullaniciGirdisi = "abc123"; // Geçersiz sayı

// Güvensiz yöntem - hata verir
// int sayi = int.Parse(kullaniciGirdisi); // EXCEPTION!

// Güvenli yöntem
if (int.TryParse(kullaniciGirdisi, out int sayi))
{
    Console.WriteLine($"Geçerli sayı: {sayi}");
}
else
{
    Console.WriteLine("Geçersiz sayı girdiniz!");
}
```

## 9. Pratik Örnekler

### Örnek 1: Basit Tanıtım Programı
```csharp
using System;

namespace Tanitim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişken tanımlamaları
            string ad, soyad, meslek;
            int yas;
            double maas;
            bool evliMi;
            
            // Kullanıcıdan bilgi alma
            Console.Write("Adınız: ");
            ad = Console.ReadLine();
            
            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();
            
            Console.Write("Yaşınız: ");
            yas = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Mesleğiniz: ");
            meslek = Console.ReadLine();
            
            Console.Write("Maaşınız: ");
            maas = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Evli misiniz? (true/false): ");
            evliMi = Convert.ToBoolean(Console.ReadLine());
            
            // Bilgileri ekrana yazdırma
            Console.WriteLine("\n--- KİŞİ BİLGİLERİ ---");
            Console.WriteLine($"Ad Soyad: {ad} {soyad}");
            Console.WriteLine($"Yaş: {yas}");
            Console.WriteLine($"Meslek: {meslek}");
            Console.WriteLine($"Maaş: {maas:C}"); // Para formatında
            Console.WriteLine($"Medeni Durum: {(evliMi ? "Evli" : "Bekar")}");
            
            Console.ReadKey();
        }
    }
}
```

### Örnek 2: Basit Hesaplama
```csharp
using System;

namespace Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişkenler
            double sayi1, sayi2;
            double toplam, fark, carpim, bolum;
            
            // Sayıları alma
            Console.WriteLine("=== HESAP MAKİNESİ ===");
            Console.Write("Birinci sayıyı girin: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("İkinci sayıyı girin: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            
            // Hesaplamalar
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            
            // Sıfıra bölme kontrolü
            if (sayi2 != 0)
            {
                bolum = sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("Sıfıra bölme hatası!");
                Console.ReadKey();
                return;
            }
            
            // Sonuçları yazdırma
            Console.WriteLine("\n=== SONUÇLAR ===");
            Console.WriteLine($"Toplam: {sayi1} + {sayi2} = {toplam}");
            Console.WriteLine($"Fark: {sayi1} - {sayi2} = {fark}");
            Console.WriteLine($"Çarpım: {sayi1} × {sayi2} = {carpim}");
            Console.WriteLine($"Bölüm: {sayi1} ÷ {sayi2} = {bolum:F2}");
            
            Console.ReadKey();
        }
    }
}
```

### Örnek 3: String İşlemleri
```csharp
using System;

namespace Stringİşlemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = "Merhaba Dünya";
            
            Console.WriteLine($"Orijinal metin: {metin}");
            Console.WriteLine($"Uzunluk: {metin.Length}");
            Console.WriteLine($"Büyük harf: {metin.ToUpper()}");
            Console.WriteLine($"Küçük harf: {metin.ToLower()}");
            Console.WriteLine($"İlk 7 karakter: {metin.Substring(0, 7)}");
            Console.WriteLine($"'Dünya' kelimesi var mı? {metin.Contains("Dünya")}");
            Console.WriteLine($"'Merhaba' yerine 'Selam': {metin.Replace("Merhaba", "Selam")}");
            
            Console.ReadKey();
        }
    }
}
```

## 10. Ders Materyalleri

### Yazılım Gereksinimleri
1. **Visual Studio 2022 Community** (Ücretsiz)
   - İndirme: https://visualstudio.microsoft.com/
   - Workload: .NET desktop development

2. **Alternatif: Visual Studio Code**
   - İndirme: https://code.visualstudio.com/
   - Extension: C# for Visual Studio Code

### Öğrenme Kaynakları
1. **Resmi Dokümantasyon:** docs.microsoft.com/dotnet/csharp/
2. **Interaktif Öğrenim:** learn.microsoft.com/training/
3. **Video Kurslar:** 
   - Microsoft Virtual Academy
   - Plural Sight C# Fundamentals
4. **Kitaplar:**
   - "C# 10 in a Nutshell" - Joseph Albahari
   - "C# Yellow Book" - Rob Miles (Ücretsiz)

### Online Pratik Platformları
1. **LeetCode:** Algoritma problemleri
2. **HackerRank:** C# challenges
3. **Codewars:** Kata challenges
4. **Repl.it:** Online C# compiler

## 11. Yaygın Hatalar ve Çözümleri

### Derleme Hataları
```csharp
// HATA: Büyük/küçük harf yanlışlığı
console.writeline("Merhaba"); // console → Console

// HATA: Noktalı virgül eksik
int a = 5    // Sonuna ; eklenmeli
int b = 10;

// HATA: Süslü parantez eksik
if (a > 5)
    Console.WriteLine("Büyük");
    Console.WriteLine("Bu da çalışır"); // Bu if'e ait değil!

// DOĞRU:
if (a > 5)
{
    Console.WriteLine("Büyük");
    Console.WriteLine("Bu da if'e ait");
}
```

### Çalışma Zamanı Hataları
```csharp
// HATA: Null reference
string isim = null;
int uzunluk = isim.Length; // NULL REFERENCE EXCEPTION!

// ÇÖZÜM: Null kontrol
if (isim != null)
{
    int uzunluk = isim.Length;
}

// HATA: Format exception
string metin = "abc";
int sayı = Convert.ToInt32(metin); // FORMAT EXCEPTION!

// ÇÖZÜM: TryParse kullan
if (int.TryParse(metin, out int sayı))
{
    // Başarılı dönüşüm
}
```

## Değerlendirme

### Lab Çalışması (%100)
- Değişken tanımlama ve kullanımı (25%)
- Tip dönüşümleri (25%)
- Console input/output (25%)
- Program yapısı ve söz dizimi (25%)

## Sonraki Hafta Hazırlığı
- Operatörler (Aritmetik, karşılaştırma, mantıksal)
- Tip dönüşümleri detayları
- String manipülasyonları

## Ödev

### Teorik Ödev (30%)
1. **C# Özellikleri** (200 kelime):
   - C#'ın avantajları ve kullanım alanları
   - Neden C# öğrenmeliyiz?

2. **Veri Türleri Karşılaştırması** (150 kelime):
   - int, double, string arasındaki farklar
   - Hangi durumlarda hangi tür kullanılır?

### Pratik Ödev (70%)

#### Zorunlu Görevler:

1. **Kişisel Bilgi Formu** 
   ```
   Gereken bilgiler:
   - Ad, Soyad (string)
   - Yaş (int)
   - Boy (double - cm)
   - Kilo (double - kg)
   - Öğrenci mi? (bool)
   
   Çıktı:
   - Tüm bilgileri formatlı yazdır
   - VKİ hesapla ve göster (VKİ = kilo / (boy/100)²)
   - Öğrenci durumuna göre mesaj ver
   ```

2. **Gelişmiş Hesap Makinesi**
   ```
   Özellikler:
   - İki sayı al
   - Dört işlem yap (+ - * /)
   - Sıfıra bölme kontrolü
   - Sonuçları güzel formatta göster
   - Kullanıcı TryParse ile güvenli girdi
   ```

3. **String Analiz Programı**
   ```
   Kullanıcıdan bir cümle al ve:
   - Kaç karakter olduğunu söyle
   - Kaç kelime olduğunu bul
   - Büyük ve küçük harf hallerini göster
   - Belirli bir kelime aratması yap
   - İlk ve son 3 karakterini göster
   ```

#### Bonus Görevler:

4. **Yaş Hesaplayıcı**
   ```
   - Doğum tarihi al (gün, ay, yıl ayrı ayrı)
   - Bugünkü tarihe göre yaşı hesapla
   - Kaç gün yaşadığını hesapla
   - Hangi burçta olduğunu söyle
   ```

5. **Basit Menü Sistemi**
   ```
   Menü seçenekleri:
   1. Hesap makinesi
   2. VKİ hesaplama
   3. String analizi
   4. Yaş hesaplama
   5. Çıkış
   
   Kullanıcı seçimi ile ilgili işlemi yap
   ```

### Teslim Formatı
- Visual Studio solution (.sln) dosyası
- Her ödev ayrı proje olarak
- Kodlarda yorum satırları (açıklama)
- README.txt dosyası (nasıl çalıştırılacağı)

### Değerlendirme Kriterleri
- Kod çalışıyor mu? (40%)
- Doğru sonuç veriyor mu? (30%)
- Kod temizliği ve okunabilirlik (20%)
- Hata kontrolü yapılmış mı? (10%)
