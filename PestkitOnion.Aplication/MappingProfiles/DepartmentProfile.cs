using AutoMapper;
using PestKitOnion.Application.DTOs.Department;
using PestKitOnion.Application.DTOs.Departments;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.MappingProfiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentItemDto>();
            CreateMap<Department, DepartmentGetDto>();
            CreateMap<DepartmentCreateDto, Department>();
        }
    }
}
