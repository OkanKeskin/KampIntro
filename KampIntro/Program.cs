using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği = veri türü belirtmek gerekir
            //Do not repeat yourself = Kendini tekrarlama
            //değer tutucu, alias = kategoriEtiketi

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }




            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giris yap");
            }
            
            Console.WriteLine(kategoriEtiketi);

              
        }
    }
}
