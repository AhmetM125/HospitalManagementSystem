using BusinessLayer.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public class EfDutyDal : GenericRepository<Duty>, IDutyDal
	{

	}
}
