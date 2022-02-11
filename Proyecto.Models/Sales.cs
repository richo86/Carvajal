using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Models
{
    public class Sales
    {
        public int id { get; set; }
        public DateTime saleDate { get; set; }
        public int ProductId { get; set; }
        public long Quantity { get; set; }
        public long Price { get; set; }
        public string Type { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
    }
}
