using KpopZtation.Factory;
using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class AlbumRepository
    {
        public static LocalDBEntities db = new LocalDBEntities();

        public static void CreateAlbum(string albumName, int artistId)
        {
            Album album = AlbumFactory.CreateAlbum(albumName, artistId);
            db.Albums.Add(album);
            db.SaveChanges();
        }

        public static List<Album> GetAllAlbums()
        {
            return db.Albums.ToList();
        }

        public static Album GetAlbumById(int id)
        {
            return db.Albums.FirstOrDefault(a => a.AlbumID == id);
        }

        public static void UpdateAlbum(int id, string albumName, int artistId)
        {
            Album album = GetAlbumById(id);
            album.AlbumName = albumName;
            album.ArtistID = artistId;
            db.SaveChanges();
        }

        public static void DeleteAlbum(int id)
        {
            Album album = GetAlbumById(id);
            db.Albums.Remove(album);
            db.SaveChanges();
        }
    }
}