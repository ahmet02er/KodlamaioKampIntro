using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        //Ürünün Kategorisi
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //Ürünün Birim Fiyatı
        public double UnitPrice { get; set; }
        //Ürünün Stok Adedi
        public int UnitInStock { get; set; }
    }
}
