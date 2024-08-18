using Microsoft.AspNetCore.Mvc;

namespace My_Book_Inventory.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
