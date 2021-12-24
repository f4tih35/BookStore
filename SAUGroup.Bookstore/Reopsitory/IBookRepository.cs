using SAUGroup.Bookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SAUGroup.Bookstore.Repository
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel model);
        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBookById(int id);
        Task<List<BookModel>> GetTopBookAsync(int count);
        List<BookModel> SearchBook(string title, string authorName);

        string GetAppName();
    }
}