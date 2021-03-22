using System;
using System.Collections.Generic;

namespace MyDictionart
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> sehirler = new MyDictionary<string>();
            sehirler.Add("Okan");
            sehirler.Add("Keskin");

            sehirler.Listing();
        }
    }
}
