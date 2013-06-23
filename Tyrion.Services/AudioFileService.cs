using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyrion.Models;

namespace Tyrion.Services
{
    public class AudioFileService : ModelService
    {
        public bool Add(IDatabaseModel o)
        {
            var song = (AudioFile)o;
            using (MusicContext db = new MusicContext())
            {
                if (db.AudioFiles.Any(a => a.Path == song.Path))
                    return false;
                db.AudioFiles.Add(song);
                db.SaveChanges();
                return true;
            }
        }

        public bool Update(IDatabaseModel o)
        {
            var song = (AudioFile)o;
            using (MusicContext db = new MusicContext())
            {
                db.Entry(song).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool Remove(IDatabaseModel o)
        {
            var song = (AudioFile)o;
            using (MusicContext db = new MusicContext())
            {
                db.AudioFiles.Remove(song);
                db.SaveChanges();
                return true;
            }
        }
        public bool Remove(int id)
        {
            using (MusicContext db = new MusicContext())
            {
                var song = db.AudioFiles.FirstOrDefault(fd => fd.AudioFileId == id);
                if (song == null)
                    return false;
                db.AudioFiles.Remove(song);
                db.SaveChanges();
                return true;
            }
        }
        public AudioFile AddOrGetAudioFile(AudioFile song)
        {
            using (MusicContext db = new MusicContext())
            {
                if (db.AudioFiles.Any(a => a.Path == song.Path && a.AlbumId == song.AlbumId))
                {
                    return db.AudioFiles.FirstOrDefault(fd => fd.Path == song.Path && fd.AlbumId == song.AlbumId);
                }
                else
                {
                    this.Add(song);
                    return song;
                }
            }
        }
    }
}
