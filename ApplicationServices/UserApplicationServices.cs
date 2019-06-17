using System;
using System.Collections.Generic;
using System.Text;
using DomainServices;
namespace ApplicationServices
{
    public class UserApplicationServices 
    {
        UserDomainServices userservice;
        List<User> userlist;
        List<Book> booklist;
        public void RegisterUser(User user)
        {
            
            userservice.SaveUser(user);
            //RegisterUser
        }
        public object BorrowBOok(User user, Book book)
        {
            return book;
            //BorrowBook Service
        }
        public object ReturnBook(User user, Book book)
        {
            return book;
            //ReturnBook Service
        }
    }
}
