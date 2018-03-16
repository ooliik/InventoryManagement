using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Web.Configuration
{
    public static class AutoMapperConfig
    {
        public static IMapperConfigurationExpression AddMapping(this IMapperConfigurationExpression configurationExpression)
        {
            Mapper.Initialize(mapper =>
            {
                //mapper.CreateMap<Post, PostVm>()
                //    .ForMember(dest => dest.Author, y => y.MapFrom(src => src.Author.UserName));
             
            });
            return configurationExpression;
        }
    }
}
