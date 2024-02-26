using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFtask2.Models
{
    public class catalog
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(50)]
        public string? desc { get; set; }
        public virtual List<news> News { get; set; } = new List<news>();
    }
}
