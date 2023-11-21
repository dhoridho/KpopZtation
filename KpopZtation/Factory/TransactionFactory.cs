using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public static class TransactionFactory
    {
        public static TransactionHeader CreateTransactionHeader(int customerId)
        {
            return new TransactionHeader()
            {
                CustomerID = customerId,
                TransactionDate = DateTime.Now
            };
        }

        public static TransactionDetail CreateTransactionDetail(int headerId, int songId)
        {
            return new TransactionDetail()
            {
                TransactionHeaderID = headerId,
                SongID = songId
            };
        }
    }
}
