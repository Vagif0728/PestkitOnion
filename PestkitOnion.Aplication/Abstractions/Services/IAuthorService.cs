using PestKitOnion.Application.DTOs.Author;
using PestKitOnion.Application.DTOs.Authors;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface IAuthorService
    {
        Task<ICollection<AuthorItemDto>> GetAllAsync(int page, int take);
        Task<AuthorGetDto> GetAsync(int id);
        Task CreateAsync(AuthorCreateDto authorCreateDto);
        Task UpdateAsync(int id, AuthorUpdateDto authorUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
