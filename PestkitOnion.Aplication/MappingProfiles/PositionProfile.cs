using AutoMapper;
using PestKitOnion.Application.DTOs.Author;
using PestKitOnion.Application.DTOs.Position;
using PestKitOnion.Application.DTOs.Positions;
using PestKitOnion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PestKitOnion.Application.MappingProfiles
{
    public class PositionProfile:Profile
    {
        public PositionProfile()
        {
            CreateMap<Position, PositionItemDto>();
            CreateMap<Position, PositionGetDto>();
            CreateMap<PositionCreateDto, Position>();
        }
    }
}
