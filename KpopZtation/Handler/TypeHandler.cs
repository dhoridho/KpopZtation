using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class TypeHandler
    {
        public static bool InsertArtist(int id, string name, string image)
        {
            return ArtistRepository.UpdateArtist(id, name, image);
        }
    }
}