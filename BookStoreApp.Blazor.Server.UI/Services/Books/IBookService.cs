using BookStoreApp.Blazor.Server.UI.Services.Base;

namespace BookStoreApp.Blazor.Server.UI.Services.Books
{
    public interface IBookService
    { 
        Task<Response<int>> CreateBook(BookCreateDto bookCreateDto);

        Task<Response<List<BookReadOnlyDto>>> GetBooks();

        Task<Response<BookReadOnlyDto>> GetBook(int id);

        Task<Response<BookUpdateDto>> GetBookForUpdate(int id);

        Task<Response<int>> UpdateBook(int id, BookUpdateDto bookUpdateDto);


    }
}
