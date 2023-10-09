using KreataBasicSchholSystem.Desktop.Models;
using System;
using System.Net;

namespace KreataBasicSchholSystem.Desktop.Repositories
{
    public class UserRepository
    {
        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser = true;
            return validUser;
        }

        public User? GetByUsername(string userName)
        {
             return new User
             {
                 Username = "gycsaba",
                 Email = "gyuris.csaba@vasvari.org",
                 FirstName = "Csaba",
                 LastName = "Gyuris"
             };
            //return null;
        }
    }
}
