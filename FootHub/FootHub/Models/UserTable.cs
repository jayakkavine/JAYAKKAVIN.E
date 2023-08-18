using System;
using System.Collections.Generic;

namespace FootHub.Models;

public partial class UserTable
{
    public int UId { get; set; }

    public string UName { get; set; } = null!;

    public string UEmail { get; set; } = null!;

    public string UPassword { get; set; } = null!;

    public string UPhone { get; set; } = null!;

    public string URole { get; set; } = null!;

    public int IsAvailable { get; set; }

    public virtual ICollection<CartTable> CartTables { get; set; } = new List<CartTable>();

    public virtual ICollection<OrderLinkTable> OrderLinkTables { get; set; } = new List<OrderLinkTable>();

    public virtual ICollection<OrderTable> OrderTables { get; set; } = new List<OrderTable>();
}
