using System;
using System.Collections.Generic;
using System.Text;

namespace DomainServices
{
    public class User
    {
        public bool MembershipStatus{ get; set; }
        public int UserID { get; set; }
        public int Name { get; set; }
        public int Age { get; set; }
        public int Password { get; set; }
    }
}
