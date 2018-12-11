using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YakoiChatAPI.Models.Data
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NbrUserMax { get; set; }
        public int CreatedBy { get; set; }
    }
}
