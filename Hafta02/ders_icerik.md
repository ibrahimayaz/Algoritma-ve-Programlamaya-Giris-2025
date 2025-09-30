# Hafta 02: Sözde Kod ve Akış Diyagramları

## 🎯 Ders Hedefleri
Bu dersin sonunda öğrenciler:
- ✅ Sözde kod yazabilecek ve anlayabilecek
- ✅ Akış diyagramı çizebilecek ve yorumlayabilecek
- ✅ Algoritmaları görsel olarak ifade edebilecek
- ✅ Karmaşık problemleri adım adım çözebilecek
- ✅ Farklı çözüm yöntemlerini karşılaştırabilecek

## 📋 Ders İçeriği Özeti
| Süre | Konu | Aktivite |
|------|------|----------|
| 15 dk | Geçen hafta tekrarı | Soru-cevap |
| 30 dk | Sözde kod temelleri | Teorik anlatım + örnekler |
| 30 dk | Akış diyagramları | Görsel anlatım + çizim |
| 45 dk | Uygulama örnekleri | Birlikte çözüm |
| 20 dk | Lab çalışması | Bireysel pratik |
| 10 dk | Değerlendirme | Soru-cevap |

## 🧠 Geçen Hafta Tekrarı (5 dakika)

### Hızlı Test
1. **Algoritma nedir?** → Problemi çözmek için takip edilen adımlar dizisi
2. **Program nedir?** → Algoritmanın bilgisayar dilinde yazılmış hali
3. **Programlama nedir?** → Algorithm tasarlama ve kodlama süreci

### Hatırlatma Soruları
> "Çay yapma algoritmasını 5 adımda yazabilir misiniz?"
> "Algoritmanın 5 temel özelliği nelerdi?"

---

## 1. 📝 Sözde Kod (Pseudocode) Nedir?

### 🔍 Tanım ve Önem
**Sözde kod**, algoritmayı programlama diline benzer ama daha basit bir yapıda yazma yöntemidir. İnsan tarafından kolayca anlaşılabilir ve herhangi bir programlama diline çevrilebilir.

### 💡 Neden Sözde Kod Kullanırız?

#### Avantajlar
- 🌍 **Programlama dilinden bağımsız** → Herkes anlayabilir
- 🎯 **Kolay anlaşılır** → Türkçe benzeri ifadeler
- ⚡ **Hızlı yazılır** → Zaman tasarrufu
- 🐛 **Mantık hatalarını erken fark ettirir** → Kodlamadan önce çözüm
- 👥 **Takım çalışmasında iletişim aracı** → Ortak dil

#### Dezavantajlar
- ⚠️ **Standart formatı yok** → Herkes farklı yazabilir
- 🖥️ **Bilgisayarda çalışmaz** → Sadece tasarım aşaması
- 📏 **Detay seviyesi belirsiz** → Ne kadar ayrıntı gerekli?

### 📚 Gerçek Hayat Analojisi
Sözde kod, **yemek tarifine** benzer:
```
Makarna Tarifi (Algoritma):
1. Tencereyi ocağa koy
2. Su ekle ve kaynat
3. Makarnayı at
4. 10-12 dakika pişir
5. Süz ve servis et

Sözde Kod:
BAŞLA
  tencere ← ocağa koy
  su ← tencereye ekle
  KOŞUL su kaynayıncaya kadar BEKLE
  makarna ← tencereye at
  12 dakika BEKLE
  makarna ← süz
  SERVIS et
BITIR
```

### 🏗️ Temel Sözde Kod Yapıları

#### 1. 🚀 Başlangıç ve Bitiş
```
BAŞLA
  // Algoritmayı buraya yaz
  // Yorum satırları // ile başlar
BITIR
```

#### 2. 📦 Değişken Atama
```
değişken_adı ← değer        // Temel atama
x ← 5                       // Sayısal değer
isim ← "Ahmet"             // Metin değeri
doğru ← true               // Mantıksal değer
liste ← [1, 2, 3, 4]       // Dizi değeri
```

#### 3. 🔄 Giriş/Çıkış İşlemleri
```
// 📥 Veri alma (INPUT)
sayı ← Kullanıcıdan sayı al
isim ← Kullanıcıdan string al
"Yaşınızı girin:" ← Mesaj göster ve sayı al

// 📤 Veri gösterme (OUTPUT)
Yazdır "Sonuç: " + sonuç
Göster mesaj
Ekrana yazdır değişken
```

#### 4. 🔀 Koşul Yapıları (Karar Verme)
```
// Basit IF
EĞER koşul İSE
  işlem1
BITIR

// IF-ELSE
EĞER koşul İSE
  işlem1
DEĞILSE
  işlem2
BITIR

// Çoklu koşul (IF-ELSE IF-ELSE)
EĞER koşul1 İSE
  işlem1
DEĞILSE EĞER koşul2 İSE
  işlem2
DEĞILSE EĞER koşul3 İSE
  işlem3
DEĞILSE
  varsayılan_işlem
BITIR

// SWITCH yapısı
DEĞİŞKEN seçim'E GÖRE
  DURUM 1: işlem1; ÇIK
  DURUM 2: işlem2; ÇIK
  VARSAYILAN: varsayılan_işlem
BITIR
```

#### 5. 🔁 Döngü Yapıları (Tekrar)
```
// FOR döngüsü (Belirli sayıda tekrar)
İÇİN i = 1'den 10'a KADAR
  işlem
BITIR

İÇİN her eleman İÇİNDE dizi
  işlemyap(eleman)
BITIR

// WHILE döngüsü (Koşul sağlandığı sürece)
i ← 1
KOŞUL i <= 10 İKEN
  işlem
  i ← i + 1
BITIR

// DO-WHILE (En az bir kez çalışır)
YAP
  işlem
  kullanıcı_girdisi ← Kullanıcıdan veri al
KOŞUL kullanıcı_girdisi != "çıkış" İKEN
```

#### 6. 🔧 Fonksiyon Tanımlama
```
FONKSİYON fonksiyon_adı(parametre1, parametre2)
  // işlemler
  DÖNDÜR sonuç
BITIR

// Örnek:
FONKSİYON topla(a, b)
  sonuç ← a + b
  DÖNDÜR sonuç
BITIR
```

### 📐 Matematiksel İşlemler ve Operatörler

#### Aritmetik Operatörler
```
+ → Toplama        (5 + 3 = 8)
- → Çıkarma        (5 - 3 = 2)
* → Çarpma         (5 * 3 = 15)
/ → Bölme          (6 / 3 = 2)
% → Mod (kalan)    (7 % 3 = 1)
^ → Üs alma        (2 ^ 3 = 8)
```

#### Karşılaştırma Operatörleri
```
= veya ==  → Eşit mi?           (5 == 5 → true)
≠ veya !=  → Eşit değil mi?     (5 != 3 → true)
>          → Büyük mü?          (5 > 3 → true)
<          → Küçük mü?          (3 < 5 → true)
>=         → Büyük eşit mi?     (5 >= 5 → true)
<=         → Küçük eşit mi?     (3 <= 5 → true)
```

#### Mantıksal Operatörler
```
VE (AND, &&)    → Her iki koşul da doğru
VEYA (OR, ||)   → En az bir koşul doğru
DEĞİL (NOT, !)  → Koşulun tersi

Örnekler:
(yaş >= 18) VE (ehliyet == "var")     → true/false
(gün == "cumartesi") VEYA (gün == "pazar")  → true/false
DEĞİL (yaş < 18)                      → true/false
```

## 2. 📊 Akış Diyagramları

### 🎨 Akış Diyagramı Nedir?
**Akış diyagramı**, algoritmanın görsel temsilidir. Geometrik şekiller ve oklar kullanarak algoritmanın akışını gösterir. Bu yöntem özellikle karmaşık algoritmaları anlamak için çok faydalıdır.

### 🌟 Akış Diyagramının Avantajları
- 👁️ **Görsel anlayış** → Algoritma bir bakışta anlaşılır
- 🔍 **Hata tespiti** → Mantık hataları kolayca görülür
- 💬 **İletişim aracı** → Teknik olmayan kişilerle paylaşım
- 📝 **Dokümantasyon** → Kalıcı referans
- 🧩 **Problem çözme** → Karmaşık problemleri parçalara ayırma

### 🔶 Temel Semboller ve Anlamları

#### 🔘 Terminal (Oval/Elips)
```
Kullanım: Başla/Bitir
Şekil: ( BAŞLA ) ( BITIR )
Renk: Genellikle yeşil (başla) / kırmızı (bitir)
```

#### 📐 İşlem (Dikdörtgen)
```
Kullanım: Hesaplama, atama işlemleri
Şekil: [ toplam ← a + b ]
Örnekler:
[ x ← x + 1 ]
[ sonuç ← sqrt(sayı) ]
[ yaş ← 2023 - doğumYılı ]
```

#### 📝 Giriş/Çıkış (Paralelkenar)
```
Kullanım: Veri alma/gösterme
Şekil: / Sayı al / \ Sonucu göster \
Örnekler:
/ "Adınızı girin" al /
\ "Sonuç: " + toplam göster \
```

#### 💎 Karar (Baklava/Elmas)
```
Kullanım: Koşul kontrolü (if, while)
Şekil: ◊ a > b ? ◊
İki çıkış: Evet/Hayır, True/False, 1/0
Önemli: Mutlaka iki çıkışı olmalı!
```

#### 🔗 Bağlantı (Daire)
```
Kullanım: Akış çizgilerini birleştirme
Şekil: ○ A ○
Sayfa arası bağlantı için kullanılır
```

#### ⬅️ Ok İşaretleri
```
Kullanım: Akış yönünü gösterme
Şekil: → ↓ ← ↑
Kural: Her çizgide ok bulunmalı
```

### 📋 Akış Diyagramı Çizim Kuralları

#### ✅ Temel Kurallar
1. **Yukarıdan aşağıya, soldan sağa** çizilir
2. **Her sembol tek girişe** sahip olmalı
3. **Karar sembolünün iki çıkışı** olmalı
4. **Çizgiler kesişmemeli** (köprü kullan)
5. **Her çizgi üzerinde ok** bulunmalı
6. **Net etiketleme** yapılmalı

#### 🎨 Çizim Teknikleri
```
İyi Pratikler:
✅ Temiz ve düzenli çizim
✅ Uygun font boyutu
✅ Tutarlı sembol boyutları
✅ Anlaşılır etiketler
✅ Renkli kodlama (opsiyonel)

Kötü Pratikler:
❌ Çok karmaşık diyagramlar
❌ Küçük yazılar
❌ Kesişen çizgiler
❌ Belirsiz etiketler
❌ Tutarsız semboller
```

### 🛠️ Akış Diyagramı Çizim Aracı

#### 🎨 Draw.io (diagrams.net) - **KULLANILACAK TEK ARAÇ**
- **URL:** https://app.diagrams.net/
- ✅ Tamamen ücretsiz ve kayıt gerektirmez
- ✅ Türkçe arayüz desteği
- ✅ Zengin akış diyagramı şablon kütüphanesi
- ✅ Export seçenekleri: PNG, JPG, PDF, SVG, XML
- ✅ Embed kod üretimi ve paylaşım
- ✅ Offline çalışma desteği
- ✅ Google Drive, OneDrive entegrasyonu

**🔧 Draw.io Kurulum ve Kullanım:**
```
📋 Adım Adım Rehber:
1. Tarayıcınızla https://app.diagrams.net/ gidin
2. "Create New Diagram" butonuna tıklayın
3. "Flowchart" şablonunu seçin ve "Create" tıklayın
4. Sol panelden akış diyagramı sembollerini sürükleyip bırakın
5. Sembolleri birbirine ok çizgileri ile bağlayın
6. Metin eklemek için sembole çift tıklayın
7. Renk ve stil düzenlemeleri için sağ paneli kullanın
8. Bitince File → Export as → PNG seçin
9. Dosyayı "draw_io_files" klasörüne kaydedin
```

**📁 Dosya Organizasyonu:**
```
Hafta02/
├── ders_icerik.md
├── draw_io_files/
│   ├── 01_toplama_algoritmasi.drawio
│   ├── 01_toplama_algoritmasi.png
│   ├── 02_cift_tek_kontrol.drawio
│   ├── 02_cift_tek_kontrol.png
│   ├── 03_faktöriyel_hesaplama.drawio
│   ├── 03_faktöriyel_hesaplama.png
│   └── ... (diğer örnekler)
```

#### 🖥️ Masaüstü Yazılımlar
- **Microsoft Visio** → Endüstri standardı (ücretli)
- **Flowgorithm** → Eğitim odaklı (ücretsiz)
- **LibreOffice Draw** → Açık kaynak (ücretsiz)

#### 📱 Mobil Uygulamalar
- **Flowdia** → Android/iOS
- **Grafio** → iPad için ideal
- **SimpleMind** → Mind mapping + akış

## 3. 💡 10 Detaylı Örnek ve Uygulamalar

### 🔥 Örnek 1: Basit Toplama İşlemi
> **Zorluk:** ⭐ Başlangıç  
> **Süre:** 5 dakika  
> **Problem:** İki sayıyı toplayan program tasarlayın

#### 📝 Sözde Kod Çözümü:
```
BAŞLA
  // Kullanıcıdan veri alma
  Yazdır "=== TOPLAMA PROGRAMI ==="
  Yazdır "Birinci sayıyı girin:"
  sayı1 ← Kullanıcıdan sayı al
  
  Yazdır "İkinci sayıyı girin:"
  sayı2 ← Kullanıcıdan sayı al
  
  // İşlem yapma
  toplam ← sayı1 + sayı2
  
  // Sonucu gösterme
  Yazdır "Sonuç: " + sayı1 + " + " + sayı2 + " = " + toplam
  Yazdır "Program sona erdi!"
BITIR
```

#### 📊 Draw.io Akış Diyagramı:
**🔗 Draw.io Dosyası:** [01_toplama_algoritmasi.drawio](./draw_io_files/01_toplama_algoritmasi.drawio)

```
Draw.io'da Çizilen Diyagram:
┌─────────────┐
│   BAŞLA     │ (Oval - Yeşil)
└─────┬───────┘
      │
┌─────v───────┐
│"Birinci sayı│ (Paralelkenar - Mavi)
│    girin"   │
└─────┬───────┘
      │
┌─────v───────┐
│  sayı1 al   │ (Paralelkenar - Mavi)
└─────┬───────┘
      │
┌─────v───────┐
│"İkinci sayı │ (Paralelkenar - Mavi)
│    girin"   │
└─────┬───────┘
      │
┌─────v───────┐
│  sayı2 al   │ (Paralelkenar - Mavi)
└─────┬───────┘
      │
┌─────v───────┐
│toplam←sayı1+│ (Dikdörtgen - Sarı)
│    sayı2    │
└─────┬───────┘
      │
┌─────v───────┐
│Sonucu göster│ (Paralelkenar - Turuncu)
└─────┬───────┘
      │
┌─────v───────┐
│    BITIR    │ (Oval - Kırmızı)
└─────────────┘
```

#### 🧪 Test Senaryoları:
```
Test 1: sayı1 = 5, sayı2 = 3  → Beklenen: 8
Test 2: sayı1 = -2, sayı2 = 7 → Beklenen: 5
Test 3: sayı1 = 0, sayı2 = 0  → Beklenen: 0
Test 4: sayı1 = 1.5, sayı2 = 2.7 → Beklenen: 4.2
```

---

### 🔥 Örnek 2: Çift/Tek Sayı Kontrolü
> **Zorluk:** ⭐⭐ Orta  
> **Süre:** 10 dakika  
> **Problem:** Girilen sayının çift mi tek mi olduğunu bulan program

#### 📝 Sözde Kod Çözümü:
```
BAŞLA
  // Başlık ve giriş
  Yazdır "=== ÇİFT/TEK KONTROL PROGRAMI ==="
  Yazdır "Bir sayı girin:"
  sayı ← Kullanıcıdan sayı al
  
  // Çift/tek kontrolü (mod operatörü)
  kalan ← sayı % 2
  
  // Karar verme
  EĞER kalan = 0 İSE
    Yazdır sayı + " çift sayıdır ✅"
    Yazdır "2'ye tam bölünür."
  DEĞILSE
    Yazdır sayı + " tek sayıdır ⚡"
    Yazdır "2'ye bölündüğünde 1 kalan verir."
  BITIR
  
  Yazdır "Analiz tamamlandı!"
BITIR
```

#### 📊 Draw.io Akış Diyagramı:
**🔗 Draw.io Dosyası:** [02_cift_tek_kontrol.drawio](./draw_io_files/02_cift_tek_kontrol.drawio)

```
Draw.io'da Çizilen Diyagram:
┌─────────────┐
│   BAŞLA     │ (Oval - Yeşil)
└─────┬───────┘
      │
┌─────v───────┐
│"Bir sayı    │ (Paralelkenar - Mavi)
│   girin"    │
└─────┬───────┘
      │
┌─────v───────┐
│  sayı al    │ (Paralelkenar - Mavi)
└─────┬───────┘
      │
┌─────v───────┐
│kalan←sayı%2 │ (Dikdörtgen - Sarı)
└─────┬───────┘
      │
      ◊ kalan=0? ◊ (Elmas - Pembe)
     /           \
 EVET/             \HAYIR
    /               \
┌─────v───────┐ ┌─────v───────┐
│"Çift sayı"  │ │"Tek sayı"   │ (Paralelkenar - Turuncu)
└─────┬───────┘ └─────┬───────┘
      │               │
      └─────┬─────────┘
            │
      ┌─────v───────┐
      │    BITIR    │ (Oval - Kırmızı)
      └─────────────┘
```

---

### � Örnek 3: En Büyük Sayıyı Bulma (3 Sayı)
> **Zorluk:** ⭐⭐ Orta  
> **Süre:** 12 dakika

#### 📝 Sözde Kod Çözümü:
```
BAŞLA
  // Veri girişi
  Yazdır "=== EN BÜYÜK SAYI BULMA ==="
  Yazdır "Birinci sayıyı girin:"
  sayı1 ← Kullanıcıdan sayı al
  
  Yazdır "İkinci sayıyı girin:"
  sayı2 ← Kullanıcıdan sayı al
  
  Yazdır "Üçüncü sayıyı girin:"
  sayı3 ← Kullanıcıdan sayı al
  
  // En büyüğü bulma
  EĞER sayı1 >= sayı2 VE sayı1 >= sayı3 İSE
    enBüyük ← sayı1
    Yazdır "En büyük sayı: " + sayı1
  DEĞILSE EĞER sayı2 >= sayı1 VE sayı2 >= sayı3 İSE
    enBüyük ← sayı2
    Yazdır "En büyük sayı: " + sayı2
  DEĞILSE
    enBüyük ← sayı3
    Yazdır "En büyük sayı: " + sayı3
  BITIR
  
  Yazdır "Girilen sayılar: " + sayı1 + ", " + sayı2 + ", " + sayı3
BITIR
```

#### 📊 Draw.io Akış Diyagramı:
**🔗 Draw.io Dosyası:** [03_en_buyuk_sayi.drawio](./draw_io_files/03_en_buyuk_sayi.drawio)

---

### 🔥 Örnek 4: Faktöriyel Hesaplama
> **Zorluk:** ⭐⭐⭐ İleri  
> **Süre:** 15 dakika  
> **Problem:** n! = n × (n-1) × (n-2) × ... × 1

#### 📝 Sözde Kod Çözümü:
```
BAŞLA
  Yazdır "=== FAKTÖRİYEL HESAPLAMA ==="
  Yazdır "Faktöriyeli hesaplanacak sayıyı girin:"
  n ← Kullanıcıdan sayı al
  
  // Geçerlilik kontrolü
  EĞER n < 0 İSE
    Yazdır "HATA: Negatif sayıların faktöriyeli tanımsızdır!"
    ÇIK
  BITIR
  
  // Özel durum: 0! = 1
  EĞER n = 0 İSE
    Yazdır "0! = 1"
    ÇIK
  BITIR
  
  // Faktöriyel hesaplama
  faktöriyel ← 1
  i ← 1
  
  KOŞUL i <= n İKEN
    faktöriyel ← faktöriyel * i
    i ← i + 1
  BITIR
  
  Yazdır n + "! = " + faktöriyel
BITIR
```

#### 📊 Draw.io Akış Diyagramı:
**🔗 Draw.io Dosyası:** [04_faktoriyel_hesaplama.drawio](./draw_io_files/04_faktoriyel_hesaplama.drawio)

---

### 🔥 Örnek 5: Fibonacci Dizisi (İlk N Terim)
> **Zorluk:** ⭐⭐⭐ İleri  
> **Problem:** F(n) = F(n-1) + F(n-2), F(0)=0, F(1)=1

#### 📝 Sözde Kod Çözümü:
```
BAŞLA
  Yazdır "=== FİBONACCİ DİZİSİ ==="
  Yazdır "Kaç terim yazdırılsın?"
  n ← Kullanıcıdan sayı al
  
  EĞER n <= 0 İSE
    Yazdır "HATA: Pozitif bir sayı girin!"
    ÇIK
  BITIR
  
  a ← 0
  b ← 1
  sayaç ← 1
  
  Yazdır "Fibonacci Dizisi:"
  
  EĞER n >= 1 İSE
    Yazdır a
    sayaç ← sayaç + 1
  BITIR
  
  KOŞUL sayaç <= n İKEN
    Yazdır b
    c ← a + b
    a ← b
    b ← c
    sayaç ← sayaç + 1
  BITIR
BITIR
```

#### 📊 Draw.io Akış Diyagramı:
**🔗 Draw.io Dosyası:** [05_fibonacci_dizisi.drawio](./draw_io_files/05_fibonacci_dizisi.drawio)

---

### 🔥 Örnek 6: Basit Not Hesaplama Sistemi
> **Zorluk:** ⭐⭐ Orta  
> **Problem:** 3 sınav notunun ortalamasını alıp harf notu veren sistem

#### 📝 Sözde Kod Çözümü:
```
BAŞLA
  Yazdır "=== NOT HESAPLAMA SİSTEMİ ==="
  
  // Notları alma
  Yazdır "1. sınav notunu girin (0-100):"
  not1 ← Kullanıcıdan sayı al
  
  Yazdır "2. sınav notunu girin (0-100):"
  not2 ← Kullanıcıdan sayı al
  
  Yazdır "3. sınav notunu girin (0-100):"
  not3 ← Kullanıcıdan sayı al
  
  // Geçerlilik kontrolü
  EĞER (not1 < 0 VEYA not1 > 100) VEYA (not2 < 0 VEYA not2 > 100) VEYA (not3 < 0 VEYA not3 > 100) İSE
    Yazdır "HATA: Notlar 0-100 arasında olmalıdır!"
    ÇIK
  BITIR
  
  // Ortalama hesaplama
  ortalama ← (not1 + not2 + not3) / 3
  
  // Harf notu belirleme
  EĞER ortalama >= 90 İSE
    harfNotu ← "AA"
    durum ← "Mükemmel"
  DEĞILSE EĞER ortalama >= 80 İSE
    harfNotu ← "BA"
    durum ← "İyi"
  DEĞILSE EĞER ortalama >= 70 İSE
    harfNotu ← "BB"
    durum ← "Orta"
  DEĞILSE EĞER ortalama >= 60 İSE
    harfNotu ← "CB"
    durum ← "Geçer"
  DEĞILSE
    harfNotu ← "FF"
    durum ← "Kaldı"
  BITIR
  
  // Sonuçları gösterme
  Yazdır "=== SONUÇLAR ==="
  Yazdır "Notlarınız: " + not1 + ", " + not2 + ", " + not3
  Yazdır "Ortalama: " + ortalama
  Yazdır "Harf Notu: " + harfNotu
  Yazdır "Durum: " + durum
BITIR
```

#### 📊 Draw.io Akış Diyagramı:
**🔗 Draw.io Dosyası:** [06_not_hesaplama.drawio](./draw_io_files/06_not_hesaplama.drawio)

---

### 🔥 Örnek 7: Sayı Tahmin Oyunu
> **Zorluk:** ⭐⭐⭐ İleri  
> **Problem:** Bilgisayar 1-100 arası sayı tutar, kullanıcı tahmin eder

#### 📝 Sözde Kod Çözümü:
```
BAŞLA
  Yazdır "=== SAYI TAHMİN OYUNU ==="
  
  // Rastgele sayı üretme (1-100)
  doğruSayı ← RastgeleSayı(1, 100)
  tahminHakkı ← 7
  tahminSayısı ← 0
  
  Yazdır "1-100 arası bir sayı tuttum!"
  Yazdır "Toplam " + tahminHakkı + " hakkınız var."
  
  KOŞUL tahminHakkı > 0 İKEN
    Yazdır "Tahmininizi girin:"
    tahmin ← Kullanıcıdan sayı al
    tahminSayısı ← tahminSayısı + 1
    
    EĞER tahmin = doğruSayı İSE
      Yazdır "🎉 TEBRİKLER! Doğru tahmin!"
      Yazdır "Sayı: " + doğruSayı
      Yazdır tahminSayısı + " tahminde buldunuz!"
      ÇIK
    DEĞILSE EĞER tahmin < doğruSayı İSE
      Yazdır "📈 Daha BÜYÜK bir sayı deneyin"
    DEĞILSE
      Yazdır "📉 Daha KÜÇÜK bir sayı deneyin"
    BITIR
    
    tahminHakkı ← tahminHakkı - 1
    Yazdır "Kalan hak: " + tahminHakkı
  BITIR
  
  EĞER tahminHakkı = 0 İSE
    Yazdır "😢 Oyun bitti! Doğru sayı: " + doğruSayı
  BITIR
BITIR
```

#### 📊 Draw.io Akış Diyagramı:
**🔗 Draw.io Dosyası:** [07_sayi_tahmin_oyunu.drawio](./draw_io_files/07_sayi_tahmin_oyunu.drawio)

---

### 🔥 Örnek 8: Vücut Kitle İndeksi (VKİ) Hesaplama
> **Zorluk:** ⭐⭐ Orta  
> **Problem:** Kilo ve boy bilgisine göre VKİ hesaplayıp kategori belirleyen sistem

#### 📝 Sözde Kod Çözümü:
```
BAŞLA
  Yazdır "=== VKİ HESAPLAMA SİSTEMİ ==="
  
  // Kişisel bilgileri alma
  Yazdır "Kilonuzu girin (kg):"
  kilo ← Kullanıcıdan sayı al
  
  Yazdır "Boyunuzu girin (cm):"
  boy ← Kullanıcıdan sayı al
  
  // Geçerlilik kontrolü
  EĞER kilo <= 0 VEYA boy <= 0 İSE
    Yazdır "HATA: Kilo ve boy pozitif olmalıdır!"
    ÇIK
  BITIR
  
  // VKİ hesaplama
  boyMetre ← boy / 100
  vki ← kilo / (boyMetre * boyMetre)
  
  // Kategori belirleme
  EĞER vki < 18.5 İSE
    kategori ← "Zayıf"
    öneri ← "Kilo almanız önerilir"
    renk ← "🔵"
  DEĞILSE EĞER vki < 25 İSE
    kategori ← "Normal"
    öneri ← "İdeal kiloda değiniz"
    renk ← "🟢"
  DEĞILSE EĞER vki < 30 İSE
    kategori ← "Kilolu"
    öneri ← "Kilo vermeniz önerilir"
    renk ← "🟡"
  DEĞILSE
    kategori ← "Obez"
    öneri ← "Doktora başvurun"
    renk ← "🔴"
  BITIR
  
  // Sonuçları gösterme
  Yazdır "=== VKİ SONUÇLARI ==="
  Yazdır "Kilo: " + kilo + " kg"
  Yazdır "Boy: " + boy + " cm"
  Yazdır "VKİ: " + vki
  Yazdır renk + " Kategori: " + kategori
  Yazdır "Öneri: " + öneri
BITIR
```

#### 📊 Draw.io Akış Diyagramı:
**🔗 Draw.io Dosyası:** [08_vki_hesaplama.drawio](./draw_io_files/08_vki_hesaplama.drawio)

---

### 🔥 Örnek 9: Basit ATM Sistemi
> **Zorluk:** ⭐⭐⭐⭐ Uzman  
> **Problem:** PIN kontrolü, menü sistemi ve para çekme işlemleri

#### 📝 Sözde Kod Çözümü:
```
BAŞLA
  Yazdır "=== ATM SİSTEMİ ==="
  
  // Başlangıç değerleri
  doğruPIN ← "1234"
  bakiye ← 1000
  pinDenemesi ← 0
  maxDeneme ← 3
  
  // PIN kontrolü
  KOŞUL pinDenemesi < maxDeneme İKEN
    Yazdır "PIN kodunuzu girin:"
    girilenPIN ← Kullanıcıdan string al
    
    EĞER girilenPIN = doğruPIN İSE
      Yazdır "✅ PIN doğru! Hoş geldiniz!"
      ÇIK döngüden
    DEĞILSE
      pinDenemesi ← pinDenemesi + 1
      kalanDeneme ← maxDeneme - pinDenemesi
      
      EĞER kalanDeneme > 0 İSE
        Yazdır "❌ Yanlış PIN! Kalan deneme: " + kalanDeneme
      DEĞILSE
        Yazdır "🚫 Kartınız bloke edildi!"
        ÇIK
      BITIR
    BITIR
  BITIR
  
  // Ana menü
  EĞER pinDenemesi < maxDeneme İSE
    devamEt ← true
    
    KOŞUL devamEt = true İKEN
      Yazdır "=== ANA MENÜ ==="
      Yazdır "1. Bakiye Sorgula"
      Yazdır "2. Para Çek"
      Yazdır "3. Çıkış"
      Yazdır "Seçiminiz:"
      seçim ← Kullanıcıdan sayı al
      
      EĞER seçim = 1 İSE
        Yazdır "💰 Mevcut bakiyeniz: " + bakiye + " TL"
        
      DEĞILSE EĞER seçim = 2 İSE
        Yazdır "Çekmek istediğiniz tutarı girin:"
        tutar ← Kullanıcıdan sayı al
        
        EĞER tutar <= 0 İSE
          Yazdır "❌ Geçersiz tutar!"
        DEĞILSE EĞER tutar > bakiye İSE
          Yazdır "❌ Yetersiz bakiye!"
        DEĞILSE
          bakiye ← bakiye - tutar
          Yazdır "✅ " + tutar + " TL çekildi"
          Yazdır "💰 Kalan bakiye: " + bakiye + " TL"
        BITIR
        
      DEĞILSE EĞER seçim = 3 İSE
        Yazdır "👋 İyi günler dileriz!"
        devamEt ← false
        
      DEĞILSE
        Yazdır "❌ Geçersiz seçim!"
      BITIR
    BITIR
  BITIR
BITIR
```

#### 📊 Draw.io Akış Diyagramı:
**🔗 Draw.io Dosyası:** [09_atm_sistemi.drawio](./draw_io_files/09_atm_sistemi.drawio)

---

### 🔥 Örnek 10: Hesap Makinesi (Menü Sistemli)
> **Zorluk:** ⭐⭐⭐ İleri  
> **Problem:** Dört işlem + özel fonksiyonlar içeren hesap makinesi

#### 📝 Sözde Kod Çözümü:
```
BAŞLA
  Yazdır "=== GELİŞMİŞ HESAP MAKİNESİ ==="
  
  devam ← true
  
  KOŞUL devam = true İKEN
    Yazdır ""
    Yazdır "=== MENÜ ==="
    Yazdır "1. Toplama (+)"
    Yazdır "2. Çıkarma (-)"
    Yazdır "3. Çarpma (*)"
    Yazdır "4. Bölme (/)"
    Yazdır "5. Üs Alma (^)"
    Yazdır "6. Karekök (√)"
    Yazdır "7. Faktöriyel (!)"
    Yazdır "8. Çıkış"
    Yazdır "Seçiminizi yapın (1-8):"
    
    seçim ← Kullanıcıdan sayı al
    
    EĞER seçim = 1 İSE
      Yazdır "Birinci sayıyı girin:"
      a ← Kullanıcıdan sayı al
      Yazdır "İkinci sayıyı girin:"
      b ← Kullanıcıdan sayı al
      sonuç ← a + b
      Yazdır a + " + " + b + " = " + sonuç
      
    DEĞILSE EĞER seçim = 2 İSE
      Yazdır "Birinci sayıyı girin:"
      a ← Kullanıcıdan sayı al
      Yazdır "İkinci sayıyı girin:"
      b ← Kullanıcıdan sayı al
      sonuç ← a - b
      Yazdır a + " - " + b + " = " + sonuç
      
    DEĞILSE EĞER seçim = 3 İSE
      Yazdır "Birinci sayıyı girin:"
      a ← Kullanıcıdan sayı al
      Yazdır "İkinci sayıyı girin:"
      b ← Kullanıcıdan sayı al
      sonuç ← a * b
      Yazdır a + " × " + b + " = " + sonuç
      
    DEĞILSE EĞER seçim = 4 İSE
      Yazdır "Birinci sayıyı girin:"
      a ← Kullanıcıdan sayı al
      Yazdır "İkinci sayıyı girin:"
      b ← Kullanıcıdan sayı al
      
      EĞER b = 0 İSE
        Yazdır "❌ Sıfıra bölme hatası!"
      DEĞILSE
        sonuç ← a / b
        Yazdır a + " ÷ " + b + " = " + sonuç
      BITIR
      
    DEĞILSE EĞER seçim = 6 İSE
      Yazdır "Sayıyı girin:"
      a ← Kullanıcıdan sayı al
      
      EĞER a < 0 İSE
        Yazdır "❌ Negatif sayının karekökü alınamaz!"
      DEĞILSE
        sonuç ← KareKök(a)
        Yazdır "√" + a + " = " + sonuç
      BITIR
      
    DEĞILSE EĞER seçim = 7 İSE
      Yazdır "Sayıyı girin:"
      n ← Kullanıcıdan sayı al
      
      EĞER n < 0 İSE
        Yazdır "❌ Negatif sayının faktöriyeli tanımsız!"
      DEĞILSE
        faktöriyel ← 1
        i ← 1
        KOŞUL i <= n İKEN
          faktöriyel ← faktöriyel * i
          i ← i + 1
        BITIR
        Yazdır n + "! = " + faktöriyel
      BITIR
      
    DEĞILSE EĞER seçim = 8 İSE
      Yazdır "👋 Hesap makinesi kapatılıyor..."
      devam ← false
      
    DEĞILSE
      Yazdır "❌ Geçersiz seçim! Lütfen 1-8 arası bir sayı girin."
    BITIR
  BITIR
  
  Yazdır "Program sona erdi!"
BITIR
```

#### 📊 Draw.io Akış Diyagramı:
**🔗 Draw.io Dosyası:** [10_hesap_makinesi.drawio](./draw_io_files/10_hesap_makinesi.drawio)

## 4. 📚 Ders Materyalleri ve Kaynaklar

### 📖 Okuma Kaynakları

#### 📘 Temel Kitaplar
1. **"Algoritma Geliştirme ve Programlamaya Giriş"** - Ünal Yarımağan
   - Bölüm 3: Sözde Kod Yazımı
   - Bölüm 4: Akış Diyagramları
   - PDF: ders materyalleri klasöründe

2. **"Problem Solving and Algorithm Design"** - Jeanine Meyer
   - Chapter 2: Flowcharts and Pseudocode
   - İngilizce kaynak, çeviri notları mevcut

#### 🌐 Online Kaynaklar
1. **Khan Academy** → "Intro to Programming"
   - https://khanacademy.org/computing/intro-to-programming
   - Türkçe altyazı mevcut

2. **Coursera: Algorithmic Thinking** 
   - https://coursera.org/learn/algorithmic-thinking
   - "Pseudocode Basics" modülü

3. **MIT OpenCourseWare**
   - Introduction to Computer Science
   - Lecture 2: Branching and Iteration

#### 📺 Video Kaynakları
1. **YouTube: "Sözde Kod Nasıl Yazılır?"** (Türkçe)
   - Kanal: Yazılım Bilimi
   - Süre: 25 dakika
   - https://youtube.com/watch?v=example

2. **Udemy: Algorithm Fundamentals**
   - Section 3: Pseudocode and Flowcharts
   - İndirim kodu: STUDENT2024

### 🛠️ Yazılım Araçları ve Uygulamalar

#### 💻 Online Araçlar (Ücretsiz)
1. **Draw.io (diagrams.net)**
   - https://app.diagrams.net/
   - ✅ Tamamen ücretsiz
   - ✅ Kayıt gerektirmez
   - ✅ Türkçe arayüz
   - ✅ Akış diyagramı şablonları

2. **Lucidchart**
   - https://lucidchart.com/
   - ✅ Eğitim hesabı ücretsiz
   - ✅ Gerçek zamanlı iş birliği
   - ⚠️ Sınırlı diyagram sayısı

3. **Flowchart.fun**
   - https://flowchart.fun/
   - ✅ Kod ile diyagram çizimi
   - ✅ Hızlı prototipleme
   - ✅ Markdown desteği

4. **Creately**
   - https://creately.com/
   - ✅ Hazır şablonlar
   - ✅ Takım çalışması

#### 🖥️ Masaüstü Yazılımlar
1. **Flowgorithm** (ÖNERİLEN)
   - http://flowgorithm.org/
   - ✅ Eğitim odaklı
   - ✅ Türkçe dil desteği
   - ✅ Kod çıktısı (C#, Java, Python)
   - ✅ Adım adım çalıştırma

2. **Microsoft Visio**
   - ⚠️ Ücretli (Office 365'e dahil)
   - ✅ Profesyonel kalite
   - ✅ Şablon kütüphanesi

3. **LibreOffice Draw**
   - https://libreoffice.org/
   - ✅ Tamamen ücretsiz
   - ✅ Açık kaynak
   - ✅ Temel akış diyagramı desteği

#### 📱 Mobil Uygulamalar
1. **Flowdia** (Android/iOS)
   - Basit diyagramlar için ideal
   - Dokunmatik optimizasyonu

2. **Grafio** (iPad)
   - Apple Pencil desteği
   - Profesyonel çizim

### 🎯 Pratik Egzersizleri

#### 🏃‍♂️ Hızlı Alıştırmalar (5-10 dk)
1. **Günlük Aktivite Algoritması**
   - Sabah rutininizi sözde kod ile yazın
   - En az 10 adım içermeli
   - Koşullu durumları dahil edin

2. **Basit Karar Ağacı**
   - "Bugün ne giyeceğim?" algoritması
   - Hava durumu, mevsim, ortam faktörleri
   - Akış diyagramı ile çizin

3. **ATM İşlem Akışı**
   - Para çekme işlemini modelleyin
   - PIN doğrulama, bakiye kontrolü
   - Hata durumlarını dahil edin

#### 🎲 Zorlayıcı Problemler (15-30 dk)
1. **Hesap Makinesi Tasarımı**
   - 4 işlem + gelişmiş fonksiyonlar
   - Hata kontrolü ve kullanıcı dostu mesajlar
   - Sürekli çalışma döngüsü

2. **Oyun Skoru Sistemi**
   - Birden fazla oyuncu
   - Skorları karşılaştırma
   - Kazanan belirleme algoritması

3. **Basit Sıralama Algoritması**
   - 5 sayıyı küçükten büyüğe sıralama
   - Adım adım karşılaştırma gösterimi

### 📊 İnteraktif Örnekler

#### 🎮 Scratch Programlama
- https://scratch.mit.edu/
- Görsel programlama ile mantık geliştirme
- Hazır proje: "Akış Diyagramı Çizer"

#### 🔬 Python Tutor
- http://pythontutor.com/
- Kod adım adım takibi
- Algoritma görselleştirme

#### 🧩 Flowgorithm Örnekleri
```
Hazır projeler indirme:
1. Basit_Hesap_Makinesi.fprg
2. Cift_Tek_Kontrol.fprg
3. Faktöriyel_Hesaplama.fprg
4. Fibonacci_Dizisi.fprg

Kurulum: flowgorithm.org/download.html
```

### 📝 Ek Materyaller

#### 📋 Cheat Sheets (Hızlı Referans)
1. **Sözde Kod Komutları**
   ```
   BAŞLA / BITIR
   ← (atama)
   EĞER / DEĞILSE / BITIR
   İÇİN / KOŞUL İKEN
   FONKSİYON / DÖNDÜR
   Yazdır / Al
   ```

2. **Akış Diyagramı Sembolleri**
   ```
   ( ) → Terminal
   [ ] → İşlem  
   / \ → Giriş/Çıkış
   ◊   → Karar
   ○   → Bağlantı
   ```

#### 🎨 Şablonlar
- Boş akış diyagramı şablonu (A4)
- Sözde kod yazım şablonu
- Problem çözme adımları rehberi
- Örnek çözüm formatı

### 🏆 Başarı Kriterleri

#### ✅ Bu Hafta Öğrenmeniz Gerekenler
- [ ] Sözde kod ile basit algoritma yazabilme
- [ ] Akış diyagramı sembollerini tanıma
- [ ] Karar yapılarını doğru uygulama
- [ ] Döngü mantığını kavrama
- [ ] Basit problemleri adım adım çözebilme

#### 📈 Gelecek Hafta İçin Hazırlık
- [ ] Sözde kod örneklerini C# ile karşılaştırma
- [ ] Kontrol yapıları hakkında ön araştırma
- [ ] Visual Studio kurulum hazırlığı

## 5. ⚠️ Sık Yapılan Hatalar ve Çözümleri

### 🚫 Sözde Kod Hataları

#### ❌ HATA 1: Belirsiz İfadeler
```
❌ Yanlış:
BAŞLA
  bir şey yap
  sonuç bul
  göster
BITIR

✅ Doğru:
BAŞLA
  sayı1 ← Kullanıcıdan sayı al
  sayı2 ← Kullanıcıdan sayı al
  toplam ← sayı1 + sayı2
  Yazdır "Toplam: " + toplam
BITIR
```

#### ❌ HATA 2: Eksik Başlangıç/Bitiş
```
❌ Yanlış:
sayı ← 5
toplam ← sayı + 10
Yazdır toplam

✅ Doğru:
BAŞLA
  sayı ← 5
  toplam ← sayı + 10
  Yazdır toplam
BITIR
```

#### ❌ HATA 3: Mantık Hataları
```
❌ Yanlış:
EĞER yaş > 18 İSE
  Yazdır "Reşit"
EĞER yaş < 18 İSE
  Yazdır "Reşit değil"

✅ Doğru:
EĞER yaş >= 18 İSE
  Yazdır "Reşit"
DEĞILSE
  Yazdır "Reşit değil"
BITIR
```

#### ❌ HATA 4: Sonsuz Döngü
```
❌ Yanlış:
i ← 1
KOŞUL i <= 10 İKEN
  Yazdır i
  // i artırılmayı unutulmuş!
BITIR

✅ Doğru:
i ← 1
KOŞUL i <= 10 İKEN
  Yazdır i
  i ← i + 1  // ÇOK ÖNEMLİ!
BITIR
```

#### ❌ HATA 5: Değişken Adlandırma
```
❌ Yanlış:
123sayı ← 5        // Sayı ile başlayamaz
öğrenci-adı ← "Ali" // Tire kullanılamaz
class ← "matematik" // Anahtar kelime

✅ Doğru:
sayı123 ← 5
öğrenciAdı ← "Ali"
sınıf ← "matematik"
```

### 🚫 Akış Diyagramı Hataları

#### ❌ HATA 1: Yanlış Sembol Kullanımı
```
❌ Yanlış: 
[ Sayı al ]           // İşlem sembolü ile giriş
◊ toplam ← a + b ◊    // Karar sembolü ile işlem

✅ Doğru:
/ Sayı al /           // Giriş/çıkış sembolü
[ toplam ← a + b ]    // İşlem sembolü
```

#### ❌ HATA 2: Karar Sembolü Tek Çıkış
```
❌ Yanlış:
◊ a > b ? ◊
    ↓
[ a büyük ]

✅ Doğru:
◊ a > b ? ◊
↙ EVET    HAYIR ↘
[ a büyük ]    [ b büyük ]
```

#### ❌ HATA 3: Kesişen Çizgiler
```
❌ Yanlış:
[A] ——————→ [C]
 ↓     ×      ↑
[B] ——————→ [D]

✅ Doğru: Köprü kullan
[A] ——————→ [C]
 ↓           ↑
[B] ————┐   │
        └———┘
```

#### ❌ HATA 4: Eksik Ok İşaretleri
```
❌ Yanlış:
[BAŞLA] ——— [İşlem] ——— [BITIR]

✅ Doğru:
[BAŞLA] ——→ [İşlem] ——→ [BITIR]
```

### 🛡️ Hata Önleme Stratejileri

#### 📝 Sözde Kod İçin
1. **Planlama Yap:** Çözümü kafanda planla
2. **Adım Adım Yaz:** Her adımı açık yaz
3. **Test Et:** Kafanda veya kağıtta test et
4. **Gözden Geçir:** Mantık hatası var mı kontrol et

#### 📊 Akış Diyagramı İçin
1. **Sembol Rehberi:** Her zaman yanında bulundur
2. **Taslak Çiz:** Önce kaba çiz, sonra düzenle
3. **Akış Takibi:** Baştan sona takip et
4. **Alternatif Yollar:** Tüm koşulları kontrol et

### 🔧 Debugging (Hata Ayıklama) Teknikleri

#### 🕵️ Manual Trace (Elle Takip)
```
Algoritma: En büyük sayıyı bul (3 sayı)
Test değerleri: a=5, b=3, c=7

Adım 1: a=5, b=3, c=7
Adım 2: a >= b ? 5 >= 3 = TRUE
Adım 3: a >= c ? 5 >= 7 = FALSE
Adım 4: c en büyük → c=7 ✅
```

#### 📋 Checklist (Kontrol Listesi)
- [ ] Tüm değişkenler tanımlandı mı?
- [ ] Döngüler sonlanıyor mu?
- [ ] Tüm koşullar ele alındı mı?
- [ ] Giriş/çıkış işlemleri net mi?
- [ ] Özel durumlar (0, negatif) kontrol edildi mi?

## 6. 🎯 Değerlendirme ve Ölçme

### 📊 Lab Çalışması Değerlendirmesi (%100)

#### 🏅 Sözde Kod Yazma (40%)
- **Mükemmel (90-100):** Doğru söz dizimi, net logic, tam çözüm
- **İyi (80-89):** Küçük hatalar, genel logic doğru
- **Orta (70-79):** Mantık doğru ama format hataları
- **Geçer (60-69):** Temel yapı var ama eksikler
- **Geçmez (0-59):** Ciddi mantık hataları

#### 🎨 Akış Diyagramı Çizme (35%)
- **Mükemmel:** Doğru semboller, temiz çizim, tam akış
- **İyi:** Küçük sembol hataları, akış doğru
- **Orta:** Sembol karışıklığı ama logic tamam
- **Geçer:** Temel şekil var ama düzensiz
- **Geçmez:** Yanlış semboller, eksik akış

#### 🗣️ Sunum ve Açıklama (25%)
- **Mükemmel:** Net açıklama, sorulara doğru cevap
- **İyi:** Açıklama yeterli, çoğu soruya cevap
- **Orta:** Temel açıklama, bazı karışıklıklar
- **Geçer:** Çekingen ama temel bilgi var
- **Geçmez:** Konuyu anlamamış

### 🏆 Hafta Sonu Projesi

#### 📋 Proje Konusu: ATM Makinesi Simülasyonu
```
Gereksinimler:
✅ Kullanıcı PIN girişi (3 hak)
✅ Menü sistemi (Para çek, Bakiye, Çıkış)
✅ Para çekme (bakiye kontrolü)
✅ Hata durumları (yanlış PIN, yetersiz bakiye)
✅ Güvenlik (yanlış pin sonrası kart bloke)

Çıktılar:
📝 Sözde kod dosyası (.txt)
📊 Akış diyagramı (.png/.pdf)
📋 Test senaryoları belgesi
🎥 Sunum videosu (5 dk, opsiyonel)
```

#### 📏 Proje Değerlendirme Kriterleri
| Kriter | Ağırlık | Açıklama |
|--------|---------|----------|
| Doğruluk | %40 | Algoritma doğru çalışıyor mu? |
| Detay | %25 | Hata durumları ele alınmış mı? |
| Sunum | %20 | Anlaşılır ve düzenli mi? |
| Yaratıcılık | %15 | Ek özellikler var mı? |

### 📅 Zaman Çizelgesi
- **Pazartesi:** Lab çalışması başlangıç
- **Çarşamba:** Proje duyurusu ve grup oluşturma
- **Cuma:** Ara kontrol ve soru-cevap
- **Gelecek Pazartesi:** Proje teslimi (23:59'a kadar)
- **Gelecek Çarşamba:** Sunum günü

## 7. 🚀 Sonraki Hafta Hazırlığı

### 📋 Gelecek Hafta Konuları
- 🔀 **Karar yapıları** (if-else, switch-case)
- 🔁 **Döngü türleri** (for, while, do-while)
- 🏗️ **İç içe yapılar** (nested structures)
- 🎯 **Algoritmadan kod geçişi**

### 📚 Ön Hazırlık Önerileri
1. **Video izle:** "Control Structures in Programming" (YouTube)
2. **Okuma:** Ders kitabı Bölüm 5-6
3. **Pratik:** Bu haftaki örnekleri tekrarla
4. **Araştır:** If-else vs switch-case farkları

### 🎯 Kendini Test Et
> Gelecek hafta için hazır mısın? Bu soruları cevaplayabilir misin?
- Sözde kodda IF-ELSE nasıl yazılır?
- Döngü ne zaman kullanılır?
- İç içe yapı örneği verebilir misin?

---

## 8. 📋 Ödev ve Uygulamalar

### 📖 Teorik Ödev (30% - Bireysel)

#### 🎯 Soru 1: Karşılaştırmalı Analiz (200 kelime)
**"Sözde kod ile akış diyagramı arasındaki farkları detaylı olarak açıklayın."**

**Açıklama kriterleri:**
- Tanımları yap
- Avantaj/dezavantajları listele
- Hangi durumlarda hangisini tercih edersin?
- Bir örnekle açıkla

#### 🎯 Soru 2: Uygulama Analizi (150 kelime)
**"Hangi durumlarda akış diyagramı, hangi durumlarda sözde kod kullanmak daha avantajlıdır? Gerçek hayat örnekleri verin."**

**Beklenen örnekler:**
- Yazılım geliştirme süreçleri
- Eğitim materyali hazırlama
- Takım çalışması
- Dokümantasyon

### 🛠️ Pratik Ödev (70% - Bireysel/İkili)

#### 🏆 Zorunlu Görevler

##### 📊 Görev 1: VKİ Hesaplama Sistemi
**Konu:** Sağlık Uygulaması Algoritması
**Zorluk:** ⭐⭐ Orta
**Süre:** 30 dakika

**Gereksinimler:**
```
📥 GIRDILER:
- Kişinin kilosu (kg)
- Kişinin boyu (cm)
- Kişinin yaşı
- Cinsiyet (E/K)

🔄 İŞLEMLER:
- VKİ hesaplama: VKİ = kilo / (boy/100)²
- Kategori belirleme:
  * VKİ < 18.5  → Zayıf
  * 18.5 ≤ VKİ < 25 → Normal
  * 25 ≤ VKİ < 30 → Kilolu
  * VKİ ≥ 30 → Obez
- Yaşa göre önerileri ekle:
  * 18 yaş altı → "Doktora danışın"
  * 65 yaş üstü → "Özel takip gerekli"

📤 ÇIKTILAR:
- VKİ değeri
- Kategori
- Sağlık önerisi
- Yaş grupuna göre uyarı
```

**Teslim Formatı:**
- [ ] Sözde kod (.txt dosyası)
- [ ] Akış diyagramı (.png/.pdf)
- [ ] Test senaryoları (minimum 5 farklı durum)

##### 🧮 Görev 2: Gelişmiş Hesap Makinesi
**Konu:** Menü Sistemli Hesaplayıcı
**Zorluk:** ⭐⭐⭐ İleri
**Süre:** 45 dakika

**Gereksinimler:**
```
📋 MENÜ SİSTEMİ:
1. Toplama
2. Çıkarma  
3. Çarpma
4. Bölme
5. Üs alma
6. Karekök
7. Faktöriyel
8. Çıkış

🔒 GÜVENLİK KONTROLLERI:
- Sıfıra bölme kontrolü
- Negatif sayının karekökü
- Faktöriyel için negatif kontrol
- Geçersiz menü seçimi

🔄 SÜREKLİ ÇALIŞMA:
- İşlem sonrası menüye dön
- "Çıkış" seçilene kadar devam et
- Her işlem sonrası "Devam etmek istiyor musunuz?"
```

**Teslim Formatı:**
- [ ] Sözde kod (switch-case kullanarak)
- [ ] Akış diyagramı (ana menü + alt işlemler)
- [ ] Hata senaryoları listesi

##### 🔢 Görev 3: En Büyük/Küçük Sayı Bulma
**Konu:** Karşılaştırma Algoritması
**Zorluk:** ⭐⭐ Orta
**Süre:** 25 dakika

**Gereksinimler:**
```
📥 GİRDİ:
- Kaç sayı karşılaştırılacak (N)
- N adet sayı

🔄 İŞLEM:
- En büyük sayıyı bul
- En küçük sayıyı bul
- Aralığı hesapla (en büyük - en küçük)
- Ortalamayı hesapla

📤 ÇIKTI:
- En büyük sayı ve kaçıncı sırada
- En küçük sayı ve kaçıncı sırada  
- Aralık değeri
- Ortalama değer
- Eşitlik durumları (varsa)
```

**Özel Durumlar:**
- Tüm sayılar eşit → "Tüm sayılar eşit"
- Sadece iki sayı → Basit karşılaştırma
- Tek sayı → "Karşılaştırma yapılamaz"

#### 🌟 Bonus Görevler (Ek Puan)

##### 🎮 Bonus 1: Sayı Tahmin Oyunu
**Konu:** İnteraktif Oyun Algoritması
**Zorluk:** ⭐⭐⭐⭐ Uzman
**Süre:** 60 dakika

**Gereksinimler:**
```
🎯 OYUN KURALLARI:
- Bilgisayar 1-100 arası sayı tutar
- Kullanıcının 7 tahmin hakkı vardır
- Her yanlış tahminde ipucu verilir:
  * "Daha büyük bir sayı deneyin"
  * "Daha küçük bir sayı deneyin"
- Skor sistemi:
  * 1-2 tahminde → 100 puan
  * 3-4 tahminde → 80 puan
  * 5-6 tahminde → 60 puan
  * 7. tahminde → 40 puan
  * Bilemezse → 0 puan

🎨 ÖZELLİKLER:
- Oyun tekrarı option
- En yüksek skor takibi
- Zorluk seviyeleri (aralık değişimi)
```

##### 🧩 Bonus 2: Basit Şifreleme/Çözme
**Konu:** Caesar Cipher Algoritması
**Zorluk:** ⭐⭐⭐⭐ Uzman
**Süre:** 90 dakika

### 📤 Teslim Kuralları

#### 📅 Teslim Tarihi
**Son Tarih:** Gelecek Pazartesi 23:59
**Geç Teslim Cezası:** Her gün için -10 puan

#### 📁 Dosya Formatı
```
Klasör Adı: Hafta02_AdınızSoyadınız_ÖğrenciNo
├── Teorik_Ödev.pdf
├── VKI_Hesaplama/
│   ├── VKI_SözdeKod.txt
│   ├── VKI_AkışDiyagramı.png
│   └── VKI_TestSenaryoları.pdf
├── Hesap_Makinesi/
│   ├── HesapMakinesi_SözdeKod.txt
│   ├── HesapMakinesi_AkışDiyagramı.png
│   └── HesapMakinesi_HataAnalizi.pdf
└── EnBuyuk_Kucuk/
    ├── Karşılaştırma_SözdeKod.txt
    ├── Karşılaştırma_AkışDiyagramı.png
    └── Karşılaştırma_TestRaporu.pdf
```

#### 🎯 Değerlendirme Kriterleri

| Kriter | Ağırlık | Açıklama |
|--------|---------|----------|
| **Doğruluk** | 40% | Algoritma mantığı doğru mu? |
| **Detay Seviyesi** | 25% | Hata durumları ele alınmış mı? |
| **Sunum Kalitesi** | 20% | Anlaşılır ve düzenli mi? |
| **Yaratıcılık** | 10% | Ek özellikler ve yenilikler |
| **Test Kapsamı** | 5% | Yeterli test senaryosu var mı? |

#### 🏅 Başarı Seviyeleri
- **90-100:** Mükemmel → Tüm gereksinimler karşılanmış, bonus özellikler eklenmiş
- **80-89:** Çok İyi → Temel gereksinimler tamam, küçük eksikler
- **70-79:** İyi → Ana algoritma doğru, bazı detaylar eksik
- **60-69:** Geçer → Temel yapı var ama ciddi eksikler
- **0-59:** Başarısız → Temel gereksinimleri karşılamıyor

### 💡 İpuçları ve Öneriler

#### ✅ Başarı için Öneriler
1. **Planlama Yap:** Önce problemi anlayın, sonra çözün
2. **Adım Adım İlerle:** Küçük parçalara böl
3. **Test Et:** Her adımı kafada test et
4. **Temiz Çiz:** Okunaklı ve düzenli ol
5. **Yardım İste:** Anlamadığın yeri sor

#### ⚠️ Dikkat Edilmesi Gerekenler
- Sözde kod kurallarına uy
- Akış diyagramı sembollerini doğru kullan
- Tüm test senaryolarını düşün
- Hata durumlarını unutma
- Zamanını iyi planla

#### 🤝 İş birliği Kuralları
- İkili çalışabilirsiniz ama herkes teslim etmeli
- Fikirlerinizi paylaşın ama kopyalamayın
- Kaynak göstermeyi unutmayın
- Özgün çalışma yapın

### 📞 Yardım ve Destek

#### 🕐 Ofis Saatleri
- **Pazartesi:** 14:00-16:00
- **Çarşamba:** 10:00-12:00
- **Cuma:** 15:00-17:00

#### 💬 İletişim Kanalları
- **Email:** hoca@universite.edu.tr
- **Discord:** #hafta02-sorular kanalı
- **Whatsapp:** Grup: "Hafta02 Ödev Desteği"

#### 📚 Ek Kaynaklar
- **Video Tutorial:** "Akış Diyagramı Çizimi" (25 dk)
- **Canlı Ders:** Çarşamba 19:00-20:00 (Zoom)
- **Çalışma Grubu:** Cumartesi 14:00-16:00 (Sınıf)

---

## 📞 İletişim ve Destek

### 👨‍🏫 Öğretim Üyesi İletişim
**Ad:** Dr. [Öğretmen Adı]
**Email:** [email@universite.edu.tr]
**Ofis:** [Oda Numarası]
**Tel:** [Telefon Numarası]

### 🕐 Ofis Saatleri
- **Pazartesi:** 14:00-16:00
- **Çarşamba:** 10:00-12:00  
- **Cuma:** 15:00-17:00

### 💬 Online Destek
- **Discord Server:** Algoritma ve Programlama 2025
- **WhatsApp Grubu:** Hafta02 Soru-Cevap
- **Email Destek:** 24 saat içinde yanıt

---

**🎯 Bu hafta sonu, algoritma dünyasında yeni bir aşamaya geçiyoruz! Başarılar dilerim! 🚀**
