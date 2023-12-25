using PestKitOnion.Application.DTOs.Tag;
using PestKitOnion.Application.DTOs.Tags;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface ITagService
    {
        Task<ICollection<TagItemDto>> GetAllAsync(int page, int take);
        Task<TagGetDto> GetAsync(int id);
        Task CreateAsync(TagCreateDto tagCreateDto);
        Task UpdateAsync(int id, TagUpdateDto tagUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
