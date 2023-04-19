using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class ItemCategory
{
    public int CategoryId { get; set; }

    public int ItemId { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;
}
