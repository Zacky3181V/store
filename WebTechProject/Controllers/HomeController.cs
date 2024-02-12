using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using WebTechProject.Models;

namespace WebTechProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            using var client2 = new HttpClient();
            var endpoint2 = new Uri("http://localhost:3000/api/9f706ecd-6d66-45c7-a165-93e8c9f97750/billboards");
            var result2 = client2.GetAsync(endpoint2).Result;
            var json2 = result2.Content.ReadAsStringAsync().Result;
            List<StoreImage>? items2 = JsonConvert.DeserializeObject<List<StoreImage>>(json2);
            ViewBag.Message = items2[0];
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Authors()
        {
            return View();
        }
    }
}
