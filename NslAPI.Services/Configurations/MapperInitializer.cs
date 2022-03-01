using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using NslAPI.Data;
using NslAPI.Services.DTOs;

namespace NslAPI.Services.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<Member, MemberDTO>().ReverseMap();
            CreateMap<Member, CreateMemberDTO>().ReverseMap();
            CreateMap<Player, PlayerDTO>().ReverseMap();
            CreateMap<Player, CreatePlayerDTO>().ReverseMap();
            CreateMap<Fees, FeesDTO>().ReverseMap();
            CreateMap<Fees, CreateFeesDTO>().ReverseMap();
            CreateMap<ApiUser, UserDTO>().ReverseMap();
        }
    }
}
