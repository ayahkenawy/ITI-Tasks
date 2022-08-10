using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(new List<string> { "Aya","Omnya","Alaa"});
        }
        [Authorize(Policy = "EG")]
        [HttpGet]
        [Route("EGOnly")]
        public ActionResult<List<string>> GetEG()
        {
            return Ok(new List<string> { "Aya", "Omnya", "Alaa" });
        }
    }
}
