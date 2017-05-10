<Query Kind="Statements">
  <Connection>
    <ID>ee45e3c7-6838-4536-967a-cd862142f99e</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              where g.Name.Equals("Heavy Metal")
			  select new 
			  {
			     TracksCount = g.Tracks.Count(),
				 Tracks = from t in g.Tracks
				    select new
				{
				  TrackName = t.Name,
				  AlbumName = t.Album.Title,
				  Milliseconds = t.Milliseconds,
				  Size = (t.Bytes / 1000)+"kb",
				  Price = t.UnitPrice
				  }
			};
results.Dump();