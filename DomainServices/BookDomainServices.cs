using System;
using System.Collections.Generic;
using System.Text;

namespace DomainServices
{
    public class BookDomainServices 
    {
        public Guid GenerateBookID()
        {
            System.Guid bookid = System.Guid.NewGuid();
            return bookid;
        }
       
    }
}
