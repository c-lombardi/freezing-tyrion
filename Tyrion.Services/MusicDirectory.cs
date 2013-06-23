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
        public static void Index(FileInfo mp3Path)
        {
            ArtistService artistService = new ArtistService();
            AlbumService albumService = new AlbumService();
            AudioFileService songService = new AudioFileService();
            Id3Tag tags = MusicDirectory.GetTags(mp3Path);
            Artist artist = new Artist() { ArtistName = tags.Artists };
            artist = artistService.AddOrGetArtist(artist);
            Album album = new Album() { AlbumArtist = tags.Band, AlbumName = tags.Album, ArtistId = artist.ArtistId };
            album = albumService.AddOrGetAlbum(album);
            AudioFile song = new AudioFile { Path = mp3Path.FullName, Title = tags.Title, AlbumId = album.AlbumId };
            song = songService.AddOrGetAudioFile(song);
        }
        public static Id3Tag GetTags(FileInfo mp3Path)
        {
            using (var fileStream = mp3Path.OpenRead())
            {
                using (Mp3Stream mp3 = new Mp3Stream(fileStream, Mp3Permissions.Read))
                {
                    return mp3.GetAllTags()[0];
                }
            }
        }
    }
}
