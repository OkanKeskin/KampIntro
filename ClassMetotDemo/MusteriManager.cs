using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Sayın "+ musteri.Ad +" "+musteri.Soyad+ " başarıyla kaydınız oluşturuldu");

        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " isimli müşterinin kaydı silindi");

        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.TcNo + " " + musteri.Id + " " + "listelendi");

        }


    }
}
