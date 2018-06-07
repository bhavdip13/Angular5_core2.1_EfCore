using ERP.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Service.Interfaces
{
    public interface IUserService
    {
		IEnumerable<Users> GetUser();
		Users GetUser(int id);
		void AddUser(Users user);
		void UpdateUser(Users user);
   	int DeleteUser(Users user);
		void UpdateIsActive(int id, bool active);
		void UpdateIsEmailVerified(int id, bool IsEmailVerified);
	}
}
