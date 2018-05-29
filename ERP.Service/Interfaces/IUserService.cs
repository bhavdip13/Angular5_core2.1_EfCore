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
   	void DeleteUser(Users user);
	}
}
