using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetailsConsoleAppAssignment
{
    public class Product
    {
        public string Pname { get; set; }
        public float Pprice { get; set; }
        public string? PBrand { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }


    }
}
