using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class ArtistRepository
    {
        private static LocalDBEntities db = DBHelper.GetDBEntities();

        public static List<Artist> GetAllArtist()
        {
            return db.Artists.ToList();
        }
        public static Artist GetArtistByID(int id)
        {
            return (from x in db.Artists where x.ArtistID.Equals(id) select x).FirstOrDefault();
        }

        public static bool UpdateArtist(int id, string name, string image)
        {
            Artist user = (from x in db.Artists where id.Equals(x.ArtistID) select x).FirstOrDefault();
            user.ArtistName = name;
            user.ArtistImage = image;

            db.SaveChanges();

            return true;
        }
    }
}