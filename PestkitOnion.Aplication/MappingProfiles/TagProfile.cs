using AutoMapper;
using PestKitOnion.Application.DTOs.Tag;
using PestKitOnion.Application.DTOs.Tags;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.MappingProfiles
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, TagItemDto>();
            CreateMap<Tag, TagGetDto>();
            CreateMap<TagCreateDto, Tag>();
        }
    }
}
