using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.Ef;
using ZeroHunger.Ef.Models;

namespace Zero_Hunger.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ZHContext();
            var cr = db.CollectRequests.ToList();
            return View(cr);
        }
        public ActionResult Details(int id)
        {
            var db = new ZHContext();
            var cr = (from c in db.CollectRequests where c.CrId == id select c).SingleOrDefault();
            return View(cr);
        }
        [HttpPost]
        public ActionResult Ditribution(DistributionDetails model)
        {
            return View(model);
        }

    }
}