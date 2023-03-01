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

-----
Scaffolding identity

install code generator
dotnet tool install -g dotnet-aspnet-codegenerator

Create a custom ApplicationUser class and ApplicationRole class that inherit from IdentityUser<Guid> and IdentityRole<Guid>. Update references to use this subclass instead of IdentityUser<Guid>. Scaffolding tools do not like using the <T> param.

https://learn.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-7.0&tabs=netcore-cli

add design package that holds the source razor files
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

scaffold out the files
this will create new files under /Areas/Identity/ for all the templates
you can also use --files "Account.Register;Account.Login" to scaffold out only the login and register page.
dotnet aspnet-codegenerator identity -dc ProjectRon.Data.ApplicationDbContext

Edit out the html in Areas/Identity/Account/Login.cshtml and Register.cshtml and the external login options will go away.

