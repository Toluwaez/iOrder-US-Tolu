using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class MenuItem
{
    public int MenuId { get; set; }

    public int ItemId { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual Menu Menu { get; set; } = null!;
}
