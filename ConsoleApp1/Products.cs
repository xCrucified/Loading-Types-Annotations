using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Products
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required] public string Name { get; set; }
        [Required] public decimal Price { get; set; }
        [Required] public float Discount { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public int Quantity { get; set; }
        public bool isinStock { get; set; }
        public Category Category { get; set; }
        public ICollection<Shop> Shops { get; set; }
    }
}