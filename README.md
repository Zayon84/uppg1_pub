# uppg1_pub
## Inlämningsuppgift 1 Publicering Molntjänster, David Almkvist

### Mål med Uppgiften
Utveckla och implementera en skalbar webbapplikation på Azure med
hjälp av Docker och Docker Compose. 

### Ramverk
För detta projekt valde jag att använda **.Net Core** med **Blazor WebAssebly** och använt **PostgreSQL** som databas.
**Github** används som versionskontroll och Deployat på **Azure DevOps**.

### Vad har jag gjort för project?

Då det inte var focus på koden gjorde jag bara en simple Webapp om spel som har två listor. En med Spel som man kan lägga till spel med id, namn och genre id, 
samt en lista med genre där man lägga till id med ny genre och genre via **3 endpoints**:

Då det inte var focus på koden gjorde jag bara en simple Webapp som har en lista med Spel som man kan lägga till spel med id, namn och genre id, samt en lista med genre där man lägga till ny genre med id och genre via **3 endpoints**:
- /games
- /genre
- /games/genre/{id:int}

Dock 5 st **Api request** där man kan **Post** and **Get** både Spel och Genre, samt få ut alla spel med en specefik genre via id.

Via Postman är alla Api calls testade och fungerar. 

### Docker
För att implementera **docker** till projektet var det bara att högerklicka på server-delen och add **Container Orchestor Support**.

Dem viktiga filerna som man fick var **Dockerfile** som log under server delen 

![cb0ce206-a881-40a7-8fc2-936cbf895cf3](https://github.com/Zayon84/uppg1_pub/assets/12381993/aefd38df-d6dc-46a4-af4c-4cc45b05ffd0)

och **docker-compose** som kom i en egen folder.

![d013eff1-36f8-46e7-b9e3-5d3ba21def06](https://github.com/Zayon84/uppg1_pub/assets/12381993/f245303b-7c80-4e62-b9d1-5b2f8e633464)

För att ladda upp image till **Docker Desktop** och skapa min Container använde jag **Package Manager Console** och använde kommandot:

>docker compose up -d

### DB - PostgreSql
För att få tillgång till min databas använde jag NuGet Packages:
- Npgsql.EntityFrameworkCore.PostgreSQL
- EFCore.NamingConventions

Första är för att få tillgång till databasen den andra hjälper till med att formatera om stringar på namn för att inte få strul

### Autoscalning
För att appen skall klara belastning så kör jag att webappen har custom autoscale, jag lagt på att vid över 70% Cpu användning ökar den och under 30 minskar den med 1 minimum och max 5.  

![image](https://github.com/Zayon84/uppg1_pub/assets/12381993/d62bdcdf-664b-4694-9ef4-c30e0023f415)







