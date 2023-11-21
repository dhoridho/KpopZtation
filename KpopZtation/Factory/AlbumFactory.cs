using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public static class AlbumFactory
    {
        public static Album CreateAlbum(string albumName, int artistId)
        {
            return new Album()
            {
                AlbumName = albumName,
                ArtistID = artistId,
            };
        }
    }
}