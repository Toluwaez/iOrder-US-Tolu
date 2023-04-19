using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class CustomerContactDetail
{
    public int CustomerId { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
