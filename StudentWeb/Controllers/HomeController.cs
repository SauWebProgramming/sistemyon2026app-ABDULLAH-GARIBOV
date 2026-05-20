using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace StudentWeb.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using var client = new HttpClient();

            // API'den veriyi çekiyoruz
            var response = await client.GetAsync("http://studentapi:8080/api/student");
            var jsonString = await response.Content.ReadAsStringAsync();

            // Gelen JSON'u çözümleyip View'a (Görünüme) gönderiyoruz
            var studentData = JsonSerializer.Deserialize<JsonElement>(jsonString);
            ViewBag.Student = studentData;

            return View();
        }
    }
}