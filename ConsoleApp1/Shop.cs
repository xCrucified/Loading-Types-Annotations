using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shop
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required] public string Name { get; set; }
        public string Address { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        public int? ParkingArea { get; set; }
        public City City { get; set; }
        public ICollection<Worker> Workers { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}