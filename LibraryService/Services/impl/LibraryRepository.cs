using LibraryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryService.Services.impl
{
    public class LibraryRepository : ILibraryRepositoryService
    {
        private readonly ILibraryDatabaseContextService _dbContext;
        public LibraryRepository(ILibraryDatabaseContextService dbContext)
        {
            _dbContext = dbContext;
        }
        

        public IList<Book> GetAll()
        {
            return _dbContext.Books;
        }

        public IList<Book> GetByAuthor(string author)
        {
            try
            {
                return _dbContext.Books
                    .Where(b => b.Authors
                        .Where(a => a.Name.ToLower().Contains(author.ToLower()))
                        .Count() > 0)
                    .ToList();
            }
            catch 
            {
                return new List<Book>(0);
            }
        }

        public IList<Book> GetByCategory(string category)
        {
            try
            {
                return _dbContext.Books
                    .Where(b => b.Category.ToLower().Contains(category.ToLower()))
                    .ToList();
            }
            catch
            {
                return new List<Book>(0);
            }
        }

        public Book GetById(string id)
        {
            try
            {
                return _dbContext.Books.FirstOrDefault(b => b.Id == id);
            }
            catch 
            {

                return null;
            }
        }

        public IList<Book> GetByTitle(string title)
        {
            try
            {
                return _dbContext.Books.Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
            }
            catch
            {
                return new List<Book>(0);
            }
        }

        public int Update(Book item)
        {
            throw new NotImplementedException();
        }
        public int? Add(Book item)
        {
            throw new NotImplementedException();
        }

        public int Delete(Book item)
        {
            throw new NotImplementedException();
        }
    }
}