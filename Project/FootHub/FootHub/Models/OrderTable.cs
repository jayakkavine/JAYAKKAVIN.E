using System;
using System.Collections.Generic;

namespace FootHub.Models;

public partial class OrderTable
{
    public int OrderId { get; set; }

    public int UId { get; set; }

    public string UName { get; set; } = null!;

    public string UAddress { get; set; } = null!;

    public int Price { get; set; }

    public string OrderDate { get; set; } = null!;

    public virtual UserTable UIdNavigation { get; set; } = null!;
}
