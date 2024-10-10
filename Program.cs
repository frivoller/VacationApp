using System;

class SeyahatUygulamasi
{
    static void Main(string[] args)
    {
        bool devam = true;

        while (devam)
        {
            // lokasyon fiyatlari
            int bodrumFiyat = 4000;
            int marmarisFiyat = 3000;
            int cesmeFiyat = 5000;

            // ulasim ucretleri
            int karaYoluUcreti = 1500;
            int havaYoluUcreti = 4000;

            // lokasyon secimi
            string lokasyon = "";
            while (true)
            {
                Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçiniz: Bodrum, Marmaris, Çeşme");
                lokasyon = Console.ReadLine().ToLower();

                if (lokasyon == "bodrum" || lokasyon == "marmaris" || lokasyon == "çeşme")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Lütfen geçerli bir lokasyon seçiniz: Bodrum, Marmaris, Çeşme");
                }
            }

            // kisi sayisi
            Console.WriteLine("Kaç kişi için tatil planlıyorsunuz?");
            int kisiSayisi = Convert.ToInt32(Console.ReadLine());

            // lokasyon ozet bilgisi
            switch (lokasyon)
            {
                case "bodrum":
                    Console.WriteLine($"Bodrum seçtiniz. Bodrum'da harika plajlar, gece hayatı ve tarihi yerler sizi bekliyor.");
                    break;
                case "marmaris":
                    Console.WriteLine($"Marmaris seçtiniz. Marmaris'te doğa harikaları, tekne turları ve muhteşem koylar tatilinize renk katacak.");
                    break;
                case "çeşme":
                    Console.WriteLine($"Çeşme seçtiniz. Çeşme'de ünlü plajlar, sıcak termal sular ve Ege'nin muhteşem atmosferi sizi bekliyor.");
                    break;
            }

            // ulasim secimi
            int ulasimUcreti = 0;
            while (true)
            {
                Console.WriteLine("Tatilinize ne şekilde gitmek istiyorsunuz? 1 - Kara Yolu (Kişi başı 1500 TL), 2 - Hava Yolu (Kişi başı 4000 TL)");
                string ulasimSecimi = Console.ReadLine();

                if (ulasimSecimi == "1")
                {
                    ulasimUcreti = karaYoluUcreti;
                    break;
                }
                else if (ulasimSecimi == "2")
                {
                    ulasimUcreti = havaYoluUcreti;
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız. Lütfen 1 ya da 2 seçeneklerinden birini seçiniz.");
                }
            }

            // lokasyona gore tatil paket fiyati belirleme
            int tatilPaketiFiyati = 0;
            if (lokasyon == "bodrum")
            {
                tatilPaketiFiyati = bodrumFiyat;
            }
            else if (lokasyon == "marmaris")
            {
                tatilPaketiFiyati = marmarisFiyat;
            }
            else if (lokasyon == "çeşme")
            {
                tatilPaketiFiyati = cesmeFiyat;
            }

            // toplam fiyat hesaplama
            int toplamFiyat = (tatilPaketiFiyati + ulasimUcreti) * kisiSayisi;
            Console.WriteLine($"Toplam fiyat: {toplamFiyat} TL");

            // baska bir tatil plani yapmak isteyip istemedigini sorma
            Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet/Hayır)");
            string devamMi = Console.ReadLine().ToLower();

            if (devamMi != "evet")
            {
                Console.WriteLine("İyi günler dileriz.");
                devam = false;
            }
        }
    }
}
