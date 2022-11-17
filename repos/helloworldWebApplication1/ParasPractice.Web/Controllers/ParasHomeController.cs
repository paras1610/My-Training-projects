using Microsoft.AspNetCore.Mvc;

namespace ParasPractice.Web.Controllers
{
    public class ParasHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Booking()
        {
            return View();
        }
    }
}
