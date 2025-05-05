using Microsoft.AspNetCore.Mvc;

namespace Techan.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Contact() 
        {
            return View();
        }
    }
}
