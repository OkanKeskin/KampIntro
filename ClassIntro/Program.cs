using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.Egitmen = "Okan Keskin";
            kurs4.KursAdi = "Okan#";
            kurs4.IzlenmeOrani = 100;

            // Console.WriteLine(kurs1.Egitmen + " : " + kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            //foreach(VERİTİPİ TAKMAAD İN DİZİ)
            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.Egitmen + " : " +kurs.KursAdi);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
