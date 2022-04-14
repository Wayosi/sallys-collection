using Microsoft.AspNetCore.Mvc;

namespace sallys_collection.Controllers
{
    public class ApparelController : Controller
    {
        private readonly ILogger<ApparelController> _logger;

        public ApparelController(ILogger<ApparelController> logger)
        {
            _logger = logger;
        }

        public IActionResult Description()
        {
            return View();
        }
    }
}
