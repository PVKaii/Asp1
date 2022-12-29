using Microsoft.EntityFrameworkCore;
using test1.Model.Entity;

namespace test1.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ProductEntity> Products { get; set;}

        public DbSet<CategoryEntity> Category { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
