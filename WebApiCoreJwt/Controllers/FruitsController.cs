using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiCoreJwt.DataTransfer;
using WebApiCoreJwt.Entities;
using WebApiCoreJwt.Models;

namespace WebApiCoreJwt.Controllers
{
    [Produces("application/json")]
    [Route("api/Fruits")]
    public class FruitsController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FruitDto fruit)
        {
            using (var context = new ApplicationDbContext())
            {
                var newFruitEntityEntry = context.Fruits.Add(new Fruit
                {
                    Species = fruit.Species,
                    Color = fruit.Color
                });

                await context.SaveChangesAsync();

                // return Ok(new FruitDto(newFruitEntityEntry.Entity));
                return Ok();
            }
        }
    }
}
