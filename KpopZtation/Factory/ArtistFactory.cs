using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class ArtistFactory
    {
        public static Artist CreateArtist(int id, string name, string image)
        {
            return new Artist()
            {
                ArtistID = id,
                ArtistName = name,
                ArtistImage = image
            };
        }
    }
}