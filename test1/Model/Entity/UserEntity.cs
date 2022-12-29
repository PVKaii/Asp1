using System.ComponentModel.DataAnnotations;

namespace test1.Model.Entity
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }

        public AccountEntity Account { get; set; }

        public List<RoleEntity> Roles { get; set; }
    }
}
