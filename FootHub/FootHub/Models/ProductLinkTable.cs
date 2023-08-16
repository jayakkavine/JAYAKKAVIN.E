using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FootHub.Models;

public partial class ProductLinkTable
{
    public int ProductLink { get; set; }

    public int PId { get; set; }

    public int OId { get; set; }

    public int TId { get; set; }

    public int BId { get; set; }

    public int CId { get; set; }

    [JsonIgnore]
    public virtual BrandTable BIdNavigation { get; set; } = null!;
    [JsonIgnore]
    public virtual CategoryTable CIdNavigation { get; set; } = null!;
    [JsonIgnore]
    public virtual OcassionTable OIdNavigation { get; set; } = null!;
    [JsonIgnore]
    public virtual ProductTable PIdNavigation { get; set; } = null!;
    [JsonIgnore]
    public virtual ProductType TIdNavigation { get; set; } = null!;
}
