using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyrion.Models;
using System.Data.Entity;
using System.Data;

namespace Tyrion.Services
{
    public class ArtistService : IModelService
    {
        /// <summary>
        /// Adds an Object
        /// </summary>
        /// <param name="o">IDatabaseModel to Add</param>
        /// <returns>True if Successful</returns>
        public bool Add(IDatabaseModel o)
        {
            var artist = (Artist)o;
            using (MusicContext db = new MusicContext())
            {
                if (db.Artists.Any(a => a.ArtistName == artist.ArtistName))
                    return false;
                db.Artists.Add(artist);
                db.SaveChanges();
                return true;
            }
        }
        /// <summary>
        /// Updates an Object
        /// </summary>
        /// <param name="o">Object to Update</param>
        /// <returns>True if Successful</returns>
        public bool Update(IDatabaseModel o)
        {
            var artist = (Artist)o;
            using (MusicContext db = new MusicContext())
            {
                db.Entry(artist).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }
        /// <summary>
        /// Removes an Artist Object
        /// </summary>
        /// <param name="o">Object to Remove</param>
        /// <returns>True if successful</returns>
        public bool Remove(IDatabaseModel o)
        {
            var artist = (Artist)o;
            using (MusicContext db = new MusicContext())
            {
                db.Artists.Remove(artist);
                db.SaveChanges();
                return true;
            }
        }
        /// <summary>
        /// Remove an Artist By Id
        /// </summary>
        /// <param name="id">Id of Artist</param>
        /// <returns>True If Successful</returns>
        public bool Remove(int id)
        {
            using (MusicContext db = new MusicContext())
            {
                var artist = db.Artists.FirstOrDefault(fd => fd.ArtistId == id);
                if (artist == null)
                    return false;
                db.Artists.Remove(artist);
                db.SaveChanges();
                return true;
            }
        }
        /// <summary>
        /// Add or Gets an Artist
        /// </summary>
        /// <param name="obj">Artist to add or get</param>
        /// <returns>Artist Id</returns>
        public int AddOrGet(IDatabaseModel obj)
        {
            Artist artist = (Artist)obj;
            using (MusicContext db = new MusicContext())
            {
                if (db.Artists.Any(a => a.ArtistName == artist.ArtistName))
                {
                    return db.Artists.Where(w => w.ArtistName == artist.ArtistName).Select(s=>s.ArtistId).FirstOrDefault();
                }
                else
                {
                    this.Add(artist);
                    return artist.ArtistId;
                }
            }
        }
    }
}
