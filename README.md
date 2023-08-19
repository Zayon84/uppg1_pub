# uppg1_pub
## Inlämningsuppgift 1 Publicering Molntjänster, David Almkvist

### Mål med Uppgiften
Utveckla och implementera en skalbar webbapplikation på Azure med
hjälp av Docker och Docker Compose. 


### Vad har jag gjort för project?
För detta projekt valde jag att använda .Net Core med Blazor WebAssebly och använt PostgreSQL som databas.

Då det inte var focus på koden gjorde jag bara en simple Webapp som gör en lista med Spel, med 3 endpoints
- /games
- /genre
- /games/genre/{id:int}

Dock 5 st Api request där man kan Post and Get både Spel och Genre, samt få ut alla spel med en specefik genre via id.

### Docker
För att implementera docker till projektet var det bara att högerklicka på server-delen och add **Container Orchestor Support**.

Dem viktiga filerna som man fick var **Dockerfile** som log under server delen och **docker-compose** som kom i en egen folder.

### DB - PostgreSql
För att få tillgång till min databas använde jag NuGet Packages:
- Npgsql.EntityFrameworkCore.PostgreSQL
- EFCore.NamingConventions

Första är för att få tillgång till databasen den andra hjälper till med att formatera om stringar på namn för att inte få strul





1.	Beskriv docker
2.	Hur man testar
3.	Tekniska val :
