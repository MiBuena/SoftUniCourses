using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace _02.CatalogInXMLFormat
{
    class Program
    {
        private const string MusicFilePath = "../../music.xml";

        private const string CatalogueFilePath = "../../catalogue.xml";

        static void Main(string[] args)
        {
            //CreateNewMusicDocument();

            //var xml = XDocument.Load(MusicFilePath);

            //var music = xml.XPathSelectElements("music");

            //ExtractAlbumNames(music);

            //ExtractAllArtistsAlphabetically(music);

            //ExtractArtistsAndNumberOfAlbums(music);

            //DeleteAlbumFromXml();

            //ExtractOldAlbums();


        }

        private static void ExtractOldAlbums()
        {
            var xml = XDocument.Load(CatalogueFilePath);

            var music = xml.XPathSelectElements("catalog");

            foreach (var profileElement in music.Descendants("album"))
            {
                if (int.Parse(profileElement.Attribute("year").Value) < DateTime.Now.Year - 5)
                {
                    Console.WriteLine(profileElement.Attribute("name").Value);
                    Console.WriteLine(profileElement.Attribute("price").Value);
                }
            }
        }

        private static void DeleteAlbumFromXml()
        {
            var xml = XDocument.Load(CatalogueFilePath);

            var music = xml.XPathSelectElements("catalog");

            foreach (var profileElement in music.Descendants("album").ToList())
            {
                if (int.Parse(profileElement.Attribute("price").Value) > 20)
                {
                    profileElement.Remove();
                }
            }
            xml.Save("../../cheap-albums-catalog.xml");
        }

        private static void ExtractArtistsAndNumberOfAlbums(IEnumerable<XElement> music)
        {
            Dictionary<string, int> artists = new Dictionary<string, int>();

            foreach (var artist in music.Descendants("artist").Attributes("name"))
            {
                if (artists.ContainsKey(artist.Value))
                {
                    artists[artist.Value]++;
                }
                else
                {
                    artists.Add(artist.Value, 1);
                }
            }

            foreach (var element in artists)
            {
                Console.WriteLine($"{element.Key} {element.Value}");
            }
        }

        private static void ExtractAllArtistsAlphabetically(IEnumerable<XElement> music)
        {
            SortedSet<string> artists = new SortedSet<string>();

            foreach (var artist in music.Descendants("artist").Attributes("name"))
            {
                artists.Add(artist.Value);
            }


            foreach (var element in artists)
            {
                Console.WriteLine(element);
            }
        }

        private static void ExtractAlbumNames(IEnumerable<XElement> music)
        {
            foreach (var album in music.Descendants("album").Attributes("title"))
            {
                Console.WriteLine(album.Value);
            }
        }

        private static void CreateNewMusicDocument()
        {
            var xmlDocument = new XElement("catalog");

            var albums = new XElement("albums");

            AddFirstAlbum(albums);

            AddSecondAlbum(albums);

            AddThirdAlbum(albums, xmlDocument);
        }

        private static void AddThirdAlbum(XElement albums, XElement xmlDocument)
        {
            Song firstSong = new Song()
            {
                TimeSpan = new TimeSpan(0, 2, 20),
                Title = "The best song"
            };

            Song secondSong = new Song()
            {
                TimeSpan = new TimeSpan(0, 3, 20),
                Title = "The second best song"
            };

            Album album = new Album()
            {
                Artist = "Lenux",
                Name = "Third",
                Price = 30m,
                Producer = "MM",
                Year = 2000
            };

            album.Songs.Add(firstSong);
            album.Songs.Add(secondSong);


            var albumXML = new XElement("album");

            albumXML.Add(new XAttribute("name", album.Name));
            albumXML.Add(new XAttribute("artist", album.Artist));
            albumXML.Add(new XAttribute("price", album.Price));
            albumXML.Add(new XAttribute("producer", album.Producer));

            albumXML.Add(new XAttribute("year", album.Year));

            var songs = new XElement("songs");


            foreach (var element in album.Songs)
            {
                var song = new XElement("song");
                song.Add(new XAttribute("title", element.Title));
                song.Add(new XAttribute("duration", element.TimeSpan));

                songs.Add(song);
            }

            albumXML.Add(songs);

            albums.Add(albumXML);

            xmlDocument.Add(albums);
            xmlDocument.Save("../../catalogue.xml");
        }

        private static void AddSecondAlbum(XElement albums)
        {
            Song firstSong = new Song()
            {
                TimeSpan = new TimeSpan(0, 2, 20),
                Title = "The best song"
            };

            Song secondSong = new Song()
            {
                TimeSpan = new TimeSpan(0, 3, 20),
                Title = "The second best song"
            };

            Album album = new Album()
            {
                Artist = "Lenux",
                Name = "The second best album",
                Price = 30m,
                Producer = "MM",
                Year = 2016
            };

            album.Songs.Add(firstSong);
            album.Songs.Add(secondSong);


            var albumXML = new XElement("album");

            albumXML.Add(new XAttribute("name", album.Name));
            albumXML.Add(new XAttribute("artist", album.Artist));
            albumXML.Add(new XAttribute("price", album.Price));
            albumXML.Add(new XAttribute("producer", album.Producer));

            albumXML.Add(new XAttribute("year", album.Year));

            var songs = new XElement("songs");


            foreach (var element in album.Songs)
            {
                var song = new XElement("song");
                song.Add(new XAttribute("title", element.Title));
                song.Add(new XAttribute("duration", element.TimeSpan));

                songs.Add(song);
            }

            albumXML.Add(songs);

            albums.Add(albumXML);
        }

        private static void AddFirstAlbum(XElement albums)
        {
            Song firstSong = new Song()
            {
                TimeSpan = new TimeSpan(0, 2, 20),
                Title = "The best song"
            };

            Song secondSong = new Song()
            {
                TimeSpan = new TimeSpan(0, 3, 20),
                Title = "The second best song"
            };

            Album album = new Album()
            {
                Artist = "Jon Bon Jovi",
                Name = "The best album",
                Price = 20m,
                Producer = "MM",
                Year = 2016
            };

            album.Songs.Add(firstSong);
            album.Songs.Add(secondSong);


            var albumXML = new XElement("album");

            albumXML.Add(new XAttribute("name", album.Name));
            albumXML.Add(new XAttribute("artist", album.Artist));
            albumXML.Add(new XAttribute("price", album.Price));
            albumXML.Add(new XAttribute("producer", album.Producer));

            albumXML.Add(new XAttribute("year", album.Year));

            var songs = new XElement("songs");


            foreach (var element in album.Songs)
            {
                var song = new XElement("song");
                song.Add(new XAttribute("title", element.Title));
                song.Add(new XAttribute("duration", element.TimeSpan));

                songs.Add(song);
            }

            albumXML.Add(songs);

            albums.Add(albumXML);
        }
    }
}
