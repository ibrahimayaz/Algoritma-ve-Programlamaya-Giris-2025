
## Dizilere Giriş — Ders Dokümanı

Bu bölümde C# dilinde dizilerle ilgili temel kavramlar ve örnekler gösterilmektedir. Kodlar `Hafta09/OrnekKodlar/DizilereGiris` projesi referans alınarak hazırlanmıştır. 

---





### 1) Dizi Tanımlama ve Başlatma (Her Tipten)
```csharp
int[] sayilar = { 1, 2, 3, 4, 5 };
double[] oranlar = { 1.5, 2.7, 3.14 };
string[] isimler = { "Ali", "Ayşe", "Mehmet" };
char[] karakterler = { 'a', 'b', 'c' };
object[] nesneler = { 1, "metin", 3.14, true };
dynamic[] dinamikler = { 42, "merhaba", 2.5, false };
```

**object ve dynamic farkı:**
- `object[]` dizisi her türden veri tutabilir, ancak elemanlara erişirken tür dönüşümü (cast) gerekir. Derleme zamanında tür kontrolü yapılır.
- `dynamic[]` dizisi de her türden veri tutabilir, ancak elemanlara erişirken tür dönüşümü gerekmez. Derleyici tür kontrolü yapmaz, hata varsa çalışma zamanında ortaya çıkar.

Kısaca: `object` daha güvenli ve tip dönüşümü gerektirir, `dynamic` daha esnek ama çalışma zamanında hata riski vardır.

### 2) Diziye Eleman Erişimi
```csharp
int[] dizi = { 10, 20, 30, 40, 50 };
Console.WriteLine(dizi[0]); // 10
Console.WriteLine(dizi[4]); // 50
```

### 3) Dizi Elemanını Değiştirme
```csharp
int[] d = { 5, 6, 7 };
d[2] = 99;
Console.WriteLine(d[2]); // 99
```

### 4) Dizi Uzunluğunu Bulma
```csharp
int[] d = { 1, 2, 3, 4, 5 };
Console.WriteLine(d.Length); // 5
```

### 5) Dizi Elemanlarını For ile Yazdırma
```csharp
int[] d = { 7, 8, 9 };
for (int i = 0; i < d.Length; i++)
	Console.WriteLine(d[i]);
```

### 6) Dizi Elemanlarının Toplamını Bulma
```csharp
int[] d = { 2, 4, 6, 8 };
int toplam = 0;
for (int i = 0; i < d.Length; i++)
	toplam += d[i];
Console.WriteLine(toplam);
```

### 7) Dizi Elemanlarının Ortalamasını Bulma
```csharp
int[] d = { 3, 6, 9 };
int toplam = 0;
for (int i = 0; i < d.Length; i++)
	toplam += d[i];
double ort = (double)toplam / d.Length;
Console.WriteLine(ort);
```

### 8) Dizide En Büyük ve En Küçük Elemanı Bulma
```csharp
int[] d = { 11, 22, 5, 44 };
int enBuyuk = d[0];
int enKucuk = d[0];
for (int i = 1; i < d.Length; i++)
{
	if (d[i] > enBuyuk) enBuyuk = d[i];
	if (d[i] < enKucuk) enKucuk = d[i];
}
Console.WriteLine($"En büyük: {enBuyuk}, En küçük: {enKucuk}");
```

### 9) Dizide Belirli Bir Elemanın Kaç Kere Geçtiğini Bulma
```csharp
int[] d = { 2, 3, 2, 5, 2 };
int aranan = 2;
int adet = 0;
for (int i = 0; i < d.Length; i++)
	if (d[i] == aranan) adet++;
Console.WriteLine($"{aranan} sayısı {adet} kez geçiyor.");
```

### 10) Diziyi Ters Çevirme
```csharp
int[] d = { 1, 2, 3, 4 };
for (int i = d.Length - 1; i >= 0; i--)
	Console.WriteLine(d[i]);
```
### 11) Dizide belirlenen aralıkta kaç adet sayı var ?
```csharp
int[] d = { 1, 2, 3, 4, 9, 20, 22, 25 };
int adet=0;
int alt=5;
int ust=23;
for (int i = 0; i < d.Length; i++)
{
	if(d[i]>=alt && d[i]<=ust){
		adet++;
	}
}
Console.WriteLine(adet);
```
### 12) Dizide bölünme kuralına göre kaç adet sayı var ?
```csharp
int[] a = { 1, 2, 3, 4, 9, 20, 22, 25 };
int adet=0;
for (int i = 0; i < a.Length; i++)
{
	if(a[i]%7==0){
		adet++;
	}
}
Console.WriteLine(adet);
```
---

Ekstra örnekler ve açıklamalar için `OrnekKodlar/DizilereGiris` projesindeki kodları inceleyebilirsiniz. Her örneği ayrı bir `Main` içinde çalıştırarak pratik yapabilirsiniz.


---

## Sıkça Yapılan Hatalar

- **Dizi sınırını aşmak:**
	```csharp
	int[] d = { 1, 2, 3 };
	Console.WriteLine(d[3]); // HATA! Geçerli indexler: 0,1,2
	```
- **Yanlış tipte değer atamak:**
	```csharp
	int[] d = { 1, 2, 3 };
	// d[0] = "metin"; // HATA! int dizisine string atanamaz
	```
- **Diziyi tanımlamadan kullanmak:**
	```csharp
	int[] d;
	// Console.WriteLine(d[0]); // HATA! dizi başlatılmadı
	```
- **object/dynamic dizilerde tip hatası:**
	```csharp
	object[] o = { 1, "abc" };
	int x = (int)o[1]; // HATA! string'i int'e çeviremez
	dynamic[] dy = { 1, "abc" };
	int y = dy[1]; // HATA! Çalışma zamanında hata verir
	```
- **Dizinin boyutunu değiştirmeye çalışmak:**
	```csharp
	int[] d = { 1, 2, 3 };
	// d.Length = 10; // HATA! Dizi boyutu değiştirilemez
	```
- **For döngüsünde yanlış sınır:**
	```csharp
	int[] d = { 1, 2, 3 };
	for (int i = 0; i <= d.Length; i++) // HATA! Son index d.Length-1 olmalı
			Console.WriteLine(d[i]);
	```

Bu hatalara dikkat ederek kod yazmak, dizi işlemlerinde hata riskini azaltır.

