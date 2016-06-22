using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetShopCosmetics.Models
{
    public class Product
    {
        public int Id { get; set; }    // id товара

        public string Name { get; set; }   // название товара

        public string Description { get; set; }   // описание товара
        
        //public string Text { get; set; }

        public int Price { get; set; }        // цена товара

    }
}