using System;
using System.Linq;
using SQLite;

namespace LinqDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var cn1 = new SQLiteConnection("chinook.db"))
            {
                cn1.CreateTable<Artist>();

                var artists = cn1.Table<Artist>().OrderBy(a => a.ArtistId).ThenBy(a => a.Name);

                Console.WriteLine("Artists:");
               
            

                foreach (var artist in artists)
                {
                    Console.WriteLine($"ArtistId: {artist.ArtistId}\tName: {artist.Name}");
                }
            }
        }
    }

    public class Artist
    {
        [PrimaryKey]
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}
