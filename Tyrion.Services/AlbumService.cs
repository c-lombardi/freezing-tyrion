﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyrion.Models;
using System.Data.Entity;

namespace Tyrion.Services
{
    public class AlbumService : IModelService
    {
        /// <summary>
        /// Adds an Object
        /// </summary>
        /// <param name="o">IDatabaseModel to Add</param>
        /// <returns>True if Successful</returns>
        public bool Add(IDatabaseModel o)
        {
            var album = (Album)o;
            using (MusicContext db = new MusicContext())
            {
                if (db.Albums.Any(a => a.AlbumName == album.AlbumName && a.ArtistId == album.ArtistId))
                    return false;
                db.Albums.Add(album);
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
            var album = (Album)o;
            using (MusicContext db = new MusicContext())
            {
                db.Entry(album).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }
        /// <summary>
        /// Removes an Album Object
        /// </summary>
        /// <param name="o">Object to Remove</param>
        /// <returns>True if successful</returns>
        public bool Remove(IDatabaseModel o)
        {
            var album = (Album)o;
            using (MusicContext db = new MusicContext())
            {
                db.Albums.Remove(album);
                db.SaveChanges();
                return true;
            }
        }
        /// <summary>
        /// Remove an Artist By Id
        /// </summary>
        /// <param name="id">Id of Album</param>
        /// <returns>True If Successful</returns>
        public bool Remove(int id)
        {
            using (MusicContext db = new MusicContext())
            {
                var album = db.Albums.FirstOrDefault(fd => fd.AlbumId == id);
                if (album == null)
                    return false;
                db.Albums.Remove(album);
                db.SaveChanges();
                return true;
            }
        }
        /// <summary>
        /// Add or Gets an Album
        /// </summary>
        /// <param name="obj">Album to add or get</param>
        /// <returns>Album Id</returns>
        public int AddOrGet(IDatabaseModel obj)
        {
            Album album = (Album)obj;
            using (MusicContext db = new MusicContext())
            {
                if (db.Albums.Any(a => a.AlbumName == album.AlbumName && a.ArtistId == album.ArtistId))
                {
                    return db.Albums.Where(w => w.AlbumName == album.AlbumName && w.ArtistId == album.ArtistId).Select(s=>s.AlbumId).FirstOrDefault();
                }
                else
                {
                    this.Add(album);
                    return album.AlbumId;
                }
            }
        }
    }
}