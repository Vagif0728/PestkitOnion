using AutoMapper;
using PestKitOnion.Application.DTOs.Author;
using PestKitOnion.Application.DTOs.Authors;
using PestKitOnion.Domain.Entities;

namespace PestKitOnion.Application.MappingProfiles
{
    public class AuthorProfile:Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorItemDto>();
            CreateMap<Author, AuthorGetDto>();
            CreateMap<AuthorCreateDto, Author>();
        }
    }
}
