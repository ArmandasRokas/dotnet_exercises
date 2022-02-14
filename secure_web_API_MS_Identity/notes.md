## App model
- `ASP.NET Core Web API` with Auth type Microsft Identity Platform  - Visual studio
- `dotnet new webapi -o ProductCatalog -au singleorg` - VS code

## Tutorial:
- [Secure custom APIs with Microsoft Identity](https://docs.microsoft.com/en-us/learn/modules/identity-secure-custom-api/)
- [Screencast](https://www.youtube.com/watch?v=gXb6t3gjnOA)



## Notes
- This example will use an Azure AD application to authenticate calls made to the application using a token provided in the Authentication header of the Http request.
- While the **scaffolded middleware will validate the token**, authorizing a request for a specific controller action is the responsibility of the developer
- The presence of scopes in the token is used to authorize the action. If the scope is present, the action is allowed. Validating scopes will be done in the action methods of the controllers 



## Questions
- How should I start from skratch? That's now I used DTU login for it. But if the orginazation should be started from 0. 


## Azure ADD
- [Product Catalog API in ADD: Client ID and tentant ID](https://aad.portal.azure.com/#blade/Microsoft_AAD_RegisteredApps/ApplicationMenuBlade/Overview/quickStartType//sourceType/Microsoft_AAD_IAM/appId/cd57c94f-4332-4b49-9400-25bf0eb25e1c/objectId/8c1cec41-23ee-4508-9505-e51418c59fb0/isMSAApp//defaultBlade/Overview/appSignInAudience/AzureADMyOrg/servicePrincipalCreated/true)
- [Edit scope](https://aad.portal.azure.com/#blade/Microsoft_AAD_RegisteredApps/ApplicationMenuBlade/ProtectAnAPI/quickStartType//sourceType/Microsoft_AAD_IAM/appId/cd57c94f-4332-4b49-9400-25bf0eb25e1c/objectId/8c1cec41-23ee-4508-9505-e51418c59fb0/isMSAApp//defaultBlade/Overview/appSignInAudience/AzureADMyOrg/servicePrincipalCreated/true)






## Material 
- [Azure Active Directory fundamentals documentation](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/)
- [Overview of ASP.NET Core Security](https://docs.microsoft.com/en-us/aspnet/core/security/?view=aspnetcore-6.0)
- [Make secure .NET Microservices and Web Applications](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/secure-net-microservices-web-applications/)
- [Security, Authentication, and Authorization in ASP.NET Web API](https://docs.microsoft.com/en-us/aspnet/web-api/overview/security/)
- [Securing ASP.NET minimal webapi with auth0. NOT MIRCOSOFT](https://auth0.com/blog/securing-aspnet-minimal-webapis-with-auth0/)
- [Scenario: Protected web API](https://docs.microsoft.com/en-us/azure/active-directory/develop/scenario-protected-web-api-overview)
- [Udemy: The Nuts and Bolts of OAuth 2.0](https://www.udemy.com/course/oauth-2-simplified/?referralCode=B04F59AED67B8DA74FA7)
- [Stackoverflow: How to secure an ASP.NET Web API](https://stackoverflow.com/questions/11775594/how-to-secure-an-asp-net-web-api)

### To secure web APIs and SPAs, use one of the following:
- [Azure Active Directory](https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-protect-backend-with-aad)
- [Azure Active Directory B2C (Azure AD B2C)](https://docs.microsoft.com/en-us/azure/active-directory-b2c/active-directory-b2c-custom-rest-api-netfw)
- [IdentityServer4](https://identityserver.io/)
