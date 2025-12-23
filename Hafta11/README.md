# Hafta 11: Fonksiyonlar

## Fonksiyonlar (Metotlar) Nedir?
Fonksiyonlar (veya metotlar), belirli bir görevi yerine getiren, tekrar kullanılabilir kod bloklarıdır. Kodunuzu daha düzenli, okunabilir ve bakımı kolay hale getirir.

---

## Temel Fonksiyon Söz Dizimi

```csharp
<dönüş_tipi> <fonksiyon_adı>(<parametreler>)
{
	// Fonksiyonun gövdesi
	// Gerekirse return ile değer döndürülür
}
```

---

## Fonksiyon Tanımlama Kuralları
- Fonksiyon adı harf veya alt çizgi ile başlamalıdır.
- Parametreler parantez içinde tanımlanmalıdır.
- Dönüş tipi belirtmek zorunludur (`void` ise değer döndürmez).
- Fonksiyon gövdesi `{}` ile çevrilidir.

---

## Dönüş Tipleri
- `void`: Değer döndürmez.
- `int`, `double`, `string`, `bool` gibi temel tipler veya kendi tanımladığınız tipler olabilir.

---

## Parametreler
- Fonksiyonlara dışarıdan veri göndermek için kullanılır.
- Birden fazla parametre virgül ile ayrılır.

---

## C# Fonksiyon Örnekleri

### 1. Parametresiz ve Değersiz Fonksiyon
```csharp
void Selamla()
{
	Console.WriteLine("Merhaba!");
}
```

### 2. Parametreli ve Değersiz Fonksiyon
```csharp
void Yazdir(string mesaj)
{
	Console.WriteLine(mesaj);
}
```

### 3. Parametresiz ve Değer Döndüren Fonksiyon
```csharp
int GetirSayi()
{
	return 42;
}
```

### 4. Parametreli ve Değer Döndüren Fonksiyon

**Matematiksel Gösterim:** $f(x) = x + 1$

```csharp
// int tipinde parametre alan ve int değerini
// dönderen f adında bir fonksiyon.
int f(int x){
    return x + 1;
}

//Değer dönderdiği için atama yapılabilir.
int y=f(3) + f(4); // 4+5
```

### 4.1. Parametreli ve Değer Döndüren Fonksiyon

**Matematiksel Gösterim:** $Topla(a, b) = a + b$

```csharp
int Topla(int a, int b)
{
	return a + b;
}
```

### 5. Bir Sayının Karesini Döndüren Fonksiyon

**Matematiksel Gösterim:** $Kare(x) = x^2$

```csharp
int Kare(int x)
{
	return x * x;
}
```

### 6. Bir Sayının Tek mi Çift mi Olduğunu Döndüren Fonksiyon
```csharp
bool TekMi(int n)
{
	return n % 2 != 0;
}
```

### 7. Dizi Elemanlarının Toplamını Döndüren Fonksiyon
```csharp
int DiziToplam(int[] dizi)
{
	int toplam = 0;
	for (int i = 0; i < dizi.Length; i++)
		toplam += dizi[i];
	return toplam;
}
```

### 8. String Birleştiren Fonksiyon
```csharp
string Birleştir(string a, string b)
{
	return a + b;
}
```

### 9. Maksimum Bulan Fonksiyon
```csharp
int Maksimum(int a, int b)
{
	return (a > b) ? a : b;
}
```

### 10. Faktöriyel Hesaplayan Fonksiyon
```csharp
int Faktoriyel(int n)
{
	int sonuc = 1;
	for (int i = 1; i <= n; i++)
		sonuc *= i;
	return sonuc;
}
```

### 11. Fibonacci Serisi Fonksiyonu
```csharp
int[] FibonacciSerisi(int n)
{
	//n elemanlı bir tam sayı dizi oluşturur.
	int[] dizi = new int[n];
	
	for (int i = 0; i < n; i++)
	{
		if (i <= 1)
			dizi[i] = i;
		else
			dizi[i] = dizi[i - 1] + dizi[i - 2];
	}
	
	return dizi;
}

// Kullanım örneği:
// int[] fibSeri = FibonacciSerisi(10);
// Çıktı: [0, 1, 1, 2, 3, 5, 8, 13, 21, 34]
```

**Özyinelemeli Versiyon:**
```csharp
int FibonacciTek(int n)
{
	if (n <= 1) return n;
	return FibonacciTek(n - 1) + FibonacciTek(n - 2);
}

// Bu fonksiyon sadece n. Fibonacci sayısını döndürür
// Örnek: FibonacciTek(7) → 13
```

### 12. Varsayılan Parametreli Fonksiyon
```csharp
void MesajYaz(string mesaj = "Varsayılan mesaj")
{
	Console.WriteLine(mesaj);
}
```

---

## Fonksiyon Kullanımı
Fonksiyonlar, ana programda çağrılarak kullanılır:
```csharp
int sonuc = Topla(3, 5);
Console.WriteLine(sonuc); // 8
```

---

## Notlar
- Fonksiyonlar kod tekrarını önler.
- Karmaşık işlemleri küçük parçalara böler.
- Okunabilirliği ve bakımı artırır.

---

## Fonksiyonlar ile İlgili Sıkça Yapılan Hatalar

| Hata Açıklaması | Örnek |
|-----------------|-------|
| Fonksiyonun dönüş tipini belirtmemek | `Topla(int a, int b) { return a + b; }` (yanlış) <br> `int Topla(int a, int b) { return a + b; }` (doğru) |
| Fonksiyon gövdesini `{}` ile yazmamak | `int Topla(int a, int b) return a + b;` (yanlış) |
| Parametre tiplerini yazmamak | `int Topla(a, b) { ... }` (yanlış) <br> `int Topla(int a, int b) { ... }` (doğru) |
| Fonksiyon çağrısında parametre sayısı veya tipi ile tanımın uyuşmaması | `Topla(3);` (yanlış) <br> `Topla(3, 5);` (doğru) |
| return ifadesini dönüş tipi gerektiriyorsa kullanmamak | `int Kare(int x) { x * x; }` (yanlış) <br> `int Kare(int x) { return x * x; }` (doğru) |
| void fonksiyonda return ile değer döndürmek | `void Selamla() { return "Merhaba"; }` (yanlış) |
| Fonksiyon içinde tanımlanan değişkeni dışarıda kullanmak | `void F() { int x = 5; } ... Console.WriteLine(x);` (yanlış) |
| Fonksiyon isimlerinde Türkçe karakter veya boşluk kullanmak | `void sayı topla() { ... }` (yanlış) |
| Fonksiyonları tanımlamadan önce çağırmak (bazı dillerde hata) | `Yazdir(); void Yazdir() { ... }` (C#'ta genellikle sorun olmaz, ama önerilmez) |
| Erişim belirleyicisini unutmak (sınıf içinde) | `int Topla(int a, int b) { ... }` <br> `public int Topla(int a, int b) { ... }` (doğru) |
| Overload hatası (aynı isimde fonksiyon, farklı imza beklenirken çakışma) | `int F(int x) { ... }` <br> `int F(int y) { ... }` (yanlış, parametre tipi/farkı olmalı) |
