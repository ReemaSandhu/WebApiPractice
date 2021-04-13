using System;
using System.Collections.Generic;
using System.Text;
using WebAPIsEntities.Entities.BookDatabase;

namespace BusinessLayer.Interface
{
    public interface IBookComponent
    {
        int InsertNewBook(BookData book);
        List<BookData> GetList();
        int DeleteBook(long bID);
        int UpdateBook(BookData book);
        BookData GetBookById(long bookId);
    }
}
