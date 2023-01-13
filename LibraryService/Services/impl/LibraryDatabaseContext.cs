using LibraryService.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace LibraryService.Services.impl
{
    public class LibraryDatabaseContext : ILibraryDatabaseContextService
    {
        private IList<Book> _libraryDatabase; 
        public IList<Book> Books { get => _libraryDatabase; }
        public LibraryDatabaseContext()
        {
            Init();
        }
        private void Init()
        {
            _libraryDatabase = JsonConvert.DeserializeObject<List<Book>>(Encoding.UTF8.GetString(LibraryService.Properties.Resources.books));
        }
    }
}