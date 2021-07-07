using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {
        }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

      
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=smartdb1.database.windows.net;Database=Product; User ID=dbAdmin1;Password=Harika@14");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductID)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("OrderID")
                    .IsFixedLength(true);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250);

                entity.Property(e => e.Price)
                    .HasColumnType("double")
                    .HasColumnName("Price");
                entity.Property(e => e.Features)
                    .HasMaxLength(250);







            });

          
            

           // OnModelCreatingPartial(modelBuilder);
        }

     //  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }


}
