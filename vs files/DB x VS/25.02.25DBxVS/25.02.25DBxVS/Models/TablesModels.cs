using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace _25._02._25DBxVS.Models
{
    public class workers
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name_surname { get; set; }
        [Required]
        public string positionn { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public string numberr { get; set; }
        [Required]
        public int salary { get; set; }
    }

    public class consultants(string n_s, string pos, string stat, string numb, int sal)
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name_surname = n_s;
        [Required]
        public string positionn = pos;
        [Required]
        public string status = stat;
        [Required]
        public string numberr = numb;
        [Required]
        public int salary = sal;
        public int penalty { get; set; }
        public string penaltyInfo { get; set; }
    }

    public class managers(string n_s, string pos, string stat, string numb, int sal)
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name_surname = n_s;
        [Required]
        public string specialization { get; set; }
        public string specializationInfo { get; set; }
        [Required]
        public string status = stat;
        [Required]
        public string numberr = numb;
        [Required]
        public int salary = sal;
        public int penalty { get; set; }
        public string penaltyInfo { get; set; }
    }
}
