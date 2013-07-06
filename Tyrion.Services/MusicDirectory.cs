using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyrion.Models;
using Id3;

namespace Tyrion.Services
{
    public class MusicDirectory
    {
        public static void IndexAudioFiles(string root)
        {
            DirectoryInfo rootDirectory = new DirectoryInfo(root);
            var mp3List = rootDirectory.GetFiles("*.*", SearchOption.AllDirectories).Where(w => w.Extension.ToLower().Contains("mp3"));
            foreach (var mp3 in mp3List)
            {
                MusicDirectory.Index(mp3);
            }
        }
        private static void Index(FileInfo mp3Path)
        {
            Id3Tag tags = MusicDirectory.GetTags(mp3Path);
            if (tags != null)
            {
                MusicDirectory.Add(tags, mp3Path.FullName, new ArtistService(),new AlbumService(),new AudioFileService());
            }
            else
            {
                MusicDirectory.Add(mp3Path.Name, mp3Path.FullName, new AudioFileService(), Album.GetDefaultId());
            }
        }
        public static bool Add(Id3Tag tags, string mp3Path, IModelService artistService, IModelService albumService, IModelService songService)
        {
            Artist artist = new Artist() { ArtistName = tags.Artists };
            int artistId = artistService.AddOrGet(artist);
            Album album = new Album() { AlbumArtist = tags.Band, AlbumName = tags.Album, ArtistId = artistId };
            int albumId = albumService.AddOrGet(album);
            AudioFile song = new AudioFile { Path = mp3Path, Title = tags.Title, AlbumId = albumId };
            int songId = songService.AddOrGet(song);
            return songId > 0 && albumId > 0 && artistId > 0;
        }
        public static bool Add(string fileName, string mp3Path, IModelService songService, int albumId)
        {
            AudioFile song = new AudioFile { Path = mp3Path, Title = fileName, AlbumId = albumId };
            int songId = songService.AddOrGet(song);
            return songId > 0;
        }
        public static Id3Tag GetTags(FileInfo mp3Path)
        {
            using (var fileStream = mp3Path.OpenRead())
            {
                using (Mp3Stream mp3 = new Mp3Stream(fileStream, Mp3Permissions.Read))
                {
                    Id3Tag tags = null;
                    if (mp3.HasTags)
                    {
                        tags = mp3.GetAllTags()[0];
                    }
                    return tags;
                }
            }
        }
    }
}
