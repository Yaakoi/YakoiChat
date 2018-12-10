

using System.Collections.Generic;

namespace YakoiChatAPI.Models.Business
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateCreation { get; set; }

        public List<User> UserList { get; set; }
    }
}
