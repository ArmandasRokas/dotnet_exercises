using System.Collections.Generic;

namespace Constants
{
    public static class ProductCatalogAPI
    {
        public const string CategoryUrl = "https://localhost:7048/api/Categories";
        public const string ProductUrl = "https://localhost:7048/api/Product";
        public const string ProductReadScope = "api://cd57c94f-4332-4b49-9400-25bf0eb25e1c/Product.Read";
        public const string ProductWriteScope = "api://cd57c94f-4332-4b49-9400-25bf0eb25e1c/Product.Write";
        public const string CategoryReadScope = "api://cd57c94f-4332-4b49-9400-25bf0eb25e1c/Category.Read";
        public const string CategoryWriteScope = "api://cd57c94f-4332-4b49-9400-25bf0eb25e1c/Category.Write";

        public static List<string> SCOPES = new List<string>()
    {
      ProductReadScope, ProductWriteScope, CategoryReadScope, CategoryWriteScope
    };
    }

    public static class ClaimIds
    {
        public const string UserObjectId = "http://schemas.microsoft.com/identity/claims/objectidentifier";
        public const string TenantId = "http://schemas.microsoft.com/identity/claims/tenantid";
    }
}