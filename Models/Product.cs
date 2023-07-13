using System;
using System.Collections.Generic;

namespace CRUD.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Product1 { get; set; } = null!;

    public string Cost { get; set; } = null!;

    public string Items { get; set; } = null!;
}
