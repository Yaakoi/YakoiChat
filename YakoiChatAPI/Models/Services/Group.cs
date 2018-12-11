using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YakoiChatAPI.Models.Business;
using YakoiChatAPI.Models.Business.Mapper;

namespace YakoiChatAPI.Models.Services
{
    public class ServiceGroup
    {
        private readonly YakoiChatContext _ctx;

        public ServiceGroup(YakoiChatContext context)
        {
            _ctx = context;
        }

        public Group GetGroupById(int GroupId)
        {
            return (from g in _ctx.Group where g.Id == GroupId select MapperGroup.Map(g)).FirstOrDefault();
        }

        public List<User> GetListUser(int GroupId)
        {
            return (from ug in _ctx.UserGroup where ug.IdGroup == GroupId select MapperUser.Map(ug.User)).ToList();
        }

        public Group Add(Group group, int idUser)
        {
            var entityGroup = new Data.Group
            {
                Name = group.Name,
                NbrUserMax = group.NbrUserMax,
                CreatedBy = group.CreatedBy
            };
            _ctx.Group.Add(entityGroup);
            AddUser(entityGroup.Id, idUser);
            _ctx.SaveChanges();
            group.Id = entityGroup.Id;
            return group;
        }

        public void AddUser(int idGroup, int idUser)
        {
            var entityUserGroup = new Data.UserGroup
            {
                IdUser = idUser,
                IdGroup = idGroup
            };
            _ctx.UserGroup.Add(entityUserGroup);
            _ctx.SaveChanges();
        }
    }
}
