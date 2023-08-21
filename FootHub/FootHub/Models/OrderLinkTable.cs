using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FootHub.Models;

public partial class OrderLinkTable
{
    public int OrderLink { get; set; }

    public int OrderId { get; set; }

    public int UId { get; set; }

    public int PId { get; set; }

    public int Quantity { get; set; }
    [JsonIgnore]
    public virtual OrderTable Order { get; set; } = null!;
    [JsonIgnore]
    public virtual ProductTable PIdNavigation { get; set; } = null!;
    [JsonIgnore]
    public virtual UserTable UIdNavigation { get; set; } = null!;
}
