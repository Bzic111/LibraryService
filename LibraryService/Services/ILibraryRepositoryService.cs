using LibraryService.Models;
using System.Collections.Generic;

namespace LibraryService.Services.impl
{
    internal interface ILibraryRepositoryService : IRepository<Book, string>
    {
        IList<Book> GetByTitle(string title);
        IList<Book> GetByAuthor(string author);
        IList<Book> GetByCategory(string category);
    }
}
