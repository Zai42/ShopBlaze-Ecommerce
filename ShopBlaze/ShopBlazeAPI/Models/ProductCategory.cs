using System;
using System.Collections.Generic;

namespace ShopBlazeAPI.Models;

public partial class ProductCategory
{
    public int? ProductId { get; set; }

    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public virtual Product? Product { get; set; }
}
