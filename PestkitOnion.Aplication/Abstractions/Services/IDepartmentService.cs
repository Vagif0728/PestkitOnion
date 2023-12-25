using PestKitOnion.Application.DTOs.Department;
using PestKitOnion.Application.DTOs.Departments;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface IDepartmentService
    {
        Task<ICollection<DepartmentItemDto>> GetAllAsync(int page, int take);
        Task<DepartmentGetDto> GetAsync(int id);
        Task CreateAsync(DepartmentCreateDto departmentCreateDto);
        Task UpdateAsync(int id, DepartmentUpdateDto departmentUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
