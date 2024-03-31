using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Play.catalog.Service.Dtos;

namespace Play.catalog.Service.Controllers
{

    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private static readonly List<ItemDto> items = new()
        {
            new ItemDto(Guid.NewGuid(), "Potion", "Restore small amount HP", 5, DateTimeOffset.UtcNow),
            new ItemDto(Guid.NewGuid(), "Anti Dote", "Cures poison", 7, DateTimeOffset.UtcNow),
            new ItemDto(Guid.NewGuid(), "Bronze sword", "Deals small amount of damage", 20, DateTimeOffset.UtcNow),
        };

        [HttpGet]
        public IEnumerable<ItemDto> Get()
        {
            return items;
        }

        [HttpGet("{id}")]
        public ItemDto GetById(Guid id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }
    }
}