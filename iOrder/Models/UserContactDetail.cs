using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class UserContactDetail
{
    public int UserId { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public virtual User User { get; set; } = null!;
}
