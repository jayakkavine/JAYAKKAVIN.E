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

    public string URole { get; set; } = null!;

    public int IsAvailable { get; set; }
    [JsonIgnore]
    public virtual ICollection<CartTable> CartTables { get; set; } = new List<CartTable>();
    [JsonIgnore]
    public virtual ICollection<OrderLinkTable> OrderLinkTables { get; set; } = new List<OrderLinkTable>();
    [JsonIgnore]
    public virtual ICollection<OrderTable> OrderTables { get; set; } = new List<OrderTable>();
}
