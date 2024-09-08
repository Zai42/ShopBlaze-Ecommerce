using System;
using System.Collections.Generic;

namespace ShopBlazeAPI.Models;

public partial class ProductImage
{
    public int? ProductId { get; set; }

    public int Id { get; set; }

    public byte[]? Images { get; set; }

    public string ImageName { get; set; }

    public virtual Product? Product { get; set; }

}
