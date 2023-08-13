using System;
using System.Collections.Generic;

namespace FootHub.Models;

public partial class ProductLinkTable
{
    public int PId { get; set; }

    public int OId { get; set; }

    public int TId { get; set; }

    public int BId { get; set; }

    public int CId { get; set; }

    public virtual BrandTable BIdNavigation { get; set; } = null!;

    public virtual CategoryTable CIdNavigation { get; set; } = null!;

    public virtual OcassionTable OIdNavigation { get; set; } = null!;

    public virtual ProductTable PIdNavigation { get; set; } = null!;

    public virtual ProductType TIdNavigation { get; set; } = null!;
}
