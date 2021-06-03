using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiSchool.Controllers
{
    public class trailController : Controller
    {
        // GET: trail
        public ActionResult Index()
        {
            return View();
        }
    }
}