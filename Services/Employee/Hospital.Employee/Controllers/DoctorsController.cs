using Hospital.Employee.Dtos.DoctorDtos;
using Hospital.Employee.Services.DoctorServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Employee.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class DoctorsController : ControllerBase
	{
		private readonly IDoctorService _departmentService;

		public DoctorsController(IDoctorService departmentService)
		{
			_departmentService = departmentService;
		}

		[HttpGet]
		public async Task<IActionResult> DoctorList()
		{
			var value = await _departmentService.GetAllDoctorAsync();
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateDoctor(CreateDoctorDto createDoctorDto)
		{
			await _departmentService.CreateDoctorAsync(createDoctorDto);
			return Ok("Ekleme Başarılı");
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteDoctor(int id)
		{
			await _departmentService.DeleteDoctorAsync(id);
			return Ok("Silme Başarılı");
		}
		[HttpGet("GetDoctor")]
		public async Task<IActionResult> GetDoctor(int id)
		{
			return Ok(await _departmentService.GetByIdDoctorAsync(id));
		}
		[HttpPut]
		public async Task<IActionResult> UpdateDoctor(UpdateDoctorDto updateDoctorDto)
		{
			await _departmentService.UpdateDoctorAsync(updateDoctorDto);
			return Ok("Güncelleme Başarılı");
		}
	}
}
