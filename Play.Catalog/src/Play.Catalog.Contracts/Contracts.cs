using System;

namespace Play.catalog.Contracts
{
    public record CatalogItemCreated(Guid Id, string Name, string Description);
}