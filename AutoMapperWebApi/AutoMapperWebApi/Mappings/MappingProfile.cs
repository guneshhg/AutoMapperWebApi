using AutoMapper;
using AutoMapperWebApi.DTOs;
using AutoMapperWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWebApi.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // CreateMap<Developer, DeveloperDTO>();
            CreateMap<Developer, DeveloperDTO>()
            .ForMember(dest => dest.Compensation, source => source.MapFrom(source => source.Salary))
            .ForMember(dest => dest.IsEmployed, source => source.MapFrom(source => source.Salary > 0 ? true : false))
            .ReverseMap();

            CreateMap<Address, AddressDTO>();
        }
    }
}
