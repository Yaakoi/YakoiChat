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
    public class UserController : ControllerBase
    {

        private readonly YakoiChatContext _ctx;

        public UserController(YakoiChatContext context)
        {
            _ctx = context;
        }


        // GET api/user
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var user = new ServiceUser(_ctx).GetUserById(id);

            return Ok(user);
            
        }

        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
