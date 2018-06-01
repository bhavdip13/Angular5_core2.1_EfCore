using ERP.Data.Models;
using ERP.Service.Interfaces;
using ERP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace ERP.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
		private readonly IUserService service;

		public UserController(IUserService service)
		{
			this.service = service;
		}
		[HttpGet]//get all recored
		public IEnumerable<Users> Get()
		{
			try
			{
				return service.GetUser();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		[HttpGet("{id}")]//get recored by id
		public Users Get(int id)
		{
			try
			{
				return service.GetUser(id);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		[HttpPost]// insert recored
		public Users Post([FromBody] VUsers _VUsers)
		{
			var _Users = new Users();
			try
			{
				_Users.Id = _VUsers.Id;
				_Users.Email = _VUsers.Email;
				_Users.EmailConfirmed =false;
				_Users.PhoneNumber = "";
				_Users.LastLoginDateUtc = _VUsers.LastLoginDateUtc;
				_Users.Active = _VUsers.Active;
				_Users.CreatedOnUtc = DateTime.UtcNow;
				_Users.FullName = _VUsers.FullName;
				_Users.ProfilePicBinary = _VUsers.ProfilePicBinary;
				_Users.MimeType = "";

				
				_Users.Password= System.Text.Encoding.ASCII.GetBytes(_VUsers.Password); 
				service.AddUser(_Users);
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return _Users;
		}

		[HttpDelete("{id}")] //delete recored by id
		public void Delete(int id)
		{
			try
			{
				Users User = service.GetUser(id);
				service.DeleteUser(User);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		//[HttpPost]//update recored
		//public void Put(Users _Users)
		//{
		//	try
		//	{
		//		service.UpdateUser(_Users);
		//	}
		//	catch (Exception ex)
		//	{
		//		throw ex;
		//	}
			
		//}
	}
}