using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public static class CartFactory
    {
        public static CART CreateCart(int customerId, int AlbumiD)
        {
            return new CART()
            {
                CustomerID = customerId,
                AlbumID = AlbumiD
            };
        }
    }
}
