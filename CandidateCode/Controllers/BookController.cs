using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandidateCode.Model;
using CandidateCode.Repository;
using CandidateCode.ViewModels;
namespace CandidateCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookController:ControllerBase
    {
        IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository=bookRepository;
        }
          [HttpPost]
    [Route("/api/book/addbook")]
    public IActionResult AddBook([FromBody] AddViewModel addViewModel)
    {
        Book book=new Book
        {
            BookName=addViewModel.BookName,
            AuthorName=addViewModel.AuthorName,
            Price=addViewModel.Price

        };
        var addedBook=_bookRepository.AddBook(book);
        return Ok(addedBook);
    }
    [HttpGet]
    [Route("/api/book/getbooks")]
    public IActionResult GetAllBooks()
    {
        var books = _bookRepository.GetAllBooks();
         if (books == null)
            {
                NotFound("No books Found!!!");
            }
        return Ok(books);

    }
    [HttpDelete]
    [Route("/api/book/deletebooks")]
      public IActionResult DeleteBook(int id)
        {
            bool isBookRemoved = _bookRepository.DeleteBook(id);
            if (!isBookRemoved)
            {
                return NotFound($"Book with id = {id} is not found.");
            }
            return Ok($"Book with id = {id} is removed successfully.");
        }





}
  


}