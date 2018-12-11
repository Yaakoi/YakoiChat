using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YakoiChatAPI.Models.Business;

namespace YakoiChatAPI.Models.Mapper
{
    public class MapperGroup
    {
        public static Models.Data.Group Map(Group value)
        {
            return new Models.Data.Group
            {
                Id = value.Id,
                Name = value.Name,
                CreatedBy = value.CreatedBy
            };
        }

        public static Group Map(Models.Data.Group value)
        {
            return new Group
            {
                Id = value.Id,
                Name = value.Name,
                CreatedBy = value.CreatedBy
            };
        }

        public static List<Group> Map(List<Models.Data.Group> value)
        {
            return (from v in value select Map(v)).ToList();
        }

        public static List<Models.Data.Group> Map(List<Group> value)
        {
            return (from v in value select Map(v)).ToList();
        }


    }
}
