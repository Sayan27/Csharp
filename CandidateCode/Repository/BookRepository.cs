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
    }
}