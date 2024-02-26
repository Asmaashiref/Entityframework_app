using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFtask2.Models
{
    public class NewsContext: DbContext
    {
        public virtual DbSet<catalog> Catalogs { get; set; }
        public virtual DbSet<news> News { get; set; }
        public virtual DbSet<author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=.;Initial Catalog=newsdatabase;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
