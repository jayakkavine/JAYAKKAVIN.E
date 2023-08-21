using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FootHub.Models;

public partial class ProductTable
{
    public int PId { get; set; }

    public string PName { get; set; } = null!;

    public string PDisc { get; set; } = null!;

    public int Size { get; set; }

    public int Price { get; set; }

    public int TotalStock { get; set; }

    public string PImage { get; set; } = null!;

    public int OId { get; set; }

    public int TId { get; set; }

    public int BId { get; set; }

    public string CategoryName { get; set; } = null!;
    [JsonIgnore]
    public virtual BrandTable BIdNavigation { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<CartTable> CartTables { get; set; } = new List<CartTable>();
    [JsonIgnore]
    public virtual OcassionTable OIdNavigation { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<OrderLinkTable> OrderLinkTables { get; set; } = new List<OrderLinkTable>();
    [JsonIgnore]
    public virtual ProductType TIdNavigation { get; set; } = null!;
}
