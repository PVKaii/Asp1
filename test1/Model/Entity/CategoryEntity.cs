using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace test1.Model.Entity
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        [NotNull]
        public string Name { get; set; }

        public List<ProductEntity> Products { get; set; }      
    }
}
