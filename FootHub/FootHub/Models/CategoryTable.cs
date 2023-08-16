using System;
using System.Collections.Generic;

namespace FootHub.Models;

public partial class CategoryTable
{
    public int CId { get; set; }

    public string CName { get; set; } = null!;

    public virtual ICollection<ProductLinkTable> ProductLinkTables { get; set; } = new List<ProductLinkTable>();
}
