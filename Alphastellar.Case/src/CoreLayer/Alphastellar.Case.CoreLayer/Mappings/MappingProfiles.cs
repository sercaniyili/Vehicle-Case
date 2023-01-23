using Alphastellar.Case.CoreLayer.DTOs.Boat;
using Alphastellar.Case.CoreLayer.DTOs.Bus;
using Alphastellar.Case.CoreLayer.DTOs.Car;
using Alphastellar.Case.CoreLayer.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphastellar.Case.CoreLayer.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Car, GetCarsDto>().ReverseMap();
            CreateMap<Car, UpdateCarHeadlightsDto>().ReverseMap();
            CreateMap<Car, AddCarDto>().ReverseMap();
            CreateMap<Bus, GetBusesDto>().ReverseMap();
            CreateMap<Boat, GetBoatsDto>().ReverseMap();
        }
    }
}
