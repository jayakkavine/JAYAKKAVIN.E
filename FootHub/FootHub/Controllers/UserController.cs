using FootHub.Models;
using FootHub.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUser _iuser;

        public UserController(IUser iuser)
        {
            _iuser = iuser;
        }

        [HttpPost("UserTable")]
        public async Task<ActionResult<List<UserTable>>> AddUser(UserTable user)
        {
            var ocassions = await _iuser.AddUser(user);
            if (ocassions == null)
            {
                return NotFound();
            }
            return Ok(ocassions);
        }


        [HttpGet("UserTable_By_Id")]
        public async Task<ActionResult<List<UserTable>>> GetUserById(int u_id)
        {
            var students = await _iuser.GetUserById(u_id);
            if (students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }

        [HttpGet("UserTable")]
        public async Task<ActionResult<List<UserTable>>> GetUser()
        {
            var ocassions = await _iuser.GetUsers();
            if (ocassions == null)
            {
                return NotFound();
            }
            return Ok(ocassions);
        }

        [HttpPut("UserTable")]
        public async Task<ActionResult<UserTable>> UpdateUser(int u_id, UserTable user)
        {

            try
            {
                var ocassions = await _iuser.UpdateUser(u_id, user);

                return Ok(ocassions);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }

        [HttpDelete("UserTable")]
        public async Task<ActionResult<List<UserTable>>> RemoveUser(int u_id)
        {

            try
            {
                var ocassions = await _iuser.RemoveUser(u_id);

                return Ok(ocassions);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}
