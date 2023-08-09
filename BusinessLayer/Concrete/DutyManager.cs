using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class DutyManager : IDutyService
	{
		readonly IDutyDal _dutyDal;

		public DutyManager(IDutyDal dutyDal)
		{
			_dutyDal = dutyDal;
		}

		public List<Duty> GetAllDuty() => _dutyDal.List();

	}
}
