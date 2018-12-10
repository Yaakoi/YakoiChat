using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YakoiChatAPI.Models.Business;

namespace YakoiChatAPI.Models.Business.Mapper
{
    public class MapperGroup
    {
        public static Models.Data.Group Map(Group value)
        {
            return new Models.Data.Group
            {
                id = value.Id,
                name = value.Name,
                DateCreation = value.DateCreation
            };
        }

        public static Group Map(Models.Data.Group value)
        {
            return new Group
            {
                Id = value.id,
                Name = value.name,
                DateCreation = value.DateCreation
            };
        }

        
    }
}
