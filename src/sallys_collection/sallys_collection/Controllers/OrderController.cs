using Microsoft.AspNetCore.Mvc;

namespace sallys_collection.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
