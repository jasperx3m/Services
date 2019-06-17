using System;
using System.Collections.Generic;
using System.Text;

namespace DomainServices
{
    public class UserDomainServices
    {
        List<User> users = new List<User>();
        public void BanUser(DateTime deadline, int id, DateTime banLine)
        {
            DateTime today = DateTime.Now;
            TimeSpan dayspassed = today - deadline;
            if (dayspassed.Days > 5)
            {
                foreach (var i in users)
                {
                    if (i.UserID == id)
                    {
                        i.MembershipStatus = false;
                    }
                }
            }
        }
        public void ReActivateUser(int id)
        {
            foreach (var i in users)
            {
                if (i.UserID == id)
                {
                    i.MembershipStatus = true;
                }
            }
        }
        public double OverdueFeeCalculator(DateTime deadline, DateTime datereturned)
        {
            double fee;
            TimeSpan dayspassed = datereturned - deadline;
            fee = dayspassed.Days * 22.75;
            return fee;
        }
        public void SaveUser(User user)
        {

        }
    }
}
