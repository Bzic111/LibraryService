using LibraryService.Models;
using LibraryService.Services.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LibraryService
{
    /// <summary>
    /// Сводное описание для LibraryWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class LibraryWebService : System.Web.Services.WebService
    {
        private readonly ILibraryRepositoryService _repository;
        public LibraryWebService()
        {
            _repository = new LibraryRepository(new LibraryDatabaseContext());
        }

        [WebMethod]
        public Book[] GetBooksByTitle(string title)
        {
            return _repository.GetByTitle(title).ToArray();
        }
        [WebMethod]
        public Book[] GetBooksByAuthor(string author)
        {
            return _repository.GetByAuthor(author).ToArray();
        }
        [WebMethod]
        public Book[] GetBooksByCategory(string category) => _repository.GetByCategory(category).ToArray();
        [WebMethod]
        public Book[] GetAllBooks() => _repository.GetAll().ToArray();

    }
}
