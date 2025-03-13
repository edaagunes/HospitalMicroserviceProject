using Hospital.Employee.Dtos.DepartmentDtos;
using Hospital.Employee.Services.DepartmentServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Employee.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class DepartmentsController : ControllerBase
	{
		private readonly IDepartmentService _departmentService;

		public DepartmentsController(IDepartmentService departmentService)
		{
			_departmentService = departmentService;
		}

		[HttpGet]
		public async Task<IActionResult> DepartmentList()
		{
			var value = await _departmentService.GetAllDepartmentAsync();
			return Ok(value);
		}
		[HttpPost]
		public async Task<IActionResult> CreateDepartment(CreateDepartmentDto createDepartmentDto)
		{
			await _departmentService.CreateDepartmentAsync(createDepartmentDto);
			return Ok("Ekleme Başarılı");
		}
		[HttpDelete]
		public async Task<IActionResult> DeleteDepartment(int id)
		{
			await _departmentService.DeleteDepartmentAsync(id);
			return Ok("Silme Başarılı");
		}
		[HttpGet("GetDepartment")]
		public async Task<IActionResult> GetDepartment(int id)
		{
			return Ok(await _departmentService.GetByIdDepartmentAsync(id));
		}
		[HttpPut]
		public async Task<IActionResult> UpdateDepartment(UpdateDepartmentDto updateDepartmentDto)
		{
			await _departmentService.UpdateDepartmentAsync(updateDepartmentDto);
			return Ok("Güncelleme Başarılı");
		}
	}
}
