using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace test1.Model.Entity
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        [NotNull]
        public string Name { get; set; }
        [NotNull,MaxLength(2000)]
        public string Description { get; set; }
        [NotNull]
        public string Information { get; set; }
        [NotNull]
        public long Price { get; set; }

        public int CategoryId { get; set; }

        public CategoryEntity Category { get; set;}

    }
}
