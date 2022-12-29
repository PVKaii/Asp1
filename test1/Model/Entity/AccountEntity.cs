using System.ComponentModel.DataAnnotations;

namespace test1.Model.Entity
{
    public class AccountEntity
    {
        [Key]
        public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public int UserId { get; set; }

        public UserEntity User { get; set; }
    }
}
