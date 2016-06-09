using Microsoft.AspNetCore.Mvc;

namespace Avam.ArticleStore.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}