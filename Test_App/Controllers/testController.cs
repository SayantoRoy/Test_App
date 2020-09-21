using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_App.Models;

namespace Test_App.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public ActionResult Index()
        {
            testDbEntities testDb = new testDbEntities();
            List<tbl_emps> emps = testDb.tbl_emps.ToList();

            return View(emps);
        }

        public ActionResult MainDashboard()
        {
            testDbEntities testDb = new testDbEntities();
            List<tbl_emps> emps = testDb.tbl_emps.ToList();
            return View(emps);
        }
    }
}