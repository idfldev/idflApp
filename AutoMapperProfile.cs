using AutoMapper;
using idflApp.Core.Dtos;
using idflApp.Core.Models;
using idflApp.Core.Resutls;

namespace idflApp
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
             CreateMap<IEnumerable<GetAllProjectResult>, IEnumerable<ProjectModel>>();
        }
    }
}
