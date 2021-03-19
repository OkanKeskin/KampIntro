using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Okan";
            musteri1.Id = 1;
            musteri1.Soyad = "Keskin";
            musteri1.TcNo = "11111111111";
            musteri1.Yas = 21;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Aşkıncan";
            musteri2.Id = 2;
            musteri2.Soyad = "Ergani";
            musteri2.TcNo = "11111111000";
            musteri2.Yas = 19;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Sefa";
            musteri3.Id = 3;
            musteri3.Soyad = "İstanbul";
            musteri3.TcNo = "11100000011";
            musteri3.Yas = 20;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriListele(musteri3);

        }
    }
}
