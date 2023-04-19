using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string? Image { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public bool Available { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; } = new List<OrderItem>();
}
