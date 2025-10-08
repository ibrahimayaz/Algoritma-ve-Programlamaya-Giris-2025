# Hafta 01: Algoritma Nedir? Temel Kavramlar

## Ders Hedefleri
Bu dersin sonunda öğrenciler:
- Algoritma kavramını tanımlayabilecek
- Algoritma çözümleme yöntemlerini öğrenecek
- Basit algoritmalar yazabilecek

## 1. Algoritma Nedir?

### Tanım
**Algoritma**, belirli bir problemi çözmek için takip edilmesi gereken adım adım talimatlar dizisidir. Günlük hayatta pek çok algoritmayı kullanırız:

- **Çay yapma algoritması:**
  1. Çaydanlığı su ile doldur
  2. Suyu kaynat
  3. Çay yapraklarını demliğe koy
  4. Kaynayan suyu demliğe dök
  5. 5 dakika demle
  6. Servis et

### Algoritmanın Özellikleri
1. **Giriş (Input):** Algoritmanın işlemesi için gerekli veriler
2. **Çıkış (Output):** Algoritmanın ürettiği sonuç
3. **Kesinlik:** Her adım net ve anlaşılır olmalı
4. **Sonluluk:** Algoritma belirli bir süre sonra sonlanmalı
5. **Etkinlik:** Gereksiz adımlar olmamalı

## 2. Program Nedir?

**Program**, bir algoritmanın bilgisayar dilinde yazılmış halidir. Bilgisayarın anlayabileceği komutlar dizisidir.

### Program vs Algoritma
- **Algoritma:** İnsan dilinde yazılmış çözüm adımları
- **Program:** Bilgisayar dilinde yazılmış algoritma

## 3. Programlama Nedir?

**Programlama**, bir problemi çözmek için algoritma tasarlama ve bunu bilgisayar dilinde yazma sürecidir.

### Programlama Süreci
1. **Problem Analizi:** Problemi anlama
2. **Algoritma Tasarımı:** Çözüm adımlarını belirleme
3. **Kodlama:** Algoritmayı program diline çevirme
4. **Test Etme:** Programın doğru çalıştığını kontrol etme
5. **Hata Ayıklama:** Hataları bulma ve düzeltme

## 4. Algoritma Çözümleme Yöntemleri

### 4.1 Doğal Dil (Günlük Dil)
En basit yöntemdir. Algoritma Türkçe olarak yazılır.

**Örnek - Toplama Algoritması:**
```
1. İki sayı al
2. Bu sayıları topla
3. Sonucu göster
```

### 4.2 Sözde Kod (Pseudocode)
Programlama diline yakın ama insan tarafından da anlaşılabilir yazım.

**Örnek - En Büyük Sayı Bulma:**
```
BAŞLA
  sayı1 ← Kullanıcıdan sayı al
  sayı2 ← Kullanıcıdan sayı al
  sayı3 ← Kullanıcıdan sayı al
  
  EĞER sayı1 > sayı2 VE sayı1 > sayı3 İSE
    enBüyük = sayı1
  DEĞILSE EĞER sayı2 > sayı3 İSE
    enBüyük = sayı2
  DEĞILSE
    enBüyük = sayı3
  
  Yazdır "En büyük sayı: " + enBüyük
BITIR
```

### 4.3 Akış Diyagramları
Algoritmanın görsel temsilidir.

**Akış Diyagramı Sembolleri:**
- **Oval:** Başla/Bitir
- **Paralelkenar:** Giriş/Çıkış
- **Dikdörtgen:** İşlem
- **Baklava:** Karar/Koşul
- **Ok:** Akış yönü

## 5. Detaylı Örnekler

### Örnek 1: Toplama Algoritması
**Problem:** İki sayıyı toplayan algoritma

**Doğal Dil:**
1. Birinci sayıyı al
2. İkinci sayıyı al
3. İki sayıyı topla
4. Sonucu göster

**Sözde Kod:**
```
BAŞLA
  a ← Kullanıcıdan sayı al
  b ← Kullanıcıdan sayı al
  toplam = a + b
  Yazdır "Toplam: " + toplam
BITIR
```

### Örnek 2: Sayı Ortalaması Hesaplama
**Problem:** 3 sayının ortalamasını hesapla

**Sözde Kod:**
```
BAŞLA
  sayı1 ← Kullanıcıdan sayı al
  sayı2 ← Kullanıcıdan sayı al
  sayı3 ← Kullanıcıdan sayı al
  
  toplam = sayı1 + sayı2 + sayı3
  ortalama = toplam / 3
  
  Yazdır "Ortalama: " + ortalama
BITIR
```

### Örnek 3: Basit Sıralama Algoritması (2 sayı)
**Problem:** İki sayıyı küçükten büyüğe sırala

**Sözde Kod:**
```
BAŞLA
  a ← Kullanıcıdan sayı al
  b ← Kullanıcıdan sayı al
  
  EĞER a > b İSE
    temp = a
    a = b
    b = temp
  
  Yazdır a + " " + b
BITIR
```

## 6. Ders Materyalleri

### Okuma Listesi
1. **Kitap:** "Algoritma ve Programlama Temelleri" - Bölüm 1-2
2. **Online Kaynak:** Khan Academy - "Intro to Algorithms"
3. **Video:** "What is an Algorithm?" - YouTube

### Pratik Egzersizleri
1. Günlük hayattan 5 algoritma örneği bulun
2. Çay yapma algoritmasını akış diyagramı ile çizin
3. Okula gitme algoritmanızı sözde kod ile yazın

### Değerlendirme Kriterleri
- Algoritma tanımını doğru yapabilme (%25)
- Sözde kod yazabilme (%35)
- Problem çözme yaklaşımı (%40)

## Sonraki Hafta Hazırlığı
- Akış diyagramı sembolleri
- Sözde kod kuralları
- Karar yapıları ve döngüler hakkında ön bilgi

## Ödev
1. **Teorik Ödev:** Algoritma kavramını kendi kelimelerinizle açıklayın (min. 200 kelime)
2. **Pratik Ödev:** Aşağıdaki problemler için sözde kod yazın:
   - Bir sayının çift mi tek mi olduğunu bulan algoritma
   - İki sayının büyüğünü bulan algoritma
   - Üç sayının en küçüğünü bulan algoritma
3. **Akış Diyagramı:** Yukarıdaki problemlerden birini akış diyagramı ile çizin
