using JWTAuth.Models;
using JWTAuth.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUserByName(string username)
        {
            try
            {
                var user = await _user.GetUserByName(username);
                return Ok(user);
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            try
            {
                var users = await _user.AddUser(user);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }



    }
}
