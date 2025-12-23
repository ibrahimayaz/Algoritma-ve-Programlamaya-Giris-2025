# Hafta 13: Özyinelemeli (Recursive) Fonksiyonlar

--- 

## Teorik Bilgi: Özyineleme Nedir?

**Özyineleme (Recursion)**, bir fonksiyonun kendisini çağırmasıdır. Büyük bir sorunu daha küçük alt problemlere bölerek çözmek için kullanılır.

### Özyinelemeli Fonksiyonun Temel Bileşenleri:

1. **Taban Durum (Base Case)**: Özyinelemeyi sonlandıran koşul. Aksi takdirde sonsuz döngü oluşur.
2. **Özyinelemeli Adım (Recursive Case)**: Fonksiyonun kendisini daha küçük bir giriş ile çağırması.

### Özyineleme Nasıl Çalışır?

```
Problemi çöz:
├─ Problemi daha küçük hallerle çöz
│  ├─ Daha da küçük hallerle çöz
│  │  ├─ Daha da küçük hallerle çöz
│  │  └─ Taban duruma ulaş ✓
│  └─ Sonuç geri döndür
└─ Tüm sonuçları birleştir
```

### Avantajlar:
- Karmaşık problemleri basit hale indirir
- Kod daha kısa ve okunması daha kolay olabilir
- Ağaç yapılı veriler (dosya sistemleri, XML) ile ideal

### Dezavantajlar:
- Bellek tüketimi fazla olabilir (çağrı yığını)
- Yavaş olabilir (tekrarlanan hesaplamalar)
- Maksimum derinlik sınırı vardır

---

## ÖRNEK 1: Faktöriyel Hesaplama

```csharp
static int Faktoriyel(int n)
{
    // Taban durum
    if (n == 0 || n == 1)
    {
        return 1;
    }
    
    // Özyinelemeli adım
    return n * Faktoriyel(n - 1);
}
```

**Açıklama:** 
- `5! = 5 × 4 × 3 × 2 × 1 = 120`
- Taban durum: `0! = 1` veya `1! = 1`
- Özyinelemeli: `5! = 5 × Faktoriyel(4)`

**Çağrı Yığını:**
```
Faktoriyel(5)
  → 5 * Faktoriyel(4)
    → 4 * Faktoriyel(3)
      → 3 * Faktoriyel(2)
        → 2 * Faktoriyel(1)
          → 1 (Taban durum)
```

**Test:**
```csharp
Console.WriteLine(Faktoriyel(5));  // Çıktı: 120
```

---

## ÖRNEK 2: Fibonacci Dizisi

```csharp
static int Fibonacci(int n)
{
    // Taban durumlar
    if (n <= 1)
    {
        return n;
    }
    
    // Özyinelemeli adım
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}
```

**Açıklama:**
- Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, ...
- Her sayı, kendinden önceki iki sayının toplamıdır
- Taban durum: `Fib(0) = 0`, `Fib(1) = 1`

**Test:**
```csharp
Console.WriteLine(Fibonacci(6));  // Çıktı: 8
Console.WriteLine(Fibonacci(7));  // Çıktı: 13
```

---

## ÖRNEK 3: Basit Sayma (Geriye Doğru)

```csharp
static void GeriyeSay(int n)
{
    // Taban durum
    if (n == 0)
    {
        return;
    }
    
    // Başında yaz
    Console.WriteLine(n);
    
    // Özyinelemeli adım
    GeriyeSay(n - 1);
}
```

**Açıklama:**
- 5'ten başlayarak 1'e kadar geriye sayar
- Her çağrıda n bir azalır
- `n = 0` olunca fonksiyon durur

**Test:**
```csharp
GeriyeSay(5);
// Çıktı:
// 5
// 4
// 3
// 2
// 1
```

---

## ÖRNEK 4: Dizi Elemanlarının Toplamı (Özyinelemeli)

```csharp
static int DiziToplamRekursif(int[] dizi, int indeks)
{
    // Taban durum: dizi sonuna ulaştık
    if (indeks == dizi.Length)
    {
        return 0;
    }
    
    // Özyinelemeli adım: şu anki eleman + kalanın toplamı
    return dizi[indeks] + DiziToplamRekursif(dizi, indeks + 1);
}
```

**Açıklama:**
- Dizi: `[1, 2, 3, 4, 5]`
- Mantık: `1 + (2 + (3 + (4 + (5 + 0))))`
- Her özyinelemede bir sonraki indekse geçilir

**Test:**
```csharp
int[] sayilar = { 1, 2, 3, 4, 5 };
Console.WriteLine(DiziToplamRekursif(sayilar, 0));  // Çıktı: 15
```

---

## ÖRNEK 5: Güç Hesaplama (a^b)

```csharp
static int Guc(int taban, int us)
{
    // Taban durum
    if (us == 0)
    {
        return 1;
    }
    
    // Taban durum 2
    if (us == 1)
    {
        return taban;
    }
    
    // Özyinelemeli adım
    return taban * Guc(taban, us - 1);
}
```

**Açıklama:**
- `2^5 = 2 × 2 × 2 × 2 × 2 = 32`
- Taban durum: `a^0 = 1` ve `a^1 = a`
- Özyinelemeli: `a^n = a × a^(n-1)`

**Test:**
```csharp
Console.WriteLine(Guc(2, 5));   // Çıktı: 32
Console.WriteLine(Guc(3, 4));   // Çıktı: 81
```

---

## Tüm Özyinelemeli Örnekler - Main Fonksiyonunda Çalışırken

```csharp
static void Main()
{
    Console.WriteLine("===== ÖZYİNELEMELİ FONKSİYONLAR ÖRNEKLERİ =====\n");

    // ÖRNEK 1: Faktöriyel
    Console.WriteLine("--- ÖRNEK 1: Faktöriyel ---");
    Console.WriteLine($"5! = {Faktoriyel(5)}");
    Console.WriteLine($"6! = {Faktoriyel(6)}");

    // ÖRNEK 2: Fibonacci
    Console.WriteLine("\n--- ÖRNEK 2: Fibonacci Dizisi ---");
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
    }

    // ÖRNEK 3: Geriye Sayma
    Console.WriteLine("\n--- ÖRNEK 3: Geriye Sayma ---");
    GeriyeSay(5);

    // ÖRNEK 4: Dizi Toplamı (Özyinelemeli)
    Console.WriteLine("\n--- ÖRNEK 4: Dizi Toplamı (Özyinelemeli) ---");
    int[] sayilar = { 10, 20, 30, 40, 50 };
    Console.WriteLine($"Dizi: [{string.Join(", ", sayilar)}]");
    Console.WriteLine($"Toplam: {DiziToplamRekursif(sayilar, 0)}");

    // ÖRNEK 5: Güç Hesaplama
    Console.WriteLine("\n--- ÖRNEK 5: Güç Hesaplama ---");
    Console.WriteLine($"2^5 = {Guc(2, 5)}");
    Console.WriteLine($"3^4 = {Guc(3, 4)}");
    Console.WriteLine($"10^3 = {Guc(10, 3)}");

    Console.WriteLine("\n===== PROGRAM SONA ERDİ =====");
}
```

---

## Özyineleme vs İterasyon Karşılaştırması

| Özellik | Özyineleme | İterasyon (Loop) |
|---------|-----------|------------------|
| Kod Uzunluğu | Kısa ve Temiz | Biraz Daha Uzun |
| Bellek Kullanımı | Fazla (çağrı yığını) | Az |
| Hız | Yavaş (ek çağrı maliyeti) | Hızlı |
| Okunabilirlik | Bazı durumlarda daha iyi | Basit ve açık |
| Sonsuz Döngü Riski | Stack Overflow | Dikkatli yazılırsa yok |
| İdeal Kullanım | Ağaç yapıları, böl-ve-yönet | Basit tekrar işlemleri |

**Örnek: Faktöriyel (İteratif Versiyonu)**
```csharp
static int FaktoriyelIteratif(int n)
{
    int sonuc = 1;
    for (int i = 2; i <= n; i++)
    {
        sonuc *= i;
    }
    return sonuc;
}
```