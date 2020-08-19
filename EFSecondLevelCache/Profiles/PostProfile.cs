using AutoMapper;
using EFSecondLevelCache.DataLayer.Entities;
using EFSecondLevelCache.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFSecondLevelCache.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostDto>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(src => $"{src.User.Name}"))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src => $"{src.Title}"));
        }
    }
}
