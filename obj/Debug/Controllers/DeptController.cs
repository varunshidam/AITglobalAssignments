using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample1.Models;

namespace MVCExample1.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult Index()
        {
            DeptBal bal = new DeptBal();
            List<Department> deptlist = bal.GetDeptList();
            TempData["dlist"] = deptlist;
            return View();
        }
    }
}