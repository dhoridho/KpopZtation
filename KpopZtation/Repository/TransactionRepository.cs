using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class TransactionRepository
    {
        public static LocalDBEntities db = new LocalDBEntities();

        public static void CreateTransaction(int customerId, List<int> songIds)
        {
            TransactionHeader transactionHeader = TransactionFactory.CreateTransactionHeader(customerId);
            db.TransactionHeaders.Add(transactionHeader);
            db.SaveChanges();

            foreach (int songId in songIds)
            {
                TransactionDetail transactionDetail = TransactionFactory.CreateTransactionDetail(transactionHeader.TransactionID, songId);
                db.TransactionDetails.Add(transactionDetail);
            }

            db.SaveChanges();
        }

        public static List<TransactionHeader> GetTransactionsByCustomer(int customerId)
        {
            return db.TransactionHeaders.Where(t => t.CustomerID == customerId).ToList();
        }

        public static List<TransactionDetail> GetTransactionDetailsByHeader(int headerId)
        {
            return db.TransactionDetails.Where(t => t.TransactionHeaderID == headerId).ToList();
        }
    }
}
