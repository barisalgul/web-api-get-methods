using BookListWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

/// <summary>
/// Created by Barış Algül(baris@barisalgul.com)
/// </summary>

namespace BookListWebApi.Controllers
{
    public class BooksController : ApiController
    {

        /// <summary>
        /// Books are creating.
        /// </summary>
        Book[] books = new Book[]
        {
            new Book {Book_ID=1, Book_Name="Sherlock Holmes",Book_Writer="Arthur Conan Doyle", Book_Price=23.55 },
            new Book {Book_ID=2, Book_Name="Don Quixote", Book_Writer="Charles Dickens", Book_Price =50.45 },
            new Book {Book_ID=3, Book_Name="The Hobbit", Book_Writer="J. R. R. Tolkien", Book_Price =47.70 },
            new Book {Book_ID=4, Book_Name="Alice in Wonderland", Book_Writer="Lewis Carroll", Book_Price =45.00 },
            new Book {Book_ID=5, Book_Name="And Then There Were None",Book_Writer="Agatha Christie", Book_Price=22.55 },
            new Book {Book_ID=6, Book_Name="Dream of the Red Chamber", Book_Writer="Cao Xueqin", Book_Price =35.45 },
            new Book {Book_ID=7, Book_Name="Harry Potter and the Half-Blood Prince", Book_Writer="J. K. Rowling", Book_Price =33.90 },
            new Book {Book_ID=8, Book_Name="The Eagle Has Landed", Book_Writer="Jack Higgins", Book_Price =25.35 }
        };
        

        /// <summary>
        /// Get All Books
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> GetAllBooks() {
            return books;
        }

        public IHttpActionResult GetBook(int id) {
            var _book = books.FirstOrDefault(x => x.Book_ID == id);
            if (_book == null)
            {
                return NotFound();
            }
            return Ok(_book);
        }
    }
}
