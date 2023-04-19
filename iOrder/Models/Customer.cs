using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime LastLogged { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
