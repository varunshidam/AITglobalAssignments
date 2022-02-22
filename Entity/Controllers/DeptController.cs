using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFramework.Models;

namespace EntityFramework.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        public ActionResult Index()
        {
            HRMSDBEntities ent = new HRMSDBEntities();
            return View(ent.DEPARTMENTS);
        }
    }
}