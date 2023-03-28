using Blazored.LocalStorage;
using System.Net.Http.Headers;

namespace BookStoreApp.Blazor.Server.UI.Services.Base
{
    public class BaseHttpService
    {
        private readonly IClient _client;
        private readonly ILocalStorageService _localstorage;
        public BaseHttpService(IClient client, ILocalStorageService localStorage)
        {
            _client = client;
            _localstorage = localStorage;
        }


        protected Response<Guid> ConvertApiExceptions<Guid>(ApiException apiException)
        {
            //add the case if statusCode is >200 and <300

            if (apiException.StatusCode >= 200 && apiException.StatusCode <= 299)
                return new Response<Guid>
                {
                    Message = apiException.Message,
                    Success = true,
                };
            switch (apiException.StatusCode)
            {       
                case 400:
                    return new Response<Guid>
                    {
                        Message = "Bad Request",
                        Success = false
                    };
                case 401:
                    return new Response<Guid>
                    {
                        Message = "Unauthorized",
                        Success = false
                    };
                case 403:
                    return new Response<Guid>
                    {
                        Message = "Forbidden",
                        Success = false
                    };
                case 404:
                    return new Response<Guid>
                    {
                        Message = "Not Found",
                        Success = false
                    };
                case 500:
                    return new Response<Guid>
                    {
                        Message = "Internal Server Error",
                        Success = false
                    };
                default:
                    return new Response<Guid>
                    {
                        Message = "Something went wrong",
                        Success = false
                    };
            }
        }

        protected async Task GetBearerToken()
        {
            var token = await _localstorage.GetItemAsync<string>("accessToken");

            if (token != null)
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
    }
}
