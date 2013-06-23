using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrion.Models
{
    public class AudioFile : IDatabaseModel
    {
        [Key]
        public int AudioFileId { get; set; }

        public string Path { get; set; }
        public string Title { get; set; }

        /// <summary>
        /// Album Information
        /// </summary>
        public int AlbumId { get; set; }
        [ForeignKey("AlbumId")]
        public Album Album { get; set; }

        public void Load()
        {
            using (MusicContext db = new MusicContext())
            {
                db.Entry(this).Reference(r => r.Album).Load();
            }
        }
    }
}
