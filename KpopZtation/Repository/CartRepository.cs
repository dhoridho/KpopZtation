using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CartRepository
    {
        public static LocalDBEntities db = new LocalDBEntities();

        public static void AddToCart(int customerId, int songId)
        {
            CART cart = CartFactory.CreateCart(customerId, songId);
            db.CARTs.Add(cart);
            db.SaveChanges();
        }

        public static List<CART> GetCartItems(int customerId)
        {
            return db.CARTs.Where(c => c.CustomerID == customerId).ToList();
        }

        public static void RemoveFromCart(int custID, int albumID)
        {
            CART cart = db.CARTs.FirstOrDefault(c => c.CustomerID == custID && c.AlbumID == albumID);
            db.CARTs.Remove(cart);
            db.SaveChanges();
        }
    }
}
