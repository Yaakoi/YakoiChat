using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YakoiChatAPI.Models.Business;

namespace YakoiChatAPI.Models.Mapper
{
    public class MapperUser
    {
        public static Models.Data.User Map(User value)
        {
            return new Models.Data.User
            {
                id = value.Id,
                FirstName = value.FirstName,
                LastName = value.LastName
            };
        }

        public static User Map(Models.Data.User value)
        {
            return new User
            {
                Id = value.id,
                FirstName = value.FirstName,
                LastName = value.LastName
            };
        }

        public static List<User> Map(List<Models.Data.User> value)
        {
            return (from v in value select Map(v)).ToList();
        }

        public static List<Models.Data.User> Map(List<User> value)
        {
            return (from v in value select Map(v)).ToList();
        }
    }
}
