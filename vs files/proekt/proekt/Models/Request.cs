using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace proekt.Models
{
    public class Request
    {
        [Required]
        public int id { get; set; }
        [Required]
        string requestName { get; set; }
        [Required]
        string smallRequestDesc { get; set; }
        [Required]
        string requestDesc { get; set; }
        string methodsOfRealization { get; set; }
        string examples {  get; set; }
        [Required]
        string authorUsername { get; set; }
        public int likes { get; set; }
        public int dislikes { get; set; }
        public List<string> comments { get; set; }
    }
}
