using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPIsEntities.Entities.BookDatabase;

namespace WebApiEntities
{
    public class BookDataAccess: IBookDataAccess
    {
        private readonly BookDetailsDBContext _context;
        public BookDataAccess(BookDetailsDBContext context)
        {
            _context = context;
        }
        public int InsertNewBook(BookData book)
        {
            _context.BookDetails.Add(book);
            return _context.SaveChanges();
        }
        public List<BookData> GetList()
        {
            return _context.BookDetails.ToList();
        }
        public int DeleteBook(long bID)
        {
            BookData book = _context.BookDetails.FirstOrDefault(x => x.BookID == bID);
            _context.BookDetails.Remove(book);
            return _context.SaveChanges();
        }
        public int UpdateBook(BookData book)
        {
            var bookData = _context.BookDetails.FirstOrDefault(x => x.BookID == book.BookID);
            bookData.BookTitle = book.BookTitle;
            bookData.AuthorName = book.AuthorName;
            bookData.Description = book.Description;
            bookData.Price = book.Price;
            bookData.Review = book.Review;
            bookData.Image = book.Image;
            return _context.SaveChanges();
        }
        public BookData GetBookById(long bookId)
        {
            return _context.BookDetails.FirstOrDefault(e => e.BookID == bookId);
        }
    }
}
