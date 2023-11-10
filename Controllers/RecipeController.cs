using Microsoft.AspNetCore.Mvc;

namespace recipe.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        //todo

        [HttpGet]
        public IActionResult HelloWorld()
        {

            return NotFound();

        }
    }
}