using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FootHub.Models;

public partial class BrandTable
{
    public int BId { get; set; }

    public string BName { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<ProductLinkTable> ProductLinkTables { get; set; } = new List<ProductLinkTable>();
}
