using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DomainServices
{
    public class BookRepo
    {
        private List<Book> books;
        public void AddBooktoRepo(Book book)
        {
            books.Add(book);
        }
        public void RemoveBookfromRepo(Guid id)
        {
            var toremove = from x in books where x.BookID.Equals(id) select x;
            books.RemoveAll(toremove.Contains);
        }
        public object SearchfromRepo(string name)
        {
            var tosearch = from x in books where x.BookName.Contains(name) select x;
            return tosearch;
        }
        public object DisplayBookList()
        {
                return books;
        }
        public object DisplayBookListForChild()
        {
            var ChildList = from x in books where !x.Category.Contains("Mature") select x;
            return ChildList;
        }
    }
}
