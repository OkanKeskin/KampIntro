using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product  //Entity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }  //Kategoriler Id ile belirtilir ve 2.sıraya yazılır.
        public string ProductName { get; set; } //Ürün adı
        public double UnitPrice { get; set; }  //ürün fiyatı
        public int UnitsInStock { get; set; }  //Stok Adedi

    }
}
