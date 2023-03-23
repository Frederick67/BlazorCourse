using AutoMapper;
using Blazored.LocalStorage;
using BookStoreApp.Blazor.Server.UI.Services.Base;

namespace BookStoreApp.Blazor.Server.UI.Services.Authors
{
    public class AuthorService : BaseHttpService, IAuthorService
    {
        private readonly IClient _client;
        private readonly ILocalStorageService _localstorage;
        private readonly IMapper _mapper;
        public AuthorService(IClient client, ILocalStorageService localStorage, IMapper mapper) : base(client, localStorage)
        {
            _client = client;
            _localstorage = localStorage;
            _mapper = mapper;

        }

        public async Task<Response<int>> CreateAuthor(AuthorCreateDto author)
        {
            Response<int> response = new Response<int>() { Success = true };
            try
            {
                await GetBearerToken();
                await _client.AuthorsPOSTAsync(author);
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<int>(ex);
            }
            return response;
        }

        public async Task<Response<int>> EditAuthor(int id, AuthorUpdateDto author)
        {
            Response<int> response = new Response<int>() { Success= true };
            try
            {
                await GetBearerToken();
                await _client.AuthorsPUTAsync(id, author);
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<int>(ex);
            }

            return response;
        }

        public async Task<Response<AuthorUpdateDto>> GetAuthorForUpdate(int id)
        {
            Response<AuthorUpdateDto> response;
            try
            {
                await GetBearerToken();
                var data = await _client.AuthorsGETAsync(id);
                response = new Response<AuthorUpdateDto>()
                {
                    Data = _mapper.Map<AuthorUpdateDto>(data),
                    Success = true
                };
            }
            catch (ApiException e)
            {
                response = ConvertApiExceptions<AuthorUpdateDto>(e);
            }

            return response;
        }

        public async Task<Response<List<AuthorRealyOnlyDto>>> GetAuthors()
        {
            Response<List<AuthorRealyOnlyDto>> response;
            try
            {
                await GetBearerToken();
                var data = await _client.AuthorsAllAsync();
                response = new Response<List<AuthorRealyOnlyDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException e)
            {
                response = ConvertApiExceptions<List<AuthorRealyOnlyDto>>(e);
            }

            return response;
        }

        public async Task<Response<AuthorRealyOnlyDto>> GetAuthor(int id)
        {
            Response<AuthorRealyOnlyDto> response;
            try
            {
                await GetBearerToken();
                var data = await _client.AuthorsGETAsync(id);
                response = new Response<AuthorRealyOnlyDto>()
                {
                    Data = _mapper.Map<AuthorRealyOnlyDto>(data),
                    Success = true
                };
            }
            catch (ApiException e)
            {
                response = ConvertApiExceptions<AuthorRealyOnlyDto>(e);
            }

            return response;
            

        }

        public async Task<Response<AuthorDetailsDto>> GetAuthorDetails(int id)
        {
           Response<AuthorDetailsDto> response;
            try
            {
                await GetBearerToken();
                var data = await _client.AuthorsGETAsync(id);
                response = new Response<AuthorDetailsDto>()
                {
                    Data = _mapper.Map<AuthorDetailsDto>(data),
                    Success = true
                };
            }
            catch (ApiException e)
            {
                response = ConvertApiExceptions<AuthorDetailsDto>(e);
            }
            return response;
        }

        public async Task<Response<int>> DeleteAuthor(int id)
        {
            Response<int> response = new Response<int>() { Success = true };
            try
            {
                await GetBearerToken();
                await _client.AuthorsDELETEAsync(id);
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<int>(ex);
            }
            return response;
        }
    }
}
