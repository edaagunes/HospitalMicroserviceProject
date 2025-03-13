using IdentityServer.Dtos;
using IdentityServer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IdentityServer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RegistersController : ControllerBase
	{
		private readonly UserManager<ApplicationUser> _userManager;

		public RegistersController(UserManager<ApplicationUser> userManager)
		{
			_userManager = userManager;
		}

		[HttpPost]
		public async Task<IActionResult> UserRegister(UserRegisterDto userRegisterDto)
		{
			var values = new ApplicationUser()
			{
				Email = userRegisterDto.Email,
				Name = userRegisterDto.Name,
				Surname = userRegisterDto.Surname,
				UserName = userRegisterDto.Username
			};
			var result = await _userManager.CreateAsync(values, userRegisterDto.Password);

			if (result.Succeeded)
			{
				return Ok("Kullanıcı Eklendi");
			}
			else
			{
				return Ok("Bir Hata Oluştu");
			}
		}
	}
}
