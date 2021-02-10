using System.ComponentModel.DataAnnotations;

namespace Core.Services.User.Entities
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Token { get; set; }
    }
}
