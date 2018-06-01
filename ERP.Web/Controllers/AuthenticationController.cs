using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ERP.Data.Models;
using ERP.Service.Interfaces;
using ERP.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ERP.Web.Controllers.API
{
	[Produces("application/json")]

	public class AuthenticationController : Controller
	{
	
		private readonly IConfiguration _configuration;
	  protected readonly ERPContext _context;


		public AuthenticationController(IConfiguration configuration, ERPContext context)
		{
			
			_configuration = configuration;
			_context = context;

		}
		
		[Route("api/Authentication/Login")]
		public IActionResult Authenticate([FromBody]VUsers userDto)
		{
			var _Users = new Users();
			_Users.LastLoginDateUtc = DateTime.UtcNow;
			_Users.Password = System.Text.Encoding.ASCII.GetBytes(userDto.Password);
			var user = _context.Users.FirstOrDefaultAsync(a => a.Email == userDto.Email && a.Password == _Users.Password).Result;

			List<MstMenuList> MenuList = new List<MstMenuList>();
			List<MstModuleList> ModuleList = new List<MstModuleList>();

			if (user != null)
			{
				MenuList = _context.MstMenuList.Where(t=>t.UserId== user.Id).ToList();//pass userid for the get menu list from paricular user.
				ModuleList = _context.MstModuleList.ToList();
			}

			if (user == null)
				return Unauthorized();

			var claims = new[]
								{
										new Claim(ClaimTypes.Name, userDto.Email)
								};

			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var token = new JwtSecurityToken(
					issuer: _configuration["Issuer"],
					audience: _configuration["Audience"],
					claims: claims,
					expires: DateTime.Now.AddMinutes(30),
					signingCredentials: creds
			);
			// return basic user info(without password) and token to store client side

			return Ok(new
			{
				Id = user.Id,
				FullName = user.FullName,
				Email = user.Email,
				Token = new JwtSecurityTokenHandler().WriteToken(token),
				ModuleList = ModuleList,
				MenuList = MenuList
			});
		}
	}
}
