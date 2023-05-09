Oggi vedremo i passi per realizzare un progetto per visualizzare i dati di una tabella del DB Chinook.db


<b>CREAZIONE DEL PROGETTO .NET</b>

Creare una cartella sul desktop nominandola con il proprio : "cognome.nome.classe.nomedelprogetto"

Aprire la cartella in VisualStudio Code, creare un nuovo terminale e digitare la riga di comando : "dotnet new console". Questo comando andrà a generare dei file nella cartella che abbiamo aperto in Code.

Aggiungiamo al progetto il database chinook.db, scaricandolo tramite questo link: https://www.sqlitetutorial.net/wp-content/uploads/2018/03/chinook.zip


<b> COME USARE LA LIBRERIA sqlite-net-pcl </b>

La libreria necessaria per il progetto è : "using SQLite;",
digitare nel terminale la seguente riga di codice : "dotnet add package sqlite-net-pcl".
Sarà inoltre necessario installare l'estensione "SQLite" su Visual Studio Code

![image](https://user-images.githubusercontent.com/116790906/236854179-2b91937a-768c-4885-a5b5-b88a8a735c70.png)

Per visualizzare il database chinook.db direttamente da Visual Studio Code installare questa estensione:

![Estensione_ SQLite Viewer - morelli giovanni 4h LINQDb - Visual Studio Code 08_05_2023 16_48_00](https://user-images.githubusercontent.com/116790906/236856234-e3f78219-ad4e-4f8d-a148-d0ac2b25cb8c.png)


<b>chinook.db</b>

Chinook.db è un esempio di database relazionale utilizzato in diversi tutorial e documentazione per illustrare concetti di database. Contiene dati relativi a un'immaginaria azienda musicale chiamata Chinook, come ad esempio informazioni sugli artisti, gli album e i brani musicali. Puoi trovare ulteriori informazioni su Chinook.db sul sito web di SQLite: https://www.sqlite.org/samples/chinook.html

<b>CODICE C# </b>


- Riga di codice che ci permette di accedere alla libreria:

###
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
###

- Riga di codice per selezionare l'informazione voluta dal DB:

###
var tblArtist = cn1.Query<Artist>("select * from artists");
###

- Riga di codice per ordinare gli ID degli artisti:

###
var temporanea = tblArtist.OrderByDescending(x => x.Name).Max( y => y.ArtistId );
###

Tabella artists di chinook.db:

![Estensione_ SQLite Viewer - morelli giovanni 4h LINQDb - Visual Studio Code 08_05_2023 17_02_44](https://user-images.githubusercontent.com/116790906/236859668-b0325bb7-24ef-4384-b290-5b519256cbf4.png)
