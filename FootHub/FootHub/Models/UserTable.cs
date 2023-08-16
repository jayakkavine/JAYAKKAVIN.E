using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FootHub.Models;

public partial class UserTable
{
    public int UId { get; set; }

    public string UName { get; set; } = null!;

    public string UEmail { get; set; } = null!;

    public string UPassword { get; set; } = null!;

    public string UPhone { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<OrderTable> OrderTables { get; set; } = new List<OrderTable>();
}
