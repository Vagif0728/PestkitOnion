using PestKitOnion.Application.DTOs.Position;
using PestKitOnion.Application.DTOs.Positions;
using PestKitOnion.Application.DTOs.Tag;

namespace PestKitOnion.Application.Abstractions.Services
{
    public interface IPositionService
    {
        Task<ICollection<PositionItemDto>> GetAllAsync(int page, int take);
        Task<PositionGetDto> GetAsync(int id);
        Task CreateAsync(PositionCreateDto positionCreateDto);
        Task UpdateAsync(int id, PositionUpdateDto positionUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
