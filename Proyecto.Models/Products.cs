    using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Models
{
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public Categorias category { get; set; }
        public string description { get; set; }
        public long price { get; set; }
        public string imagePath { get; set; }
        
    }
}
