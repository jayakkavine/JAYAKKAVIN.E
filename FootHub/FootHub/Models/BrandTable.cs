using System;
using System.Collections.Generic;

namespace FootHub.Models;

public partial class BrandTable
{
    public int BId { get; set; }

    public string BName { get; set; } = null!;

    public virtual ICollection<ProductLinkTable> ProductLinkTables { get; set; } = new List<ProductLinkTable>();
}
