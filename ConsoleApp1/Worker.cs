using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Worker
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required] public string Name { get; set; }
        [MaxLength(100)]
        [Required] public string Surname { get; set; }
        [Required] public decimal Salary { get; set; }
        [MinLength(15)]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        [ForeignKey("Position")]
        public int PositionId { get; set; }

        [ForeignKey("Shop")]
        public int ShopId { get; set; }
        public Shop Shop { get; set; }
        public Position Position { get; set; }
    }
}
