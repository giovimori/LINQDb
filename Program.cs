using SQLite;

// 27/4/2023
// Connessione al db

SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtist = cn1.Query<Artist>("select * from artists");
Console.WriteLine($"In questa tabella ci sono {tblArtist.Count} record" );

// language INtegrate Query
// LINQ

// 4/5/2023
// foreach si passa tutti i record e mi scrive il nome

/*int x=0;
Artist[] vect= new Artist[tblArtist.Count];
   
while(x<tblArtist.Count)
{  
    vect[x] = tblArtist[x].Name;
    x++;
}  
*/

var temporanea = tblArtist.OrderByDescending(x => x.Name).Max( y => y.ArtistId );

foreach(var record in tblArtist)
{
    Console.WriteLine( $"{record.Name}" );
}

Console.WriteLine($"{temporanea}");

// Fine del main --- inizio delle dichiarazioni ---
public class Artist
{
    public int ArtistId{ get; set; }
    public string Name{ get; set; }
}
