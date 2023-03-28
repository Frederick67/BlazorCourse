using AutoMapper;
using BookStoreApp.Blazor.Server.UI.Services.Base;

namespace BookStoreApp.Blazor.Server.UI.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorRealyOnlyDto, AuthorUpdateDto>().ReverseMap();
            CreateMap<AuthorRealyOnlyDto, AuthorDetailsDto>().ReverseMap();
            CreateMap< AuthorDetailsDto, AuthorUpdateDto>().ReverseMap();
            CreateMap<AuthorCreateDto, AuthorUpdateDto>().ReverseMap();
            CreateMap< AuthorRealyOnlyDto, AuthorUpdateDto>().ReverseMap();
            CreateMap<BookReadOnlyDto, BookUpdateDto>().ReverseMap();
        }
    }
}
