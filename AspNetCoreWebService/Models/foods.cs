using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace AspNetCoreWebService.Models
{
    public class foods
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public string foodname { get; set; }
        [StringLength(500)]
        public string image { get; set; }
        public bool protein { get; set; }
        public bool side { get; set; }
        public bool condiment { get; set; }
        public bool dessert { get; set; }
        public bool drink { get; set; }
        public bool appetizer { get; set; }
    }
}
