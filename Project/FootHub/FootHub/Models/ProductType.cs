using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FootHub.Models;

public partial class ProductType
{
    public int TId { get; set; }

    public string TName { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<ProductLinkTable> ProductLinkTables { get; set; } = new List<ProductLinkTable>();
}
