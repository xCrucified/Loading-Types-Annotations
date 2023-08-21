using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Position
    {
        public int Id { get; set; }

        [MaxLength(100)]
        [Required] public string Name { get; set; }
        public ICollection<Worker> Workers { get; set; }
    }
}
