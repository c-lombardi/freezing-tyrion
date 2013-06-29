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
                MusicDirectory.Add(tags, mp3Path.FullName);
            }
            else
            {
                MusicDirectory.Add(mp3Path);
            }
        }
        private static void Add(Id3Tag tags, string mp3Path)
        {
            ArtistService artistService = new ArtistService();
            AlbumService albumService = new AlbumService();
            AudioFileService songService = new AudioFileService();
            Artist artist = new Artist() { ArtistName = tags.Artists };
            artist = artistService.AddOrGetArtist(artist);
            Album album = new Album() { AlbumArtist = tags.Band, AlbumName = tags.Album, ArtistId = artist.ArtistId };
            album = albumService.AddOrGetAlbum(album);
            AudioFile song = new AudioFile { Path = mp3Path, Title = tags.Title, AlbumId = album.AlbumId };
            song = songService.AddOrGetAudioFile(song);
        }
        private static void Add(FileInfo mp3Path)
        {
            AudioFileService songService = new AudioFileService();
            var artist = Artist.GetDefaultArtist();
            var album = Album.GetDefaultAlbum();
            AudioFile song = new AudioFile { Path = mp3Path.FullName, Title = mp3Path.Name, AlbumId = album.AlbumId };
            song = songService.AddOrGetAudioFile(song);
        }
        private static Id3Tag GetTags(FileInfo mp3Path)
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
