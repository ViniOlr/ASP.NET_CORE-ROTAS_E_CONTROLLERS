using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.App.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
