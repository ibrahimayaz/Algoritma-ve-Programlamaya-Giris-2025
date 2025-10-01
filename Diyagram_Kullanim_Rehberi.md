# Draw.io Diyagram Kullanım Rehberi

Bu rehber; projedeki tüm `.drawio` diyagramlarının tutarlı, erişilebilir ve bakımı kolay olacak şekilde oluşturulması ve gömülmesi için standartları belirler.

---
## 1. Amaç
- ✅ Tek tip görünüm ve öğrenme deneyimi
- ✅ Kolay bakım ve genişletilebilirlik
- ✅ Çevrimdışı / kurumsal ağ senaryolarında erişilebilirlik
- ✅ Otomatik referans ve link düzeni

---
## 2. Dosya Konumlandırma ve Adlandırma
Her hafta için `HaftaXX/draw_io_files/` klasörü kullanılır.

Adlandırma Formatı:
```
NN_konu_ozeti.drawio
```
- `NN`: 01, 02, 03 ... iki haneli sıra numarası
- `konu_ozeti`: Küçük harf, Türkçe karakter kullanılabilir, boşluk yerine `_`

Örnekler:
```
01_toplama_algoritmasi.drawio
02_cift_tek_kontrol.drawio
09_atm_sistemi.drawio
10_hesap_makinesi.drawio
```

---
## 3. Diyagram İç Tasarım Standartları

### 3.1 Renk Kodları
| Anlam | Şekil | Renk | Hex |
|-------|-------|------|-----|
| Başlangıç / Bitiş | Oval | Yeşil / Kırmızı | #d5e8d4 / #f8cecc |
| Giriş / Çıkış | Paralelkenar | Mavi | #dae8fc |
| İşlem | Dikdörtgen | Sarı | #fff2cc |
| Karar | Elmas | Mor | #e1d5e7 |
| Uyarı / Hata | Dikdörtgen | Açık Kırmızı | #f8cecc |
| Açıklama Notu | Yuvarlatılmış | Gri | #f0f0f0 |

### 3.2 Font & Boyutlar
- Font: Varsayılan (Arial) – 14pt başlık benzeri düğümler, 12pt içerik
- Kenar Kalınlığı: 1px
- Oklar: Yön gösteren (Arrow end) zorunlu
- Karar şekillerinde iki çıkış etiketlenmeli: `EVET` / `HAYIR` veya `TRUE` / `FALSE`

### 3.3 Düzen
- Akış yönü: Üstten aşağı + soldan sağa
- Kesişen çizgilerden kaçının (gerekirse yön noktaları ekleyin)
- Döngü geri dönüş hattı mümkün olduğunca soldan veya sağdan dış kenardan

---
## 4. Gömme (Embed) Standartları
Markdown içine iframe ile ekleme formatı:
```
<iframe frameborder="0" loading="lazy" style="width:100%;height:420px;" src="https://viewer.diagrams.net/?lightbox=1&target=blank&nav=1&title=DOSYA_ADI.drawio#URAW_URL_ENCODE"></iframe>
<details><summary>⚠️ Açılmıyorsa (alternatif erişim)</summary>
Yerel aç: `HaftaXX/draw_io_files/DOSYA_ADI.drawio` → https://app.diagrams.net/ → File → Open From → Device.
</details>
```

`RAW_URL_ENCODE` değeri şu formatı izler:
```
https%3A%2F%2Fraw.githubusercontent.com%2Fibrahimayaz%2FAlgoritma-ve-Programlamaya-Giris-2025%2Fmain%2FHaftaXX%2Fdraw_io_files%2FDOSYA_ADI.drawio
```

---
## 5. Çevrimdışı / Ağ Engeli Durumunda Erişim
1. `.drawio` dosyasını dosya gezgininden seçin
2. https://app.diagrams.net/ açın
3. File → Open From → Device → dosyayı seçin
4. Gerekirse düzenleyin / PNG olarak dışa aktarın (File → Export as → PNG)

### PNG Üretim Önerisi
- Saydam arka plan: Kapalı
- Kenarlık: 10px
- Ölçek: 1x yeterli (metin okunabilir olmalı)

---
## 6. Versiyonlama
- Diyagram yapısal olarak değişiyorsa (mantık değişikliği): Versiyon notu ekleyin
- Değişiklik kaydı formatı (diyagramın altında veya haftanın sonunda):
```
> Değişiklik: 2025-10-01 – Döngü koşulu güncellendi (i < 10 → i <= 10)
```

---
## 7. Sorun Giderme
| Sorun | Olası Neden | Çözüm |
|-------|-------------|-------|
| Diyagram boş görünüyor | İçerik engelleyici | Farklı tarayıcı / uzantıyı devre dışı bırak | 
| iframe çalışmıyor | Güvenlik politikası | Yerel açma yöntemi kullan |
| Renkler tutarsız | Elle değiştirilmiş | Tabloya göre yeniden ayarla |
| Döngü okunmuyor | Karmaşık akış | Alt diyagrama böl (ayrı .drawio) |

---
## 8. Yeni Diyagram Eklerken Kontrol Listesi
- [ ] Adlandırma formatı doğru mu?
- [ ] Renkler tabloda belirtildiği gibi mi?
- [ ] Karar bloklarının iki çıkışı var mı?
- [ ] Döngü geri dönüş oku net mi?
- [ ] iframe URL’si doğru encode edildi mi?
- [ ] `<details>` fallback eklendi mi?
- [ ] Rehber linki haftanın dosyasında var mı?

---
## 9. Örnek Tam Embed
```
**Draw.io Akış Diyagramı (Gömülü):**
<iframe frameborder="0" loading="lazy" style="width:100%;height:420px;" src="https://viewer.diagrams.net/?lightbox=1&target=blank&nav=1&title=ornek.drawio#Uhttps%3A%2F%2Fraw.githubusercontent.com%2Fibrahimayaz%2FAlgoritma-ve-Programlamaya-Giris-2025%2Fmain%2FHafta99%2Fdraw_io_files%2Fornek.drawio"></iframe>
<details><summary>⚠️ Açılmıyorsa (alternatif erişim)</summary>
Yerel aç: `Hafta99/draw_io_files/ornek.drawio`
</details>
```

---
## 10. Gelecek İyileştirmeler (Opsiyonel)
- Otomatik script ile `.drawio` → `.png` batch export
- Haftalar arası diyagram indeks sayfası
- Diyagram karmaşıklık ölçütü (düğüm ve bağlantı sayısı)

---
Bu rehberi güncellemek için pull request açabilirsiniz.
