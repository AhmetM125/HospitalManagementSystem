using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
	public class UserManager : IUserService
	{
		private readonly IUserDal _userdal;
		public UserManager(IUserDal userDal)
		{
			_userdal = userDal;
		}
		public List<User> GetAllUser() => _userdal.List();
		
	}
}
