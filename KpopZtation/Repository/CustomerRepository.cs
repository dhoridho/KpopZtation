using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CustomerRepository
    {
        public static LocalDBEntities db = new LocalDBEntities();
        public static bool CreateUser(string username, string email, string password, string gender, string address)
        {
            Customer u = CustomerFactory.CreateUser(username, email, password, gender, address, "Customer");
            db.Customers.Add(u);
            db.SaveChanges();
            return true;
        }

        public static Customer GetUser(string email, string password)
        {
            return (from u in db.Customers where email.Equals(u.CustomerEmail) && password.Equals(u.CustomerPassword) select u).FirstOrDefault();
        }
        public static Customer GetUserByID(int id)
        {
            return db.Customers.FirstOrDefault(u => u.CustomerID == id);
        }
        public static Customer GetUserByEmail(string email)
        {
            return db.Customers.FirstOrDefault(u => u.CustomerEmail == email);
        }
        public static Customer GetUserRole(string role)
        {
            return db.Customers.FirstOrDefault(u => u.CustomerRole == role);
        }


        public static void UpdateCustomer(int id, string username, string email, string password, string gender, string address)
        {
            Customer u = GetUserByID(id);

            u.CustomerName = username;
            u.CustomerEmail = email;
            u.CustomerPassword = password;
            u.CustomerGender = gender;
            u.CustomerAddress = address;

            db.SaveChanges();
        }
    }

}