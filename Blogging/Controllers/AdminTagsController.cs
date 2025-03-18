using Microsoft.AspNetCore.Mvc;

namespace Blogging.Controllers
{
    public class AdminTagsController : Controller
    {


        [HttpGet]
        // GET: AdminTagsController
        public IActionResult Add()
        {
            return View();
        }

    }
}
