using System;
using System.Collections.Generic;

namespace FootHub.Models;

public partial class OcassionTable
{
    public int OId { get; set; }

    public string OName { get; set; } = null!;

    public virtual ICollection<ProductLinkTable> ProductLinkTables { get; set; } = new List<ProductLinkTable>();
}
