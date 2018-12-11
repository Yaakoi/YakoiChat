
using System.ComponentModel.DataAnnotations.Schema;

namespace YakoiChatAPI.Models.Data
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Pseudo { get; set; }
        public string Password { get; set; }
        public int Experience { get; set; }

        public int IdRole { get; set; }
        [ForeignKey("IdRole")]
        public virtual Role Role { get; set; }
    }
}
