using BookStoreApp.Blazor.Server.UI.Services.Base;

namespace BookStoreApp.Blazor.Server.UI.Services.Authors
{
    public interface IAuthorService
    {
        Task<Response<List<AuthorRealyOnlyDto>>> GetAuthors();

        Task<Response<int>> CreateAuthor(AuthorCreateDto author);

        Task<Response<int>> EditAuthor(int id, AuthorUpdateDto author);

        Task<Response<AuthorRealyOnlyDto>> GetAuthor(int id);

        Task<Response<AuthorUpdateDto>> GetAuthorForUpdate(int id);

        Task<Response<AuthorDetailsDto>> GetAuthorDetails(int id);

        Task<Response<int>> DeleteAuthor(int id);
    }

}