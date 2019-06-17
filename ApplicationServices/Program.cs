using System;
using DomainServices;
namespace ApplicationServices
{
    class Program
    {
        static void Main(string[] args)
        {

            BookApplicationServices bookAppoperation = new BookApplicationServices();
            
            Console.WriteLine("What would You like to do [1]Add a Book [2] Remove a Book [3]Search a Book [4]GetBookList");
            int select = Int32.Parse(Console.ReadLine());
            if (select == 1)
            {
                bookAppoperation.AddNewBook();
            }
            if (select == 2)
            {
                bookAppoperation.RemoveBook();
            }
            if (select == 3)
            {
                bookAppoperation.SearchBook();
            }
            if (select == 4)
            {
                bookAppoperation.GetBookList();
            }

        }
    }
}
