using System;
using System.Collections.Generic;
using System.Text;
using DomainServices;
namespace ApplicationServices
{
    public class BookApplicationServices 
    {
        private BookDomainServices bookDomainoperation = new BookDomainServices();
        private BookRepo bookrepo = new BookRepo();
        public void AddNewBook()
        {
            Console.WriteLine("Enter Book Name, Category and Quantity");
            string name = Console.ReadLine();
            string category = Console.ReadLine();
            int qty = Int32.Parse(Console.ReadLine());
            Guid id = bookDomainoperation.GenerateBookID();
            
            Book newbook = new Book
            {
                BookID = id,
                BookName = name,
                Category=category,
                Qty = qty
            };
            bookrepo.AddBooktoRepo(newbook);
        }
        public void RemoveBook()
        {
            Console.WriteLine("Enter Book ID");
            Guid id = Guid.Parse(Console.ReadLine());
            bookrepo.RemoveBookfromRepo(id);
        }
        public void SearchBook()
        {
            Console.WriteLine("Enter Book name");
            string name = Console.ReadLine();
            bookrepo.SearchfromRepo(name);
        }
        public void GetBookList(int age)
        {
            Console.WriteLine("Book List");
            if (age<18)
            {
                bookrepo.DisplayBookListForChild();
            }
            else
            {
                bookrepo.DisplayBookList();
            }
        }
        

    }
}
