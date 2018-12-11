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
                Id = value.Id,
                FirstName = value.FirstName,
                LastName = value.LastName,
                Email = value.Email,
                Pseudo = value.Pseudo,
                Password = value.Password,
                Experience = value.Experience,
                
            };
        }

        public static User Map(Models.Data.User value)
        {
            return new User
            {
                Id = value.Id,
                FirstName = value.FirstName,
                LastName = value.LastName,
                Email = value.Email,
                Pseudo = value.Pseudo,
                Password = value.Password,
                Experience = value.Experience,
                Role = new Role
                {
                    Id = value.IdRole,
                    Name = value.Role.Name
                }
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
