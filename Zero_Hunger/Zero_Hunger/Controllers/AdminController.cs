using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.Ef;
using ZeroHunger.Ef.Models;

namespace Zero_Hunger.Controllers
{
    public class AdminController : Controller
    {
        
        public ActionResult Index()
        {
            var db = new ZHContext();
            var emp = db.Employees.ToList();
            return View(emp);

        }
        [HttpGet]
        public ActionResult EmployeeAssign()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployeeAssign(Employee model)
        {
            var db = new ZHContext();
            db.Employees.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id) 
        {
            var db = new ZHContext();
            var emp = (from e in db.Employees where e.EmployeeId == id select e).SingleOrDefault();
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee model)
        {
            var db = new ZHContext();
            var emp = (from e in db.Employees where e.EmployeeId==model.EmployeeId select e).SingleOrDefault();
            db.Entry(emp).CurrentValues.SetValues(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var db = new ZHContext();
            var dlt = (from emp in db.Employees where emp.EmployeeId == id select emp).SingleOrDefault();
            db.Employees.Remove(dlt);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}