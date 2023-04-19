using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class OrderItem
{
    public int OrderItemId { get; set; }

    public int ItemId { get; set; }

    public decimal Price { get; set; }

    public virtual Item Item { get; set; } = null!;
}
