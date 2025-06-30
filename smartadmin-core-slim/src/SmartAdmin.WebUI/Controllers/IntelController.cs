using Microsoft.AspNetCore.Mvc;

namespace SmartAdmin.WebUI.Controllers
{
    public class IntelController : Controller
    {
        public IActionResult Introduction() => View();
        public IActionResult Privacy() => View();
    }
}
