using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebScrape.Data;

namespace MvcWebScrape.Controllers
{
    public class HomeController : Controller
    {
        private Manager _mg = new Manager();
        public ActionResult Index()
        {
            return View(_mg.GetAllPosts());
        }
        public ActionResult RenderUrl(string url)
        {
            string data = _mg.GetFullHtml(url);
            return Json(data,JsonRequestBehavior.AllowGet);
        }
    }
}
