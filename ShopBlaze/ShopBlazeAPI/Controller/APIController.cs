using Microsoft.AspNetCore.Mvc;

namespace ShopBlazeAPI
{
    public class APIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
