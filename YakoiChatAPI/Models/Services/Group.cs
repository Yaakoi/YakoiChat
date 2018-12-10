using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YakoiChatAPI.Models.Business;
using YakoiChatAPI.Models.Mapper;

namespace YakoiChatAPI.Models.Services
{
    public class ServiceGroup
    {
        private readonly YakoiChatContext _ctx;

        public ServiceGroup(YakoiChatContext context)
        {
            _ctx = context;
        }

        public List<User> GetListUser(int GroupId)
        {
            return (from ug in _ctx.UserGroup where ug.IdGroup == GroupId select MapperUser.Map(ug.User)).ToList();
        }
    }
}
