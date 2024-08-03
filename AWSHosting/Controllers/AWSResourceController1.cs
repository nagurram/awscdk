using Microsoft.AspNetCore.Mvc;

namespace AWSHosting.Controllers
{
    public class AWSResourceController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
