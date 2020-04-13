using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClothingStore.Models
{
    public class Cart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public String UserName { get; set; }
        public int itemId { get; set; }
        public string itemName { get; set; }
        public string itemImageUrl { get; set; }
        public double itemPrice { get; set; }

    }
}