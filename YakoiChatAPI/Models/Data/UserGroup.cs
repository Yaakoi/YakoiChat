using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YakoiChatAPI.Models.Data
{
    public class UserGroup
    {
        public int IdUser { get; set; }
        [ForeignKey("IdUser")]
        public virtual User User { get; set; }

        public int IdGroup { get; set; }
        [ForeignKey("IdGroup")]
        public virtual Group Group { get; set; }
    }
}
