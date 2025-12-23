# Hafta 12: Fonksiyonlar ve Diziler

## ÖRNEK 1: Basit Fonksiyon - Selamlama Yazdır

```csharp
void SelamVer()
{
    Console.WriteLine("Merhaba! Hoş geldiniz.");
}
```

**Açıklama:** Parametre almayan ve dönüş değeri olmayan basit bir fonksiyon. Fonksiyon çağrıldığında ekrana bir selamlama mesajı yazdırır.

---

## ÖRNEK 2: Parametre Alan Fonksiyon - Toplama

```csharp
void ToplaDikkat(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine($"{sayi1} + {sayi2} = {sonuc}");
}
```

**Açıklama:** İki parametre alan ve işlem yapıp sonucu ekrana yazdıran fonksiyon. Dönüş değeri yoktur (void).

---

## ÖRNEK 3: Dönüş Değeri Olan Fonksiyon - Çarpma

```csharp
int Carp(int a, int b)
{
    return a * b;
}
```

**Açıklama:** İki parametre alan ve işlemin sonucunu döndüren fonksiyon. `int` tipinde değer döndürür.

---

## ÖRNEK 4: Basit Dizi Deklarasyonu ve İşleme

```csharp
void DiziOrnegi()
{
    int[] sayilar = { 10, 20, 30, 40, 50 };
    
    Console.WriteLine("\nDizi Elemanları:");
    for (int i = 0; i < sayilar.Length; i++)
    {
        Console.WriteLine($"Indeks {i}: {sayilar[i]}");
    }
}
```

**Açıklama:** Bir dizi oluşturur ve `for` döngüsü ile tüm elemanlarını yazdırır. `Length` özelliği dizi boyutunu verir.

---

## ÖRNEK 5: Dizinin Tüm Elemanlarını Toplayan Fonksiyon

```csharp
int DiziToplam(int[] dizi)
{
    int toplam = 0;
    foreach (int sayi in dizi)
    {
        toplam += sayi;
    }
    return toplam;
}
```

**Açıklama:** Bir dizi parametresi alır ve tüm elemanlarını toplar. `foreach` döngüsü kullanarak dizi üzerinde dolaşır. Toplam değeri döndürür.

---

## ÖRNEK 6: Dizideki En Büyük Sayıyı Bulan Fonksiyon

```csharp
int EnBuyukBul(int[] dizi)
{
    int enBuyuk = dizi[0];
    
    for (int i = 1; i < dizi.Length; i++)
    {
        if (dizi[i] > enBuyuk)
        {
            enBuyuk = dizi[i];
        }
    }
    
    return enBuyuk;
}
```

**Açıklama:** Dizideki maksimum değeri bulur. İlk elemanı `enBuyuk` olarak ayarlar, sonra kalanı ile karşılaştırarak en büyüğünü bulur.

---

## ÖRNEK 7: Dizideki En Küçük Sayıyı Bulan Fonksiyon

```csharp
int EnKucukBul(int[] dizi)
{
    int enKucuk = dizi[0];
    
    for (int i = 1; i < dizi.Length; i++)
    {
        if (dizi[i] < enKucuk)
        {
            enKucuk = dizi[i];
        }
    }
    
    return enKucuk;
}
```

**Açıklama:** Dizideki minimum değeri bulur. ÖRNEK 6 ile benzer mantık ama büyüklük karşılaştırması yerine küçüklük karşılaştırması yapar.

---

## ÖRNEK 8: Dizi Elemanlarının Ortalamasını Hesaplayan Fonksiyon

```csharp
double DiziOrtalamasi(int[] dizi)
{
    if (dizi.Length == 0)
        return 0;
    
    int toplam = DiziToplam(dizi);
    return (double)toplam / dizi.Length;
}
```

**Açıklama:** Dizi boş değilse tüm elemanları toplar ve eleman sayısına böler. Type casting `(double)` kullanarak ondalıklı sonuç elde eder.

---

## ÖRNEK 9: İki Diziyi Birleştiren Fonksiyon

```csharp
int[] IkiDiziBirlestir(int[] dizi1, int[] dizi2)
{
    int[] yeniDizi = new int[dizi1.Length + dizi2.Length];
    
    // Birinci dizinin elemanlarını kopyala
    for (int i = 0; i < dizi1.Length; i++)
    {
        yeniDizi[i] = dizi1[i];
    }
    
    // İkinci dizinin elemanlarını kopyala
    for (int i = 0; i < dizi2.Length; i++)
    {
        yeniDizi[dizi1.Length + i] = dizi2[i];
    }
    
    return yeniDizi;
}
```

**Açıklama:** İki diziyi parametre alır ve bunları birleştirerek yeni bir dizi oluşturur. Yeni dizi boyutu her iki dizinin toplamı kadardır.

---

## ÖRNEK 10: Diziyi Tersine Çeviren Fonksiyon

```csharp
void DiziTersineÇevir(int[] dizi)
{
    int solIndex = 0;
    int sagIndex = dizi.Length - 1;
    
    while (solIndex < sagIndex)
    {
        // Swap işlemi
        int temp = dizi[solIndex];
        dizi[solIndex] = dizi[sagIndex];
        dizi[sagIndex] = temp;
        
        solIndex++;
        sagIndex--;
    }
}
```

**Açıklama:** Dizinin başından ve sonundan başlayarak elemanları yer değiştirir (swap). İki pointer (solIndex ve sagIndex) kullanarak ortaya doğru ilerler.

---

## Tüm Kodlar - Main Fonksiyonunda Çalışırken

```csharp
void Main()
{
    Console.WriteLine("===== FONKSİYONLAR VE DİZİLER ÖRNEKLERİ =====\n");

    // ÖRNEK 1: Basit Fonksiyon
    Console.WriteLine("--- ÖRNEK 1: Basit Fonksiyon ---");
    SelamVer();

    // ÖRNEK 2: Parametre Alan Fonksiyon
    Console.WriteLine("\n--- ÖRNEK 2: Parametre Alan Fonksiyon ---");
    ToplaDikkat(15, 25);

    // ÖRNEK 3: Dönüş Değeri Olan Fonksiyon
    Console.WriteLine("\n--- ÖRNEK 3: Dönüş Değeri Olan Fonksiyon ---");
    int carpimSonucu = Carp(7, 6);
    Console.WriteLine($"7 × 6 = {carpimSonucu}");

    // ÖRNEK 4: Basit Dizi
    Console.WriteLine("\n--- ÖRNEK 4: Basit Dizi ---");
    DiziOrnegi();

    // ÖRNEK 5: Dizi Toplama
    Console.WriteLine("\n--- ÖRNEK 5: Dizi Toplama Fonksiyonu ---");
    int[] sayilar1 = { 5, 10, 15, 20, 25 };
    int toplam = DiziToplam(sayilar1);
    Console.WriteLine($"Dizi: [{string.Join(", ", sayilar1)}]");
    Console.WriteLine($"Toplam: {toplam}");

    // ÖRNEK 6: En Büyük Sayı
    Console.WriteLine("\n--- ÖRNEK 6: En Büyük Sayıyı Bulma ---");
    int[] sayilar2 = { 45, 23, 89, 12, 67 };
    int enBuyuk = EnBuyukBul(sayilar2);
    Console.WriteLine($"Dizi: [{string.Join(", ", sayilar2)}]");
    Console.WriteLine($"En Büyük: {enBuyuk}");

    // ÖRNEK 7: En Küçük Sayı
    Console.WriteLine("\n--- ÖRNEK 7: En Küçük Sayıyı Bulma ---");
    int enKucuk = EnKucukBul(sayilar2);
    Console.WriteLine($"Dizi: [{string.Join(", ", sayilar2)}]");
    Console.WriteLine($"En Küçük: {enKucuk}");

    // ÖRNEK 8: Ortalama Hesaplama
    Console.WriteLine("\n--- ÖRNEK 8: Dizi Ortalaması ---");
    int[] sayilar3 = { 10, 20, 30, 40, 50 };
    double ortalama = DiziOrtalamasi(sayilar3);
    Console.WriteLine($"Dizi: [{string.Join(", ", sayilar3)}]");
    Console.WriteLine($"Ortalama: {ortalama}");

    // ÖRNEK 9: İki Diziyi Birleştirme
    Console.WriteLine("\n--- ÖRNEK 9: İki Diziyi Birleştirme ---");
    int[] dizi1 = { 1, 2, 3 };
    int[] dizi2 = { 4, 5, 6 };
    int[] birlesikDizi = IkiDiziBirlestir(dizi1, dizi2);
    Console.WriteLine($"Dizi 1: [{string.Join(", ", dizi1)}]");
    Console.WriteLine($"Dizi 2: [{string.Join(", ", dizi2)}]");
    Console.WriteLine($"Birleşik Dizi: [{string.Join(", ", birlesikDizi)}]");

    // ÖRNEK 10: Diziyi Tersine Çevirme
    Console.WriteLine("\n--- ÖRNEK 10: Diziyi Tersine Çevirme ---");
    int[] sayilar4 = { 1, 2, 3, 4, 5 };
    Console.WriteLine($"Orijinal Dizi: [{string.Join(", ", sayilar4)}]");
    DiziTersineÇevir(sayilar4);
    Console.WriteLine($"Tersine Çevrilmiş: [{string.Join(", ", sayilar4)}]");

    Console.WriteLine("\n===== PROGRAM SONA ERDİ =====");
}
```

---

## Özet

| Örnek | Konu | Anahtar Noktalar |
|-------|------|------------------|
| 1 | Basit Fonksiyon | `void`, parametre yok |
| 2 | Parametreli Fonksiyon | İki parametre, void döndürüm |
| 3 | Dönüş Değeri | `return` ifadesi, int döndürüm |
| 4 | Dizi Deklarasyonu | `for` döngüsü, `.Length` |
| 5 | Dizi Toplama | `foreach` döngüsü, biriktirme |
| 6 | Maksimum Bulma | Karşılaştırma operatörü `>` |
| 7 | Minimum Bulma | Karşılaştırma operatörü `<` |
| 8 | Ortalama | Type casting `(double)` |
| 9 | Dizi Birleştirme | Yeni dizi oluşturma, kopyalama |
| 10 | Ters Çevirme | Swap işlemi, two-pointer tekniği |
