# DotNet Core WebApi Breeze Example

* git clone https://github.com/mikemichaelis/dnc
* cd dnc
* dotnet restore
* cd model
* dotnet ef database update -s ../webapi/webapi.csproj
* cd ../webapi
* dotnet run

* http://localhost:5000/api/Values
* http://localhost:5000/breeze/Employee/Get