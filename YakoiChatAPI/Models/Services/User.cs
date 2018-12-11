using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using YakoiChatAPI.Models.Business;
using YakoiChatAPI.Models.Business.Mapper;

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
            var user = (from u in _ctx.User where u.Id == UserId select MapperUser.Map(u)).FirstOrDefault();
            var role = (from r in _ctx.Role join u in _ctx.User on r.Id equals u.IdRole where u.Id == UserId select MapperRole.Map(r)).FirstOrDefault();
            user.Role = role;
            return user;
        }

        public User Add(User user)
        {
            var entityUser = new Data.User
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Pseudo = user.Pseudo,
                Password = user.Password,
                Experience = 0,
                IdRole = user.Role.Id
            };
            _ctx.User.Add(entityUser);
            _ctx.SaveChanges();
            user.Id = entityUser.Id;
            return user;
        }

    }
}