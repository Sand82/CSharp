using System;

namespace Play.Cotalog.Contracts
{
    public record CatalogItemCreated(Guid ItemId, string Name, string Description);

    public record CatalogItemUpdated(Guid ItemId, string Name, string Description);

    public record CatalogItemDelited(Guid ItemId);
}