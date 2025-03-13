using AutoMapper;
using Hospital.Employee.Dtos.DepartmentDtos;
using Hospital.Employee.Dtos.DoctorDtos;
using Hospital.Employee.Dtos.NurseDtos;
using Hospital.Employee.Entities;

namespace Hospital.Employee.Mapping
{
	public class GeneralMapping:Profile
	{
		public GeneralMapping()
		{
			CreateMap<ResultDepartmentDto,Department>().ReverseMap();
			CreateMap<CreateDepartmentDto,Department>().ReverseMap();
			CreateMap<UpdateDepartmentDto,Department>().ReverseMap();
			CreateMap<GetByIdDepartmentDto,Department>().ReverseMap();

			CreateMap<ResultDoctorDto, Doctor>().ReverseMap();
			CreateMap<CreateDoctorDto, Doctor>().ReverseMap();
			CreateMap<UpdateDoctorDto, Doctor>().ReverseMap();
			CreateMap<GetByIdDoctorDto, Doctor>().ReverseMap();

			CreateMap<ResultNurseDto, Nurse>().ReverseMap();
			CreateMap<CreateNurseDto, Nurse>().ReverseMap();
			CreateMap<UpdateNurseDto, Nurse>().ReverseMap();
			CreateMap<GetByIdNurseDto, Nurse>().ReverseMap();
		}
	}
}
