using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class CustomerFactory
    {
        public static Customer CreateUser(string username, string email, string password, string gender, string address, string roles)
        {
            return new Customer()
            {
                CustomerName = username,
                CustomerEmail = email,
                CustomerPassword = password,
                CustomerGender = gender,
                CustomerAddress = address,
                CustomerRole = roles
            };
        }
    }
}