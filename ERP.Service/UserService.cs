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
		ERPContext db = new ERPContext();
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
		public int DeleteUser(Users user)
		{
			return repository.Remove(user);
		}
		public void UpdateUser(Users user)
		{
			repository.Update(user);
		}
		public void UpdateIsActive(int id,bool active)
		{
			
			var userlist = db.Users.Find(id);
			userlist.Active = active;
			db.Update(userlist);
			db.SaveChanges();
		}
		public void UpdateIsEmailVerified(int id, bool IsEmailVerified)
		{

			var userlist = db.Users.Find(id);
			userlist.EmailConfirmed = IsEmailVerified;
			db.Update(userlist);
			db.SaveChanges();
		}
	}
}
