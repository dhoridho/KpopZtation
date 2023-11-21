using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class DBHelper
    {
        public static LocalDBEntities db = null;
        public static LocalDBEntities GetDBEntities()
        {

            if (db == null)
            {
                db = new LocalDBEntities();
                return db;
            }
            else
            {
                return db;
            }
        }
    }
}