using System;
using System.Collections.Generic;

namespace ProductDBFirst.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public int ProductPrice { get; set; }

    public string? ProductDescription { get; set; }
}
