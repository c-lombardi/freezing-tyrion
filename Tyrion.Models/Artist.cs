﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrion.Models
{
    public class Artist : IDatabaseModel
    {
        public Artist()
        {
            this.Albums = new List<Album>();
        }

        [Key]
        public int ArtistId { get; set; }

        public string ArtistName { get; set; }

        /// <summary>
        /// Albums
        /// </summary>
        public ICollection<Album> Albums { get; set; }

        public void Load()
        {
            using (MusicContext db = new MusicContext())
            {
                db.Entry(this).Collection(c => c.Albums).Load();
            }
        }
        public static Artist GetDefaultArtist()
        {
            using (MusicContext db = new MusicContext())
            {
                if (db.Artists.Any(a => a.ArtistName == "Unknown"))
                {
                    return db.Artists.FirstOrDefault(fd => fd.ArtistName == "Unknown");
                }
                else
                {
                    Artist artist = new Artist()
                    {
                        ArtistName = "Unknown"
                    };
                    db.Artists.Add(artist);
                    db.SaveChanges();
                    return artist;
                }
            }
        }
    }
}
