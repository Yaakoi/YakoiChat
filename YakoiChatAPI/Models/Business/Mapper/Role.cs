using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using YakoiChatAPI.Models.Business;

namespace YakoiChatAPI.Models.Business.Mapper
{
    public class MapperRole
    {
        public static Role Map(Data.Role value)
        {
            return new Role
            {
                Id = value.Id,
                Name = value.Name
            };
        }
    }
}
