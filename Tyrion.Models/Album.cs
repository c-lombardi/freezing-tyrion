using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrion.Models
{
    public class Album : IDatabaseModel
    {
        public Album()
        {
            this.Songs = new List<AudioFile>();
        }

        [Key]
        public int AlbumId { get; set; }

        public string AlbumName { get; set; }
        public string AlbumArtist { get; set; }

        /// <summary>
        /// Artist Information
        /// </summary>
        public int ArtistId { get; set; }
        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; }

        /// <summary>
        /// Songs
        /// </summary>
        public ICollection<AudioFile> Songs { get; set; }

        public void Load()
        {
            using (MusicContext db = new MusicContext())
            {
                db.Entry(this).Reference(r => r.Artist).Load();
                db.Entry(this).Collection(c => c.Songs).Load();
            }
        }
        public static int GetDefaultId()
        {
            using (MusicContext db = new MusicContext())
            {
                if (db.Albums.Any(a => a.AlbumName == "Unknown"))
                {
                    return db.Albums.Where(w => w.AlbumName == "Unknown").Select(s=>s.AlbumId).FirstOrDefault();
                }
                else
                {
                    var artistId = Artist.GetDefaultId();
                    Album album = new Album() { AlbumName = "Unknown", AlbumArtist = "Unknown", ArtistId = artistId };
                    db.Albums.Add(album);
                    db.SaveChanges();
                    return album.AlbumId;
                }
            }
        }
    }
}
