using ERP.Data.Models;
using ERP.IRepository.Interfaces;
using ERP.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Service
{
	public class UserService : IUserService
	{
		private IRepository<Users> repository;
		public UserService(IRepository<Users> repository)
		{
			this.repository = repository;
		}
		public IEnumerable<Users> GetUser()
		{
			return repository.GetAll();
		}
		public Users GetUser(int id)
		{
			return repository.Get(id);
		}
		public void AddUser(Users user)
		{
			repository.Add(user);
		}
		public void DeleteUser(Users user)
		{
			repository.Remove(user);
		}
		public void UpdateUser(Users user)
		{
			repository.Update(user);
		}
	}
}
