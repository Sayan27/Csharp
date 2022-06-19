using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CandidateCode.DBContext;
using CandidateCode.Model;
namespace CandidateCode.Repository
{
    public class BookRepository:IBookRepository
    {
        ApplicationDbContext _applicationDbcontext;

        public BookRepository(ApplicationDbContext applicationDbcontext)
        {
            _applicationDbcontext=applicationDbcontext;
        }

        public Book AddBook(Book book)
        {
            _applicationDbcontext.Books.Add(book);
            _applicationDbcontext.SaveChanges();
            return book;
        }

        public List<Book> GetAllBooks()
        {
            return _applicationDbcontext.Books.ToList();
        }

         public bool DeleteBook(int id)
        {
            bool isBookRemoved = false;
            var bookTobeRemoved = _applicationDbcontext.Books.FirstOrDefault(p => p.Id == id);
            if (bookTobeRemoved != null)
            {
              _applicationDbcontext.Books.Remove(bookTobeRemoved);
               _applicationDbcontext.SaveChanges();
                isBookRemoved = true;
            }
            return isBookRemoved;
        }

        public bool UpdateBook(int id, Book book)
        {
            bool isBookUpdated = false;
            var bookTobeUpdated = _applicationDbcontext.Books.FirstOrDefault(p => p.Id == id);
            if (bookTobeUpdated != null)
            {
                bookTobeUpdated.BookName = book.BookName;
                bookTobeUpdated.AuthorName = book.AuthorName;
                bookTobeUpdated.Price = book.Price;

                
                _applicationDbcontext.SaveChanges();
                isBookUpdated = true;

            }
            return isBookUpdated;

        }


    
}

}