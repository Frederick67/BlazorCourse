using AutoMapper;
using BookStoreApp.API.Data;
using BookStoreApp.API.Models.Author;
using BookStoreApp.API.Models.Book;
using BookStoreApp.API.Models.User;

namespace BookStoreApp.API.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto , Author>().ReverseMap();
            CreateMap<AuthorRealyOnlyDto, Author>().ReverseMap();
            CreateMap<BookReadOnlyDto, Book>().ReverseMap();
            CreateMap<BookCreateDto, Book>().ReverseMap();
            CreateMap<BookUpdateDto, Book>().ReverseMap();
            CreateMap<BookDetailsDto, Book>().ReverseMap();
            CreateMap<UserDto, ApiUser>().ReverseMap();
        }
    }
}
