using Microsoft.AspNetCore.Mvc;

namespace BrainyTrainy.Api.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}