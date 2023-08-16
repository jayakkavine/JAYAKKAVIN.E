using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FootHub.Models;

public partial class CategoryTable
{
    public int CId { get; set; }

    public string CName { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<ProductLinkTable> ProductLinkTables { get; set; } = new List<ProductLinkTable>();
}
