using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_nhom_11.Controllers
{
    public class ComponentController : Controller
    {
        // GET: Component
        public ActionResult Error_401()
        {
            return View();
        }
        public ActionResult Error_500()
        {
            return View();
        }
    }
}