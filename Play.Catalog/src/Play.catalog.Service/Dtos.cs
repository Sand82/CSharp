using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Play.catalog.Service.Dtos
{
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreateDate);

    public record CreateItemDto([Required]string Name, string Description,[Range(0, 1000)] decimal Price);

    public record UpdateItemDto([Required]string Name, string Description,[Range(0, 1000)] decimal Price);
}