using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YakoiChatAPI.Models.Services;
using YakoiChatAPI.Models;

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

        // GET api/group/users
        [HttpGet("/{id}/users", Name = "Users_List")]
        public async Task<IActionResult> GetListUser(int id)
        {
            var groupUsers = new ServiceGroup(_ctx).GetListUser(id);

            return Ok(groupUsers);

        }
    }

}
