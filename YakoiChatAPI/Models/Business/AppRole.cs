
using System.Collections.Generic;

namespace YakoiChatAPI.Models.Business
{
    public class AppRole
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<AppPermission> PermissionList { get; set; }
    }
}
