using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(List<IKrediManager> krediManagers, List<ILoggerService> loggerServices)
        {
            //Basvuran bilgileri değerlendirme.
            //
            foreach (var krediManager in krediManagers)
            {
                krediManager.Hesapla();
            }

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
