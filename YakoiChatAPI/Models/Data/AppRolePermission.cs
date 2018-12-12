using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YakoiChatAPI.Models.Data
{
    public class AppRolePermission
    {
        public int IdAppRole { get; set; }
        [ForeignKey("IdAppRole")]
        public virtual AppRole AppRole { get; set; }

        public int IdAppPermission { get; set; }
        [ForeignKey("IdAppPermission")]
        public virtual AppPermission AppPermission { get; set; }
    }
}
