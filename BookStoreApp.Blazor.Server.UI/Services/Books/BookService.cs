using AutoMapper;
using Blazored.LocalStorage;
using BookStoreApp.Blazor.Server.UI.Services.Authors;
using BookStoreApp.Blazor.Server.UI.Services.Base;

namespace BookStoreApp.Blazor.Server.UI.Services.Books
{
    public class BookService : BaseHttpService, IBookService
    {
        private readonly IClient _client;
        private readonly ILocalStorageService _localstorage;
        private readonly IMapper _mapper;
        public BookService(IClient client, ILocalStorageService localStorage, IMapper mapper) : base(client, localStorage)
        {
            _client = client;
            _localstorage = localStorage;
            _mapper = mapper;

        }

        public async Task<Response<int>> CreateBook(BookCreateDto bookCreateDto)
        {
            Response<int> response = new Response<int>() { Success = true };
            try
            {
                await GetBearerToken();
                await _client.BooksPOSTAsync(bookCreateDto);

            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<int>(ex);
            }
            return response;
        }

        public async Task<Response<int>> DeleteBook(int id)
        {
            Response<int> response = new Response<int>() { Success = true };

            try
            {
                await GetBearerToken();
                await _client.BooksDELETEAsync(id);
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<int>(ex);
            }
            return response;

        }

        public async Task<Response<BookReadOnlyDto>> GetBook(int id)
        {
            Response<BookReadOnlyDto> response = new Response<BookReadOnlyDto>();

            try
            {
                await GetBearerToken();
                var data = await _client.BooksGETAsync(id);
                response = new Response<BookReadOnlyDto>()
                {
                    Data = _mapper.Map<BookReadOnlyDto>(data),
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<BookReadOnlyDto>(ex);
            }

            return response;

        }

        public async Task<Response<BookUpdateDto>> GetBookForUpdate(int id)
        {
            Response<BookUpdateDto> response;

            try
            {
                await GetBearerToken();
                var data = await _client.BooksGETAsync(id);
                response = new Response<BookUpdateDto>()
                {
                    Data = _mapper.Map<BookUpdateDto>(data),
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<BookUpdateDto>(ex);
            }

            return response;
            

        }

        public async Task<Response<List<BookReadOnlyDto>>> GetBooks()
        {
            Response<List<BookReadOnlyDto>> response;

            try
            {
                await GetBearerToken();
                var data = await _client.BooksAllAsync();
                response = new Response<List<BookReadOnlyDto>>()
                {
                    Data = data.ToList(),
                    Success = true
                };
                
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<List<BookReadOnlyDto>>(ex);
            }
            return response;

        }
        public async Task<Response<int>> UpdateBook(int id, BookUpdateDto bookUpdateDto)
        {
            Response<int> response = new Response<int>() { Success = true };

            try
            {
                await GetBearerToken();
                await _client.BooksPUTAsync(id, bookUpdateDto);
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<int>(ex);
            }

            return response;
        }
    }
}
