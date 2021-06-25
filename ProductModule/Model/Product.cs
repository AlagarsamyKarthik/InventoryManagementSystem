using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductModule.Model
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Prod_Id { get; set; }
        public string Prod_Name { get; set; }
        public string Prod_Desc { get; set; }
        public decimal Prod_Price { get; set; }
        public int Prod_Qty { get; set; }
        public string Prod_Status { get; set; }

    }
}
