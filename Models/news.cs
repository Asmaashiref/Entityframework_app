using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFtask2.Models
{
    public class news
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string title { get; set; }
        [StringLength(20)]
        public string? bref { get; set; }

       
        public TimeOnly? time { get; set; }

    
        public DateOnly? date { get; set; }

        [ForeignKey("Catalog")]
        public int cat_id { get; set; }

        [ForeignKey("Author")]
        public int aut_id { get; set; }


        public virtual catalog Catalog { get; set; }
        public virtual author Author{ get; set; }

    }
}
