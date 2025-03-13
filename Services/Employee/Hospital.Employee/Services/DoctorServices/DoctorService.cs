using AutoMapper;
using Hospital.Employee.Context;
using Hospital.Employee.Dtos.DoctorDtos;
using Hospital.Employee.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Employee.Services.DoctorServices
{
	public class DoctorService : IDoctorService
	{
		private readonly EmployeeContext _employeeContext;
		private readonly IMapper _mapper;

		public DoctorService(IMapper mapper, EmployeeContext employeeContext)
		{
			_mapper = mapper;
			_employeeContext = employeeContext;
		}

		public async Task CreateDoctorAsync(CreateDoctorDto createDoctorDto)
		{
			var value = _mapper.Map<Doctor>(createDoctorDto);
			await _employeeContext.Doctors.AddAsync(value);
			await _employeeContext.SaveChangesAsync();
		}

		public async Task DeleteDoctorAsync(int id)
		{
			var value = await _employeeContext.Doctors.FindAsync(id);
			_employeeContext.Doctors.Remove(value);
			await _employeeContext.SaveChangesAsync();
		}

		public async Task<List<ResultDoctorDto>> GetAllDoctorAsync()
		{
			var values = await _employeeContext.Doctors.ToListAsync();
			return _mapper.Map<List<ResultDoctorDto>>(values);
		}

		public async Task<GetByIdDoctorDto> GetByIdDoctorAsync(int id)
		{
			var values = await _employeeContext.Doctors.FindAsync(id);
			return _mapper.Map<GetByIdDoctorDto>(values);
		}

		public async Task UpdateDoctorAsync(UpdateDoctorDto updateDoctorDto)
		{
			var value = _mapper.Map<Doctor>(updateDoctorDto);
			_employeeContext.Doctors.Update(value);
			await _employeeContext.SaveChangesAsync();
		}
	}
}
