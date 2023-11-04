param(
     [Parameter()]
     [string]$Environment,

     [Parameter()]
     [string]$Database,

     [Parameter()]
     [string]$Name

 )

if($Environment -eq "Development")
{
    $env:ASPNETCORE_ENVIRONMENT="Development"
}

if($Environment -eq "Staging")
{
    $env:ASPNETCORE_ENVIRONMENT="Staging"
}

if($Database -eq "Sqlite")
{
    dotnet ef migrations add $Name --context AppDbContextSqlite --project ../src/Cifralite.Web --output-dir Core/Data/Migrations/Sqlite
}

if($Database -eq "SqlServer")
{
    dotnet ef migrations add $Name --context AppDbContext --project ../src/Cifralite.Web --output-dir Core/Data/Migrations/SqlServer
}