using Microsoft.AspNetCore.Mvc;
using sallys_collection.Models;
using sallys_collection.Repositories.Interfaces;
using System.Diagnostics;

namespace sallys_collection.Controllers
{
    public class CollectionController : Controller
    {
        private readonly ILogger<CollectionController> _logger;
        private readonly IProductRepository _productRepository;

        public CollectionController(ILogger<CollectionController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        public IActionResult Homepage()
        {
            var dd = _productRepository.GetAllProducts().Result;
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