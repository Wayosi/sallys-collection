using Microsoft.AspNetCore.Mvc;
using sallys_collection.Models;
using System.Diagnostics;

namespace sallys_collection.Controllers
{
    public class CollectionController : Controller
    {
        private readonly ILogger<CollectionController> _logger;

        public CollectionController(ILogger<CollectionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Homepage()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}