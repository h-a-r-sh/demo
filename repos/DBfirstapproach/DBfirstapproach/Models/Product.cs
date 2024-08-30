using System;
using System.Collections.Generic;

namespace DBfirstapproach.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public int ProductPrice { get; set; }

    public string ProductDetails { get; set; } = null!;
}
