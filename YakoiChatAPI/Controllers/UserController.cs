using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YakoiChatAPI.Models.Services;
using YakoiChatAPI.Models;
using YakoiChatAPI.Models.Business;

namespace YakoiChatAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly YakoiChatContext _ctx;

        public UserController(YakoiChatContext context)
        {
            _ctx = context;
        }


        // GET api/user
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(User), 200)]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = new ServiceUser(_ctx).GetUserById(id);

            return Ok(user);
            
        }

        [HttpGet("{id}/groups", Name = "Groups_List")]
        public async Task<IActionResult> GetGroupsByUserId(int id)
        {
            var user = new ServiceUser(_ctx).GetGroupsByUserId(id);

            return Ok(user);

        }


        // POST api/user
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            var sUser = new ServiceUser(_ctx);
            var xUser = sUser.Add(user);
            return Created($"api/user/" + xUser.Id, user);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
