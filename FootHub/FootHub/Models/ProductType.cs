using System;
using System.Collections.Generic;

namespace FootHub.Models;

public partial class ProductType
{
    public int TId { get; set; }

    public string TName { get; set; } = null!;

    public virtual ICollection<ProductLinkTable> ProductLinkTables { get; set; } = new List<ProductLinkTable>();
}
