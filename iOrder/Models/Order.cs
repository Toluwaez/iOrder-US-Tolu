using System;
using System.Collections.Generic;

namespace iOrder.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int Total { get; set; }

    public int? ConfirmationCode { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
