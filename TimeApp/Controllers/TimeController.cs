using Microsoft.AspNetCore.Mvc;

namespace TimeApp.Controllers
{
    public class TimeController : Controller
    {
        public IActionResult Time()
        {
            DateTime dateTime = DateTime.Now;
            return View(dateTime);
        }
    }
}
