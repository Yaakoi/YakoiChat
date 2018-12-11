using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using YakoiChatAPI.Models.Business;
using YakoiChatAPI.Models.Mapper;

namespace YakoiChatAPI.Models.Services
{
    public class ServiceUser
    {
        private readonly YakoiChatContext _ctx;

        public ServiceUser(YakoiChatContext context)
        {
            _ctx = context;
        }
        
        public List<Group> GetGroupsByUserId(int IdUser)
        {
            return (from ug in _ctx.UserGroup where ug.IdUser == IdUser select MapperGroup.Map(ug.Group)).ToList();
        }

        public User GetUserById(int UserId)
        {
            return (from u in _ctx.User where u.Id == UserId select MapperUser.Map(u)).FirstOrDefault();
        }

    }
}