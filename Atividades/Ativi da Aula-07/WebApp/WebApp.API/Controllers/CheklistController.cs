using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.API.Dbcontext;
using WebApp.API.Models;

namespace WebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheklistController : ControllerBase
    {
        CheckDbContext _dbcontext;

        public CheklistController(CheckDbContext context)
        {
               _dbcontext = context;
        }

        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_dbcontext.checklists);
        }


    }
}
