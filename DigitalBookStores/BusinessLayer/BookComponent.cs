using BusinessLayer.Interface;
using DataAccessLayer.Interface;
using System;
using System.Collections.Generic;
using WebAPIsEntities.Entities.BookDatabase;

namespace BusinessLayer
{
    public class BookComponent : IBookComponent
    {
        private readonly IBookDataAccess _bookDataAccess;
        public BookComponent(IBookDataAccess bookDataAccess)
        {
            _bookDataAccess = bookDataAccess;
        }

        public int DeleteBook(long bID)
        {
            return _bookDataAccess.DeleteBook(bID);
        }

        public BookData GetBookById(long bookId)
        {
            return _bookDataAccess.GetBookById(bookId);
        }

        public List<BookData> GetList()
        {
            return _bookDataAccess.GetList();
        }

        public int InsertNewBook(BookData book)
        {
            return _bookDataAccess.InsertNewBook(book);
        }

        public int UpdateBook(BookData book)
        {
            return _bookDataAccess.UpdateBook(book);
        }
    }
}
