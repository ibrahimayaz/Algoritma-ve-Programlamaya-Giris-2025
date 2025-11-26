## Diziler (Array) — 7 Native + 3 for Örneği (Hepsi Basit)

Bu doküman isteğe göre 7 adet "native" (sabit boyutlu) dizi örneği ve 3 adet `for` ile yapılan dizi örneğini içerir. Tüm örnekler en basit biçimde, özel (kullanıcı tanımlı) fonksiyonlar kullanılmadan, doğrudan `Main` içinde verilmiştir.

---

## Native diziler — 7 basit örnek

### 1) Dizi tanımlama (başlatma ile)

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] d = { 1, 2, 3 }; // hem tanımlama hem başlatma
        Console.WriteLine(d[0]); // 1
    }
}
```

### 2) Dizi tanımlama (boyut verip sonra atama)

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] d = new int[4]; // 4 elemanlı, varsayılan 0
        d[0] = 10;
        d[3] = 40;
        Console.WriteLine(d[3]); // 40
    }
}
```

### 3) Diziye erişme (index ile okuma/yazma)

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] d = { 5, 6, 7 };
        int x = d[1]; // x = 6
        d[1] = 60;    // değeri değiştir
        Console.WriteLine(x + ", " + d[1]); // 6, 60
    }
}
```

### 4) Dizi uzunluğu ve son elemana erişim

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] d = { 9, 8, 7, 6 };
        Console.WriteLine("Uzunluk: " + d.Length); // 4
        Console.WriteLine("Son: " + d[d.Length - 1]); // 6
    }
}
```

### 5) Tüm elemanları kopyalama (ekleme için hazırlık)

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3 };
        int[] b = new int[a.Length + 1]; // bir eleman fazla
        for (int i = 0; i < a.Length; i++) b[i] = a[i];
        b[b.Length - 1] = 4; // ekleme
        Console.WriteLine("b[3] = " + b[3]); // 4
    }
}
```

### 6) Araya eklemenin (sağa kaydırma) temel mantığı

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 10, 20, 30 };
        int index = 1; // 20 ile 30 arasına ekle
        int value = 15;
        int[] b = new int[a.Length + 1];
        for (int i = 0; i < index; i++) b[i] = a[i];
        b[index] = value;
        for (int i = index; i < a.Length; i++) b[i + 1] = a[i];
        for (int i = 0; i < b.Length; i++) Console.Write(b[i] + " ");
        // Çıktı: 10 15 20 30
    }
}
```

### 7) Değer silme (ilk bulduğunu kaldırma, kopyalama ile)

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 2, 3, 4, 3 };
        int valueToRemove = 3;
        int found = -1;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == valueToRemove) { found = i; break; }
        }
        if (found == -1) { Console.WriteLine("Bulunamadı"); return; }
        int[] b = new int[a.Length - 1];
        for (int i = 0; i < found; i++) b[i] = a[i];
        for (int i = found + 1; i < a.Length; i++) b[i - 1] = a[i];
        for (int i = 0; i < b.Length; i++) Console.Write(b[i] + " ");
        // Çıktı: 2 4 3
    }
}
```

---

## Dizi + for döngüsü — 3 basit örnek

Bu üç örnek `for` döngüsünü vurgular: iterasyon, toplam/ortalama, min/max.

### 8) For ile tüm elemanları yazdırma

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 4, 9, 16 };
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
```

### 9) For ile toplama ve ortalama

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 2, 4, 6 };
        int sum = 0;
        for (int i = 0; i < a.Length; i++) sum += a[i];
        Console.WriteLine("Toplam: " + sum);
        Console.WriteLine("Ortalama: " + (double)sum / a.Length);
    }
}
```

### 10) For ile min ve max bulma

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 7, 2, 9, 5 };
        int min = a[0];
        int max = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < min) min = a[i];
            if (a[i] > max) max = a[i];
        }
        Console.WriteLine("Min: " + min + ", Max: " + max);
    }
}
```

---

Kısa notlar:
- "Native" diziler sabit boyutludur; ekleme/silme yapmak için yeni dizi oluşturup kopyalama gerekir (örneklerde gösterildi).
- Tüm örnekler en basit haliyle, doğrudan `Main` içinde verilmiştir.

Nasıl denerim:
- Her örneği ayrı bir `Program.cs` dosyasına yapıştırıp `dotnet run` ile çalıştırabilirsiniz.
## Diziler (Array) — 10 Basit Örnek (Özel fonksiyon kullanmadan)

Aşağıda dizilerle ilgili en temel düzeyde 10 örnek sunulmuştur. Her örnek tek bir `Main` içinde, açık ve basit şekilde `for` döngüleri kullanılarak gösterilmiştir. "Özel fonksiyon kullanma" isteğine uygun olarak tüm kodlar doğrudan ana blok içinde yapılmıştır.

---

### Örnek 1 — Dizi tanımlama ve yazdırma

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
```

---

### Örnek 2 — Toplam ve ortalama

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 3, 7, 1, 9, 5 };
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        double avg = (double)sum / a.Length;
        Console.WriteLine("Toplam: " + sum);
        Console.WriteLine("Ortalama: " + avg);
    }
}
```

---

### Örnek 3 — Min ve Max

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 12, 4, 19, 0, 7 };
        int min = a[0];
        int max = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < min) min = a[i];
            if (a[i] > max) max = a[i];
        }
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
    }
}
```

---

### Örnek 4 — Bir değerin kaç kere geçtiğini sayma

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 2, 4, 2 };
        int target = 2;
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == target) count++;
        }
        Console.WriteLine(target + " sayısı " + count + " kez geçiyor.");
    }
}
```

---

### Örnek 5 — İndis ile güncelleme ve değeri bularak güncelleme

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 5, 6, 7, 8, 9 };
        // İndise göre (örnek: index 2'yi değiştir)
        int idx = 2; // 0-based
        if (idx >= 0 && idx < a.Length)
        {
            a[idx] = 99;
        }

        // Değere göre (ilk bulduğunu değiştir)
        int oldValue = 8;
        int newValue = 42;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == oldValue)
            {
                a[i] = newValue;
                break;
            }
        }

        for (int i = 0; i < a.Length; i++) Console.WriteLine(a[i]);
    }
}
```

---

### Örnek 6 — Sondan ekleme (manual, fonksiyon yok)

Bu örnekte sabit boyutlu bir diziye yeni eleman eklemek için yeni bir dizi oluşturup elemanları `for` ile kopyalıyoruz.

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3 };
        int valueToAdd = 4;
        int[] b = new int[a.Length + 1];
        for (int i = 0; i < a.Length; i++)
        {
            b[i] = a[i];
        }
        b[b.Length - 1] = valueToAdd; // sonuna ekle

        for (int i = 0; i < b.Length; i++) Console.WriteLine(b[i]);
    }
}
```

---

### Örnek 7 — Araya ekleme (index'e göre, fonksiyon yok)

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 10, 20, 30, 40 };
        int index = 2; // nereye ekleyeceğiz
        int value = 25;
        if (index < 0) index = 0;
        if (index > a.Length) index = a.Length;

        int[] b = new int[a.Length + 1];
        for (int i = 0; i < index; i++) b[i] = a[i];
        b[index] = value;
        for (int i = index; i < a.Length; i++) b[i + 1] = a[i];

        for (int i = 0; i < b.Length; i++) Console.WriteLine(b[i]);
    }
}
```

---

### Örnek 8 — İndis ile silme (fonksiyon yok)

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 5, 6, 7, 8 };
        int indexToRemove = 1; // 6'yı sil
        if (indexToRemove < 0 || indexToRemove >= a.Length)
        {
            for (int i = 0; i < a.Length; i++) Console.WriteLine(a[i]);
            return;
        }

        int[] b = new int[a.Length - 1];
        for (int i = 0; i < indexToRemove; i++) b[i] = a[i];
        for (int i = indexToRemove + 1; i < a.Length; i++) b[i - 1] = a[i];

        for (int i = 0; i < b.Length; i++) Console.WriteLine(b[i]);
    }
}
```

---

### Örnek 9 — Değer ile silme (ilk bulunanı kaldırma, fonksiyon yok)

```csharp
using System;

class Program
{
    static void Main()
    {
        int[] a = { 2, 3, 4, 3, 5 };
        int valueToRemove = 3;
        int foundIndex = -1;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == valueToRemove) { foundIndex = i; break; }
        }

        if (foundIndex == -1)
        {
            Console.WriteLine("Değer bulunamadı.");
            return;
        }

        int[] b = new int[a.Length - 1];
        for (int i = 0; i < foundIndex; i++) b[i] = a[i];
        for (int i = foundIndex + 1; i < a.Length; i++) b[i - 1] = a[i];

        for (int i = 0; i < b.Length; i++) Console.WriteLine(b[i]);
    }
}
```

---

### Örnek 10 — Basit `List<int>` kullanımı (for ile gösterim)

Not: `List<T>` özel fonksiyon sayılmaz; .NET koleksiyonudur. Aşağıda `for` ile gezme, ekleme ve silme gösterilmiştir.

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int> { 1, 2, 3 };
        list.Add(4);        // sona ekle
        list.Insert(1, 99); // araya ekle
        list.Remove(3);     // ilk 3'ü sil

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}
```

---

Kısa notlar:
- Bu doküman en basit hâldedir; her bir örnek doğrudan `Main` içinde, `for` döngüleriyle uygulanmıştır.
- Sabit boyutlu dizilerde (int[]) ekleme/silme yapmak için yeni dizi oluşturup kopyalama gerekir. `List<T>` pratik ve önerilen yaklaşımdır.

Nasıl denerim:
- Her örneği ayrı bir `Program.cs` içine yapıştırıp `dotnet run` ile çalıştırabilirsiniz.
## Diziler (Array) — 10 Örnek (Önlisans seviyesi)

- Dizi tanımlama ve iterasyon
- Toplama / ortalama hesaplama
- Minimum / maksimum bulma
- Değer sayma (frekans)
- Güncelleme (index ile veya değer bularak)
- Ekleme (sabit boyutlu dizide manuel ekleme)
- Araya ekleme
- Silme (index ile veya değere göre)
- Pratik kullanım: `List<T>` ile dinamik ekleme/silme

---

### Örnek 1 — Dizi tanımlama ve `for` ile yazdırma

Amaç: Dizi oluşturma ve elemanları `for` döngüsüyle ekrana yazdırma.

```csharp
using System;

class Program
{
	static void Main()
	{
		int[] numbers = { 2, 4, 6, 8, 10 };
		for (int i = 0; i < numbers.Length; i++)
		{
			Console.WriteLine($"Index {i}: {numbers[i]}");
		}
	}
}
```

Çıktı: Dizi elemanları satır satır gösterilir.

---

### Örnek 2 — Toplama ve Ortalama (for ile)

Amaç: Dizi elemanlarının toplamını ve ortalamasını hesaplama.

```csharp
using System;

class Program
{
	static void Main()
	{
		int[] a = { 3, 7, 1, 9, 5 };
		int sum = 0;
		for (int i = 0; i < a.Length; i++)
			sum += a[i];

		double avg = (double)sum / a.Length;
		Console.WriteLine($"Toplam: {sum}, Ortalama: {avg}");
	}
}
```

---

### Örnek 3 — Minimum ve Maksimum bulma

Amaç: `for` ile dizideki en küçük ve en büyük değeri bulma.

```csharp
using System;

class Program
{
	static void Main()
	{
		int[] a = { 12, 4, 19, 0, 7 };
		int min = a[0];
		int max = a[0];
		for (int i = 1; i < a.Length; i++)
		{
			if (a[i] < min) min = a[i];
			if (a[i] > max) max = a[i];
		}
		Console.WriteLine($"Min: {min}, Max: {max}");
	}
}
```

---

### Örnek 4 — Bir değerin kaç kere geçtiğini sayma

Amaç: Belirli bir değerin dizide kaç defa olduğunu `for` ile sayma.

```csharp
using System;

class Program
{
	static void Main()
	{
		int[] a = { 1, 2, 3, 2, 4, 2 };
		int target = 2;
		int count = 0;
		for (int i = 0; i < a.Length; i++)
			if (a[i] == target) count++;

		Console.WriteLine($"{target} sayısı {count} kez geçiyor.");
	}
}
```

---

### Örnek 5 — İndise göre güncelleme ve değeri bulup güncelleme

Amaç: Verilen indeksteki değeri değiştirme ve bir değeri bularak güncelleme.

```csharp
using System;

class Program
{
	static void Main()
	{
		int[] a = { 5, 6, 7, 8, 9 };
		// İndex ile güncelleme
		int index = 2; // 0-based
		if (index >= 0 && index < a.Length)
		{
			a[index] = 99;
		}

		// Değer bularak güncelle (ilk bulunanı)
		int oldValue = 8;
		int newValue = 42;
		for (int i = 0; i < a.Length; i++)
		{
			if (a[i] == oldValue)
			{
				a[i] = newValue;
				break; // ilkini güncelle
			}
		}

		for (int i = 0; i < a.Length; i++)
			Console.WriteLine(a[i]);
	}
}
```

---

### Örnek 6 — Diziye sondan ekleme (manuel): Append fonksiyonu

Amaç: Sabit boyutlu bir diziye yeni eleman eklemek için yeni dizi oluşturup elemanları kopyalama.

```csharp
using System;

class Program
{
	static int[] Append(int[] arr, int value)
	{
		int[] result = new int[arr.Length + 1];
		for (int i = 0; i < arr.Length; i++)
			result[i] = arr[i];
		result[result.Length - 1] = value;
		return result;
	}

	static void Main()
	{
		int[] a = { 1, 2, 3 };
		a = Append(a, 4);
		for (int i = 0; i < a.Length; i++) Console.WriteLine(a[i]);
	}
}
```

---

### Örnek 7 — Araya ekleme: Insert fonksiyonu

Amaç: Belirli bir indekse araya eleman eklemek (diğerlerini sağa kaydırmak).

```csharp
using System;

class Program
{
	static int[] InsertAt(int[] arr, int index, int value)
	{
		if (index < 0) index = 0;
		if (index > arr.Length) index = arr.Length;
		int[] res = new int[arr.Length + 1];
		for (int i = 0; i < index; i++) res[i] = arr[i];
		res[index] = value;
		for (int i = index; i < arr.Length; i++) res[i + 1] = arr[i];
		return res;
	}

	static void Main()
	{
		int[] a = { 10, 20, 30, 40 };
		a = InsertAt(a, 2, 25); // 10,20,25,30,40
		for (int i = 0; i < a.Length; i++) Console.WriteLine(a[i]);
	}
}
```

---

### Örnek 8 — İndex ile silme: RemoveAt fonksiyonu

Amaç: Bir indeksteki elemanı silmek ve kalanları sola kaydırmak.

```csharp
using System;

class Program
{
	static int[] RemoveAt(int[] arr, int index)
	{
		if (index < 0 || index >= arr.Length) return arr; // değişiklik yok
		int[] res = new int[arr.Length - 1];
		for (int i = 0; i < index; i++) res[i] = arr[i];
		for (int i = index + 1; i < arr.Length; i++) res[i - 1] = arr[i];
		return res;
	}

	static void Main()
	{
		int[] a = { 5, 6, 7, 8 };
		a = RemoveAt(a, 1); // 5,7,8
		for (int i = 0; i < a.Length; i++) Console.WriteLine(a[i]);
	}
}
```

---

### Örnek 9 — Değerle silme (ilk bulunanı kaldırma)

Amaç: Belirli bir değeri bulup ilk karşılaşmayı silmek.

```csharp
using System;

class Program
{
	static int[] RemoveFirst(int[] arr, int value)
	{
		int index = -1;
		for (int i = 0; i < arr.Length; i++)
			if (arr[i] == value) { index = i; break; }
		if (index == -1) return arr; // bulunmadı
		return RemoveAt(arr, index);
	}

	static int[] RemoveAt(int[] arr, int index)
	{
		int[] res = new int[arr.Length - 1];
		for (int i = 0; i < index; i++) res[i] = arr[i];
		for (int i = index + 1; i < arr.Length; i++) res[i - 1] = arr[i];
		return res;
	}

	static void Main()
	{
		int[] a = { 2, 3, 4, 3, 5 };
		a = RemoveFirst(a, 3); // 2,4,3,5
		for (int i = 0; i < a.Length; i++) Console.WriteLine(a[i]);
	}
}
```

---

### Örnek 10 — Pratik: `List<int>` ile `for` döngüsü kullanarak ekleme / silme

Amaç: Gerçek hayatta dizi yerine `List<T>` kullanmak daha pratiktir; burada `for` ile listeyi okuyup, ekleme/silmeyi gösteriyoruz.

```csharp
using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<int> list = new List<int> { 1, 2, 3 };
		// Ekle
		list.Add(4);
		// Araya ekleme (index)
		list.Insert(1, 99); // 1,99,2,3,4
		// Sil (değer)
		list.Remove(3); // ilk 3'ü siler

		// Listeyi for ile gezme
		for (int i = 0; i < list.Count; i++)
			Console.WriteLine($"{i}: {list[i]}");

		// Gerekirse array'e çevirme
		int[] arr = list.ToArray();
		Console.WriteLine("Array'e çevrildi: " + arr.Length);
	}
}
```

---

Notlar ve İpuçları:
- C# dizileri (int[]) sabit boyutludur; dinamik davranış için `List<T>` tercih edilir.
- Öğretici amaçlı `Append`, `InsertAt`, `RemoveAt` gibi fonksiyonları manuel gösterdik; bu işlemler yeni dizi oluşturma ve kopyalama içerir (O(n) maliyet).
- `for` döngüsü indeks tabanlı işlem ve kopyalama için idealdir; dizilerde index kontrollü erişim hata riskini azaltır.

"Try it": Her örneği Visual Studio veya `dotnet` CLI ile ayrı bir konsol projesinde çalıştırabilirsiniz. Küçük bir değişiklikle aynı Program.cs içinde örnekleri sırayla çağırıp deneyin.

Başlangıç için öneri: önce 1–4 arasındaki örnekleri deneyin, sonra 6–9 ile dizide manuel değişiklikleri inceleyin, son olarak 10. örnekle `List<T>`'in avantajını görün.

