using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutDemo.Controllers
{
    public class LadiesController : Controller
    {
        public ActionResult Index()
        {
            return View("Index", "_LadiesLayout");
        }

    }
}
