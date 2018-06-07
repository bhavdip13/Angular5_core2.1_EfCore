using ERP.Data.Models;
using ERP.Service.Interfaces;
using ERP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace ERP.Web.Controllers
{
	[Produces("application/json")]
	[Route("api/User")]
	public class UserController : Controller
	{
		private readonly IUserService service;

		public UserController(IUserService service)
		{
			this.service = service;
		}
		// Get Users List
		[Route("GetUsers")]
		[HttpGet]
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
		// Get User by Id
		[Route("Details")]
		[HttpGet]
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
		// Save and Update User
		[Route("SaveUser")]
		[HttpPost]
		public Users Post([FromBody] VUsers _VUsers)
		{
			var _Users = new Users();
			try
			{
				_Users.Id = _VUsers.Id;
				_Users.Email = _VUsers.Email;
				_Users.UserName = _VUsers.UserName;
				_Users.EmailConfirmed = _VUsers.EmailConfirmed;
				_Users.PhoneNumber = _VUsers.PhoneNumber;
				_Users.LastLoginDateUtc = DateTime.UtcNow;
				_Users.Active = _VUsers.Active;
				_Users.CreatedOnUtc = DateTime.UtcNow;
				_Users.FullName = _VUsers.FullName;
				if (_VUsers.ProfilePicBinary != null)
				{
					_Users.ProfilePicBinary = _VUsers.ProfilePicBinary;

				}
				_Users.MimeType = _VUsers.MimeType;

				_Users.Password = System.Text.Encoding.ASCII.GetBytes(_VUsers.Password);
				if (_Users.Id == 0)
				{
					service.AddUser(_Users);
				}
				else
				{
					service.UpdateUser(_Users);
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return _Users;
		}
		// Update Isactive
		[Route("UpdateIsActive")]
		[HttpPost]
		public void UpdateisActive(int id,bool active)
		{
			
			service.UpdateIsActive(id,active);
				
		}
		// Update IsEmailVerified
		[Route("UpdateIsEmailVerified")]
		[HttpPost]
		public void UpadeteIsEmailVerified(int id, bool IsEmailVerified)
		{

			service.UpdateIsEmailVerified(id, IsEmailVerified);

		}
		[Route("Delete")]
		[HttpDelete]
		public int Delete(int id)
		{
			try
			{
				Users User = service.GetUser(id);
				return service.DeleteUser(User);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	
	}
}