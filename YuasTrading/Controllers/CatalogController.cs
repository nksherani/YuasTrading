using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YuasTrading.Models;

namespace YuasTrading.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult TrackOrder()
        {
            return View();
        }
        [HttpGet]
        [Route("Catalog/AdvanceOrder")]
        public ActionResult AdvanceOrder()
        {
            return View();
        }
        [HttpPost]
        [Route("Catalog/AdvanceOrder")]
        public ActionResult AdvanceOrder(AdvanceOrderModel advanceOrder)
        {
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }
    }
}