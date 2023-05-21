using EFCoreDemo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// todo: Step 4: Configure your database connection at appsettings.json
var connstr = builder.Configuration.GetConnectionString("EFCoreDemo");

// DbContextFactory allows you to have better control over the lifetime and scope of the DbContext.
// It provides a way to create and dispose of the DbContext explicitly rather than relying on
// dependency injection to manage its lifetime.
builder.Services.AddDbContextFactory<EFCoreDemoDbContext>(options => options.UseSqlServer(connstr));

var app = builder.Build();

app.Run();

// todo: Step 5: Create the migration by running "add-migration initial".

// For Step 5 and 6, run the command at Package Manager Console for EFCoreDemo.Infrastructure project.

// Replace "initial" with a meaningful name for your migration. This command will generate a new migration
// file containing the necessary code to apply your model changes to the database.

/*
The EFCoreDemoDbContextModelSnapshot class is an auto - generated file created by Entity Framework Core 
when using the code-first approach with migrations. It represents a snapshot of the current state of your
database model at the time the migration was applied.

The EFCoreDemoDbContextModelSnapshot class is created in the Migrations folder alongside your migration files. 
It contains a snapshot of the model configuration and metadata for your DbContext and its entities.

The purpose of the EFCoreDemoDbContextModelSnapshot is to provide a point-in-time representation of your 
database model. It serves as a reference for Entity Framework Core to compare the current model state with 
the previous model state when applying migrations or generating the database schema.

When you generate a new migration using the dotnet ef migrations add command, Entity Framework Core compares 
the current state of the model with the previous snapshot stored in the EFCoreDemoDbContextModelSnapshot class. 
It generates a new migration file containing the necessary changes to bring the model from the previous 
snapshot to the current state.

During the execution of dotnet ef database update or dotnet ef migrations script, the 
EFCoreDemoDbContextModelSnapshot is used to determine the differences between the current model and the 
previous snapshot, and to generate the SQL statements necessary to apply those changes to the database.

In summary, the EFCoreDemoDbContextModelSnapshot class acts as a reference point for Entity Framework Core
to generate migrations and apply changes to the database schema based on the differences between the 
current model and the previous snapshot.
*/

// todo: Step 6: Apply the migration to the db by running "update-database".

/*
If you want to just script all the migrations you can simply run "script-migration.
For step 6, normally during development, I will use "update-database" option. When the development completed, 
I will use the "script-migration" and create a file for each changes make to the database.
*/