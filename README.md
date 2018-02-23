# DotNet Core WebApi Breeze Example

git clone https://github.com/mikemichaelis/dnc
cd dnc
dotnet restore
cd model
dotnet ef database update -s ../webapi/webapi.csproj
cd ../webapi
dotnet run