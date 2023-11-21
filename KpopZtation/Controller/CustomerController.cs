using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Controller
{
    public class CustomerController
    {
        public static bool loginController(string username, string password)
        {
            if (username.Equals("") || password == "") return false;

            return true;
        }

        public static bool registerController(string username, string password, string email, string gender, string address)
        {
            if (username.Equals("") || email.Equals("") || gender.Equals("") || address.Equals("") || password == "") return false;

            return CustomerRepository.CreateUser(username, email, password, gender, address);
        }
    }
}