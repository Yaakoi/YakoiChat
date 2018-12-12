using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YakoiChatAPI.Models.Services;
using YakoiChatAPI.Models;
using YakoiChatAPI.Models.Business;
using Microsoft.AspNetCore.Authorization;

namespace YakoiChatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly YakoiChatContext _ctx;

        public GroupController(YakoiChatContext context)
        {
            _ctx = context;
        }

        // GET api/group/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetGroupById(int id)
        {
            var group = new ServiceGroup(_ctx).GetGroupById(id);
            return Ok(group);
        }

        // GET api/group/users
        [HttpGet("{id}/users", Name = "Users_List")]
        public async Task<IActionResult> GetListUser(int id)
        {
            var groupUsers = new ServiceGroup(_ctx).GetListUser(id);

            return Ok(groupUsers);

        }

        // POST api/group
        
        [HttpPost]
        public async Task<IActionResult> AddGroup([FromBody] Group group, int IdUser, int RoleUser)
        {
            if(RoleUser != 1)
            {
                return Unauthorized("Tu n'es pas Admin !");
            }
            var sGroup = new ServiceGroup(_ctx);
            var xGroup = sGroup.Add(group, IdUser);
            return Created($"api/group/" + xGroup.Id, group);
        }

        [HttpPost("user")]
        public async Task<IActionResult> AddUserGroup([FromBody] Group group, int IdUser)
        {
            var sGroup = new ServiceGroup(_ctx);
            sGroup.AddUser(group, IdUser);
            return Ok();
        }
    }

}
