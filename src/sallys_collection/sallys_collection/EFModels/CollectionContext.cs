using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sallys_collection.EFModels
{
    public partial class CollectionContext : DbContext
    {
        public CollectionContext()
        {
        }

        public CollectionContext(DbContextOptions<CollectionContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               // optionsBuilder.UseNpgsql("name=FttxCoverageMapsDB");
            }
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
