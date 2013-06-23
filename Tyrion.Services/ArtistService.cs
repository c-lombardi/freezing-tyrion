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
    public class ArtistService : ModelService
    {

        public bool Add(IDatabaseModel o)
        {
            var artist = (Artist)o;
            using (MusicContext db = new MusicContext())
            {
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
                db.Artists.Remove(artist);
                db.SaveChanges();
                return true;
            }
        }
    }
}
