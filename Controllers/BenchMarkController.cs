using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BenchMarkPartial4._8._1.Controllers
{
    public class BenchMarkController : Controller
    {
        // GET: BenchMark
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FaviconBenchmark()
        {
            return View();
        }
    }
}