using System;

namespace Play.catalog.Service.Dtos
{
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreateDate);

    public record CreateItemDto(string Name, string Description, decimal Price);

    public record UpdateItemDto(string Name, string Description, decimal Price);
}