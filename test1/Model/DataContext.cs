using Microsoft.EntityFrameworkCore;
using test1.Model.Entity;

namespace test1.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ProductEntity> Product { get; set;}

        public DbSet<CategoryEntity> Category  {get; set;}

        public DbSet<RoleEntity> Role { get; set;}
        public DbSet<UserEntity> User { get; set;}

        public DbSet<AccountEntity> Account { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .UsingEntity(ur => ur.ToTable("UserRole"));


           
            base.OnModelCreating(modelBuilder);
        }
    }
}
