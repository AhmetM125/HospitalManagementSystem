using BusinessLayer;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HospitalManagement.Areas.Admin.Controllers
{
	[AllowAnonymous]
	public class UserController : Controller
	{
		UserManager um = new UserManager(new EfUserDal());
		DepartmentManager dm = new DepartmentManager(new EfDepartmentDal());
		DutyManager dutym = new DutyManager(new EfDutyDal());
		public ActionResult ListOfUser()
		{
			List<User> UserList = um.GetAllUser();
			return View(UserList);
		}
		public ActionResult CreateUser()
		{
			var Departments = from x in dm.GetAllDeps()
					   select new SelectListItem
					   {
						   Text = x.DepartmentName,
						   Value = x.DepartmentId.ToString()

					   };
			ViewBag.deps = Departments.ToList();
			var Duty = from x in dutym.GetAllDuty()
					   select new SelectListItem
					   {
						   Text = x.DutyName,
						   Value = x.DutyId.ToString()
					   };
			ViewBag.duty = Duty.ToList();

			return View();
		}
	}
}