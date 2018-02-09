using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCoreJwt.Controllers
{
    [Produces("application/json")]
    [Route("api/Smth")]
    [Authorize]
    public class SmthController : Controller
    {
        [HttpGet]
        public async Task<JsonResult> GetSmth()
        {
            var list = new List<object>
            {
                new { Answer = "Look at that." }
            };

            return Json(list);
        }
    }
}
