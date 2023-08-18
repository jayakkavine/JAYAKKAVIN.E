using FootHub.Models;
using FootHub.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FootHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashBoardController : ControllerBase
    {
        private IDashBoard _idashboard;

        public DashBoardController(IDashBoard idashboard)
        {
            _idashboard = idashboard;
        }


        [HttpGet("Get Product")]
        public async Task<ActionResult<List<ProductTable>>> GetListOfProduct(int c_id)
        {
            var ocassions = await _idashboard.GetListOfProduct(c_id);
            if (ocassions == null)
            {
                return NotFound();
            }
            return Ok(ocassions);
        }


    }
}
