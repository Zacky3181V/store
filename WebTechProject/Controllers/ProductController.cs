using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebTechProject.Models;

namespace WebTechProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            using var client2 = new HttpClient();
            var endpoint2 = new Uri("http://localhost:3000/api/9f706ecd-6d66-45c7-a165-93e8c9f97750/products");
            var result2 = client2.GetAsync(endpoint2).Result;
            var json2 = result2.Content.ReadAsStringAsync().Result;
            List<Product>? items2 = JsonConvert.DeserializeObject<List<Product>>(json2);
            ViewBag.Message = items2;
            return View();
        }
    }
}
