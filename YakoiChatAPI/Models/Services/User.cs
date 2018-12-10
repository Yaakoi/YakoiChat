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

        public User GetUserById(int UserId)
        {
            return (from u in _ctx.User where u.id == UserId select MapperUser.Map(u)).FirstOrDefault();
        }

    }
}