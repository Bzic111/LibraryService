using LibraryService.Models;
using System.Collections.Generic;

namespace LibraryService.Services.impl
{
    public interface ILibraryDatabaseContextService
    {
        IList<Book> Books { get; }
    }
}
