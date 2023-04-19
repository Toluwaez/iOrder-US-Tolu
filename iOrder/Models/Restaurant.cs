using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class Restaurant
{
    public int RestaurantId { get; set; }

    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string Schedule { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<Menu> Menus { get; } = new List<Menu>();
}
