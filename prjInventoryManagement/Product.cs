using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjInventoryManagement
{
    //custom type
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }   // changed from string? to int
        public decimal Price { get; set; }  // changed from string? to decimal

    }
}
