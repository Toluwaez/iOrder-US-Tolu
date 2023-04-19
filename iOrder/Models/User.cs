using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = string.Empty;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime LastLogged { get; set; }

    public int Role { get; set; }
}
