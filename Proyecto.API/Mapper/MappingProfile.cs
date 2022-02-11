using AutoMapper;
using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.API.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Users, UsersViewModel>()
                .ForMember(x => x.email, opt => opt.MapFrom(s => s.email))
                .ForMember(x => x.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(x => x.name, opt => opt.MapFrom(s => s.name))
                .ForMember(x => x.isLoggedIn, opt => opt.MapFrom(s => s.isLoggedIn))
                .ForMember(x => x.role, opt => opt.MapFrom(s => s.role));

            CreateMap<Users, Products>();
        }
    }
}
