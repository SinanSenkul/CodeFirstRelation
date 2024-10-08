using Microsoft.AspNetCore.Mvc;

namespace CodeFirstRelation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
