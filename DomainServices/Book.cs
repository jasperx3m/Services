using System;
using System.Collections.Generic;
using System.Text;

namespace DomainServices
{
    public class Book
    {
        public Guid BookID { get; set; }
        public string BookName { get; set; }
        public int Qty { get; set; }
        public string Category { get;set }

    }
}
