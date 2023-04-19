using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public int RestaurantId { get; set; }

    public string Name { get; set; } = null!;

    public virtual Restaurant Restaurant { get; set; } = null!;
}
