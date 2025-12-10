# Hafta 10: Dizi örnekleri

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

### 10) Dizide belirlenen aralıkta kaç adet sayı var ? Alt sınır ve üst sınır kullanıcı tarafından girilecektir.
```csharp
int[] d = { 1, 2, 3, 4, 9, 20, 22, 25 };
int adet = 0;
Console.WriteLine("Lütfen alt sınırı giriniz:");
int alt =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen üst sınırı giriniz:");
int ust = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < d.Length; i++)
{
    if (d[i] >= alt && d[i] <= ust)
    {
        adet++;
    }
}
Console.WriteLine(adet);
```
### 11) Dizide bölünme kuralına göre kaç adet sayı var ? Bu problem 7 ile bölünmeye göre kontrol yapar.

```csharp
int[] a = { 1, 2, 3, 4, 9, 20, 22, 25 };
int adet=0;
for (int i = 0; i < a.Length; i++)
{
	if(a[i]%7==0) adet++;
}
Console.WriteLine(adet);
```

### 12) Diziyi Tersden Yazdırma
```csharp
int[] d = { 1, 2, 3, 4,9,9,10,57,9 };
for (int i = d.Length - 1; i >= 0; i--)
	Console.WriteLine(d[i]);
```
