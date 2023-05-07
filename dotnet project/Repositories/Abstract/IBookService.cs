
using dotnet_project.Models.DTO;
using dotnet_project.Models.Domain;

namespace dotnet_project.Repositories.Abstract

{
    public interface IBookService
    {
        bool Add(Book model);
        bool Update(Book model);
        Book GetById(int id);
        bool Delete(int id);
        BookListVm List(string term = "", bool paging = false, int currentPage = 0);
        List<int> GetGenreByBookId(int bookId);

    }
}