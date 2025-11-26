## Döngüler

Programlamada döngüler, belirli bir işlemin birden fazla kez tekrarlanmasını sağlar. C# dilinde en çok kullanılan döngü türleri şunlardır:

### 1. for Döngüsü
Belirli bir sayıda tekrarlamak için kullanılır.
```csharp
for (int i = 0; i < 5; i++)
{
	Console.WriteLine(i);
}
```

### 2. while Döngüsü
Koşul doğru olduğu sürece çalışır.
```csharp
int i = 0;
while (i < 5)
{
	Console.WriteLine(i);
	i++;
}
```

### 3. do-while Döngüsü
En az bir kez çalışır, sonra koşulu kontrol eder.
```csharp
int i = 0;
do
{
	Console.WriteLine(i);
	i++;
} while (i < 5);
```

### 4. foreach Döngüsü
Diziler ve koleksiyonlar üzerinde gezinmek için kullanılır.
```csharp
int[] sayilar = {1, 2, 3, 4, 5};
foreach (int sayi in sayilar)
{
	Console.WriteLine(sayi);
}
```

---

## İç İçe Döngüler

Bir döngü bloğu içinde başka bir döngü kullanılabilir. Buna iç içe döngü denir.
```csharp
for (int i = 1; i <= 3; i++)
{
	for (int j = 1; j <= 2; j++)
	{
		Console.WriteLine($"i={i}, j={j}");
	}
}
```

## Basit Döngü Örnekleri

1. 1'den 10'a kadar sayıları yazdırma:
```csharp
for (int i = 1; i <= 10; i++)
	Console.WriteLine(i);
```

2. 0'dan 9'a kadar çift sayıları yazdırma:
```csharp
for (int i = 0; i < 10; i += 2)
	Console.WriteLine(i);
```

3. 5 defa "Merhaba" yazdırma:
```csharp
int i = 0;
while (i < 5)
{
	Console.WriteLine("Merhaba");
	i++;
}
```

4. 1'den 5'e kadar olan sayıların toplamını bulma:
```csharp
int toplam = 0;
for (int i = 1; i <= 5; i++)
	toplam += i;
Console.WriteLine(toplam);
```

5. Bir dizideki elemanları yazdırma:
```csharp
string[] isimler = {"Ali", "Ayşe", "Mehmet"};
foreach (string isim in isimler)
	Console.WriteLine(isim);
```

6. 1'den 10'a kadar tek sayıları yazdırma:
```csharp
for (int i = 1; i <= 10; i += 2)
	Console.WriteLine(i);
```

7. Kullanıcıdan 5 sayı alıp ekrana yazdırma:
```csharp
for (int i = 0; i < 5; i++)
{
	Console.Write("Sayı girin: ");
	int sayi = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine($"Girdiğiniz sayı: {sayi}");
}
```

8. 1'den 5'e kadar olan sayıların karesini yazdırma:
```csharp
for (int i = 1; i <= 5; i++)
	Console.WriteLine(i * i);
```

9. 10'dan 1'e geri sayım:
```csharp
for (int i = 10; i >= 1; i--)
	Console.WriteLine(i);
```

10. İç içe döngü ile çarpım tablosu:
```csharp
for (int i = 1; i <= 3; i++)
{
	for (int j = 1; j <= 3; j++)
		Console.WriteLine($"{i} x {j} = {i * j}");
}
```
### İç İçe Döngü Basit Örnekleri

1. Yıldızlardan dikdörtgen oluşturma:
```csharp
for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 5; j++)
		Console.Write("*");
	Console.WriteLine();
}
```

2. 1 ile 20 arasındaki asal sayıları bulma:
```csharp
// 1 ile 20 arasındaki asal sayıları bulma
for (int sayi = 2; sayi <= 20; sayi++)
{
	bool asal = true;
	for (int bolen = 2; bolen < sayi; bolen++)
	{
		if (sayi % bolen == 0)
		{
			asal = false;
			break;
		}
	}
	if (asal)
		Console.WriteLine($"Asal sayı: {sayi}");
}
```

3. Satır ve sütun numaralarını yazdırma:
```csharp
for (int satir = 1; satir <= 2; satir++)
{
	for (int sutun = 1; sutun <= 4; sutun++)
		Console.WriteLine($"Satır: {satir}, Sütun: {sutun}");
}
```

4. Üçgen desen oluşturma:
```csharp
for (int i = 1; i <= 5; i++)
{
	for (int j = 1; j <= i; j++)
		Console.Write("*");
	Console.WriteLine();
}
```

5. Dizi içindeki elemanları ve indislerini yazdırma:
```csharp
string[] isimler = {"Ali", "Ayşe", "Mehmet"};
for (int i = 0; i < isimler.Length; i++)
{
	for (int j = 0; j < isimler[i].Length; j++)
		Console.WriteLine($"{isimler[i]}[{j}] = {isimler[i][j]}");
}
```
## Sıkça Yapılan Hatalar ve Örnekleri

1. **Sonsuz döngü oluşturmak**
```csharp
int i = 0;
while (i < 5)
{
	Console.WriteLine(i);
	// i++ unutulursa sonsuz döngü olur
}
```

2. **Dizinin sınırlarını aşmak**
```csharp
int[] dizi = {1,2,3};
for (int i = 0; i <= dizi.Length; i++) // Hatalı: <= olursa hata verir
{
	Console.WriteLine(dizi[i]); // dizi[3] hatalı
}
```

3. **Koşulun yanlış yazılması**
```csharp
for (int i = 10; i > 0; i++) // Hatalı: i artıyor, asla bitmez
{
	Console.WriteLine(i);
}
```

4. **break ve continue komutlarının yanlış kullanımı**
```csharp
for (int i = 0; i < 5; i++)
{
	if (i == 2)
		break; // Döngü 2'de tamamen biter
	Console.WriteLine(i);
}
```

5. **Döngü gövdesini süslü parantez olmadan yazmak**
```csharp
for (int i = 0; i < 5; i++)
	Console.WriteLine(i);
	Console.WriteLine("Bitti"); // Sadece ilk satır döngüye dahil olur
```

6. **İç içe döngülerde değişken karışıklığı**
```csharp
for (int i = 0; i < 3; i++)
{
	for (int i = 0; i < 2; i++) // Aynı isimde değişken kullanmak hatalıdır
	{
		Console.WriteLine(i);
	}
}
```
