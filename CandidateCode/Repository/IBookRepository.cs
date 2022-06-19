using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandidateCode.Model;
namespace CandidateCode.Repository
{
    public interface IBookRepository
    {
        Book AddBook(Book book);
        List<Book> GetAllBooks();
        bool DeleteBook(int id);
        bool UpdateBook(int id, Book book);


    }
}