using System;
using System.Collections.Generic;
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
        public int AlbumId { get; set; }
        public int AlbumName { get; set; }
        public int AlbumArtist { get; set; }

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
    }
}
