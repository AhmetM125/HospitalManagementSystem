using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class DepartmentManager : IDepartmentService
	{
		private readonly IDepartmentDal _departmentDal;

		public DepartmentManager(IDepartmentDal departmentDal)
		{
			_departmentDal = departmentDal;
		}

		public List<Department> GetAllDeps() => _departmentDal.List();
		
	}
}
