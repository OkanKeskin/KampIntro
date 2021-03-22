using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Bir şablondur.
    //İnterfaceler I ile başlar ve ebecey görevinde hepsinde zorunlu olması gereken seyleri soyler.
    //Kural tutar.
    //Genelde operasyonel classlar interfacetir.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
