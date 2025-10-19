using Microsoft.AspNetCore.Mvc;

namespace Website1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index1()
        {
            return View();
        }
    }
}
