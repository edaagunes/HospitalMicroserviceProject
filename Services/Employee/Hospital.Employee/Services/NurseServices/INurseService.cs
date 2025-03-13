using Hospital.Employee.Dtos.NurseDtos;

namespace Hospital.Employee.Services.NurseServices
{
	public interface INurseService
	{
		Task<List<ResultNurseDto>> GetAllNurseAsync();
		Task CreateNurseAsync(CreateNurseDto createNurseDto);
		Task UpdateNurseAsync(UpdateNurseDto updateNurseDto);
		Task DeleteNurseAsync(int id);
		Task<GetByIdNurseDto> GetByIdNurseAsync(int id);
	}
}
