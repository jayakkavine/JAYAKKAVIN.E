using System;
using System.Collections.Generic;

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

    public virtual ICollection<ProductLinkTable> ProductLinkTables { get; set; } = new List<ProductLinkTable>();
}
