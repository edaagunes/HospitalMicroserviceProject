using AutoMapper;
using Hospital.Employee.Context;
using Hospital.Employee.Dtos.NurseDtos;
using Hospital.Employee.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Employee.Services.NurseServices
{
	public class NurseService : INurseService
	{
		private readonly EmployeeContext _employeeContext;
		private readonly IMapper _mapper;

		public NurseService(IMapper mapper, EmployeeContext employeeContext)
		{
			_mapper = mapper;
			_employeeContext = employeeContext;
		}

		public async Task CreateNurseAsync(CreateNurseDto createNurseDto)
		{
			var value = _mapper.Map<Nurse>(createNurseDto);
			await _employeeContext.Nurses.AddAsync(value);
			await _employeeContext.SaveChangesAsync();
		}

		public async Task DeleteNurseAsync(int id)
		{
			var value = await _employeeContext.Nurses.FindAsync(id);
			_employeeContext.Nurses.Remove(value);
			await _employeeContext.SaveChangesAsync();
		}

		public async Task<List<ResultNurseDto>> GetAllNurseAsync()
		{
			var values = await _employeeContext.Nurses.ToListAsync();
			return _mapper.Map<List<ResultNurseDto>>(values);
		}

		public async Task<GetByIdNurseDto> GetByIdNurseAsync(int id)
		{
			var values = await _employeeContext.Nurses.FindAsync(id);
			return _mapper.Map<GetByIdNurseDto>(values);
		}

		public async Task UpdateNurseAsync(UpdateNurseDto updateNurseDto)
		{
			var value = _mapper.Map<Nurse>(updateNurseDto);
			_employeeContext.Nurses.Update(value);
			await _employeeContext.SaveChangesAsync();
		}
	}
}
