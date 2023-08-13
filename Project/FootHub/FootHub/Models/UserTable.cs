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

    public virtual ICollection<OrderTable> OrderTables { get; set; } = new List<OrderTable>();
}
