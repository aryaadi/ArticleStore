using Microsoft.AspNetCore.Mvc;

namespace Avam.ArticleStore.Web.Api
{
    public class ArticlesController : Controller
    {
        public JsonResult Index()
        {
            return Json(new { myName = "Balwinder" });
        }
    }
}