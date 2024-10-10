# Seyahat Planlama Uygulaması

Bu C# konsol uygulaması, kullanıcıların Bodrum, Marmaris ve Çeşme için 3 günlük tatil planlamasına ve tatil boyunca harcayacakları tahmini tutarı hesaplamalarına yardımcı olur.

## Özellikler

- Kullanıcıdan gitmek istediği tatili ve kişi sayısını seçmesini sağlar.
- Seçilen lokasyona göre kısa bir özet bilgi verir.
- Kara yolu veya hava yolu ile ulaşım seçenekleri sunar.
- Tatil paketi fiyatları ve ulaşım seçeneklerine göre toplam maliyeti hesaplar.
- Kullanıcıya başka bir tatil planlamak isteyip istemediğini sorar ve programı devam ettirir veya sonlandırır.

## Desteklenen Lokasyonlar ve Başlangıç Fiyatları

1. **Bodrum**: 4000 TL
2. **Marmaris**: 3000 TL
3. **Çeşme**: 5000 TL

## Ulaşım Seçenekleri ve Fiyatlar

- **Kara Yolu**: Kişi başı 1500 TL (gidiş-dönüş)
- **Hava Yolu**: Kişi başı 4000 TL (gidiş-dönüş)

## Kullanım

1. Uygulama başlatıldığında, kullanıcıdan gitmek istediği lokasyonu seçmesi istenir.
    - Geçerli lokasyonlar: Bodrum, Marmaris, Çeşme
    - Lokasyon seçiminde büyük/küçük harf duyarlılığı yoktur.
    - Hatalı girişlerde kullanıcıya geçerli seçenekler hatırlatılır.

2. Kaç kişi için tatil planlandığı sorulur.

3. Seçilen lokasyona göre bir özet bilgi ekrana yazdırılır.

4. Kullanıcıdan ulaşım şekli (kara yolu veya hava yolu) seçmesi istenir.
    - Geçersiz bir seçim yapıldığında hata mesajı gösterilir ve yeniden giriş istenir.

5. Uygulama, kişi sayısına göre tatil paketi ve ulaşım maliyetlerini hesaplar ve ekrana toplam tutarı yazdırır.

6. Kullanıcıya başka bir tatil planlamak isteyip istemediği sorulur:
    - **Evet**: Uygulama tekrar başlar.
    - **Hayır**: Program sonlandırılır ve kullanıcıya iyi günler dilenir.

## Geliştirici Bilgileri

Bu uygulama, kullanıcıların tatil planlarını kolaylaştırmak amacıyla basit bir şekilde hazırlanmıştır. Uygulama örnek fiyatlar ve ulaşım seçenekleri kullanarak tahmini bir bütçe sunar.
