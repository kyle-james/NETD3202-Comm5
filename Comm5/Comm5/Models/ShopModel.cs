using System;
using System.ComponentModel.DataAnnotations;
using Comm5.Models;

namespace Comm5.Models
{
    public class ShopModel
    {
        [Key]
        public int skuId { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        public ShopModel()

        {

        }
        public ShopModel(int skuId, string name, double price)
        {
            this.skuId = skuId;
            this.name = name;
            this.price = price;
        }
            
    }
}
