using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

        public Item()
        {

        }
    }
}
