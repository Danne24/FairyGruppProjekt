using Microsoft.AspNetCore.Mvc;

namespace FairyGruppProjekt.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
