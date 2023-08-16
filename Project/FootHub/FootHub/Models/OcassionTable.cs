using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FootHub.Models;

public partial class OcassionTable
{
    public int OId { get; set; }

    public string OName { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<ProductLinkTable> ProductLinkTables { get; set; } = new List<ProductLinkTable>();
}
