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
