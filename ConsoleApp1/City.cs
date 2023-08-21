using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class City
    {
        public int Id { get; set; }

        [MaxLength(100)]

        [Required] public string Name { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        Country Country { get; set; }
    }
}
