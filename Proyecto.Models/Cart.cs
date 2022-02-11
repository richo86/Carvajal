using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Models
{
    public class Cart
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public long Quantity { get; set; }
        public long Price { get; set; }
        public string imagePath { get; set; }
    }
}
