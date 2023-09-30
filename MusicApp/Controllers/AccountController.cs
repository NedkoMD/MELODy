using Microsoft.AspNetCore.Mvc;

namespace MusicApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SingUp()
        {
            return View();
        }
    }
}
