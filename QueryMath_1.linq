<Query Kind="Statements">
  <Connection>
    <ID>ee45e3c7-6838-4536-967a-cd862142f99e</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from g in Genres
              orderby g.Name
			  select new
			  {
			    Genre = g.Name,
				TracksCount = g.Tracks.Count()
			};
results.Dump("Query Math");