## Info
### App model
- ASP.NET Core Web API  - Visual studio
- `dotnet new webapi` - VS code

### Tutorials 
- [Create a web API with ASP.NET Core Controllers](https://docs.microsoft.com/en-us/learn/modules/build-web-api-aspnet-core/)
- [Tutorials: Create a web API with controllers ](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio-code)
- [Persist and retrieve relational data with Entity Framework Core](https://docs.microsoft.com/en-us/learn/modules/persist-data-ef-core/)

## Tools used
- `httprepl`

## Enitity Framwork Core
- Command to generate a migration for creating the database tables and apply the migration:  
`dotnet ef migrations add InitialCreate --context PizzaContext`
`dotnet ef database update --context PizzaContext`



## Authorization 
- https://docs.microsoft.com/en-us/dotnet/architecture/microservices/secure-net-microservices-web-applications/
- https://docs.microsoft.com/en-us/aspnet/web-api/overview/security/
- https://auth0.com/blog/securing-aspnet-minimal-webapis-with-auth0/
- https://docs.microsoft.com/en-us/azure/active-directory/develop/scenario-protected-web-api-overview


## Issues

### ``httprepl` 
- There was a problem: `Unable to find an OpenAPI description`. Fixed by [configuring the ASP.NET Core HTTPS development centrificate.](https://docs.microsoft.com/en-us/aspnet/core/security/enforcing-ssl#trust-the-aspnet-core-https-development-certificate-on-windows-and-macos) 