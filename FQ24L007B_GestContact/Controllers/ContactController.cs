using Microsoft.AspNetCore.Mvc;

namespace FQ24L007B_GestContact.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
