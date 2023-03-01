# Test asp.net project

add connection string to appsettings.json
run ef database update 

dotnet tool install --global dotnet-ef # install ef tools
dotnet ef database update -v # run the db migrations against db (will create tables/views)

dotnet ef migrations add MIGRATIONAME # will create a new migration file for db updates

New migrations will be created in the Migrations folder.

dotnet ef migrations remove will remove any unapplied migrations

See modeling docs for how to construct db changes/additions
https://learn.microsoft.com/en-us/ef/core/modeling/
