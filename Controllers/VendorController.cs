using Microsoft.AspNetCore.Mvc;
using PamasolaSimpleERP.Models;
using System.Diagnostics;

namespace PamasolaSimpleERP.Controllers
{
    public class VendorController : Controller
    {
        private readonly ILogger<VendorController> _logger;

        public VendorController(ILogger<VendorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
