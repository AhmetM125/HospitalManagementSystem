using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagement.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            ViewData["TotalEmployee"] = 15;
            ViewData["TotalDoctor"] = 15;
            ViewData["TotalAppoint"] = 15;
            ViewData["TotalPatient"] = 15;
            ViewData["AvaibleRoom"] = 15;
            ViewData["RemainRoom"] = 15;
            return View();
        }
        public ActionResult TotalEmployee()
		{
            return View();
		}
    }
}