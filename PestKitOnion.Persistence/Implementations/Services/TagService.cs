using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PestKitOnion.Application.Abstractions.Repositories;
using PestKitOnion.Application.Abstractions.Services;
using PestKitOnion.Application.DTOs.Position;
using PestKitOnion.Application.DTOs.Positions;
using PestKitOnion.Application.DTOs.Tag;
using PestKitOnion.Application.DTOs.Tags;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Persistence.Implementations.Services
{
    public class TagService:ITagService
    {
        private readonly ITagRepository _repository;
        private readonly IMapper _mapper;

        public TagService(ITagRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task CreateAsync(TagCreateDto tagCreateDto)
        {
            await _repository.AddAsync(_mapper.Map<Tag>(tagCreateDto));
            await _repository.SaveChangesAsync();
        }

        public async Task<ICollection<TagItemDto>> GetAllAsync(int page, int take)
        {
            ICollection<Tag> tags = await _repository.GetAllAsync(skip: (page - 1) * take, take: take, IsTracking: false, IsDeleted: true).ToListAsync();

            ICollection<TagItemDto> tagItemDtos = _mapper.Map<ICollection<TagItemDto>>(tags);

            return tagItemDtos;
        }
        public async Task UpdateAsync(int id, TagUpdateDto tagUpdateDto)
        {
            Tag tag = await _repository.GetByIdAsync(id);

            if (tag is null) throw new Exception("Not found");

            tag.Name = tagUpdateDto.Name;

            _repository.Update(tag);
            await _repository.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            Tag tag = await _repository.GetByIdAsync(id);

            if (tag is null) throw new Exception("Not found");

            _repository.Delete(tag);
            await _repository.SaveChangesAsync();
        }
        public async Task SoftDeleteAsync(int id)
        {
            Tag tag = await _repository.GetByIdAsync(id);
            if (tag is null) throw new Exception("Not found");
            _repository.SoftDelete(tag);
            await _repository.SaveChangesAsync();
        }

        public async Task<TagGetDto> GetAsync(int id)
        {
            Tag tag = await _repository.GetByIdAsync(id);
            if (tag is null) throw new Exception("Not found");
            var dto = _mapper.Map<TagGetDto>(tag);

            return dto;
        }
    }
}
