using Microsoft.AspNetCore.Mvc;

namespace SalesWeb2022.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
