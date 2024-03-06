using AutoMapper;
using idflApp.Core.Dtos;
using idflApp.Core.Models;

namespace idflApp
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateBook, BookModel>();
        }
    }
}
