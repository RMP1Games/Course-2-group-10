using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180325_.Models
{
    internal class Book
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string author { get; set; }
        [Required]
        public string genre { get; set; }
    }
}
