using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public int OrderItemId { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual OrderItem OrderItem { get; set; } = null!;
}
