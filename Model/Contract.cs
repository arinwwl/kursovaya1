using System;
using System.Collections.Generic;

namespace KursSolodkaya.Model;

public partial class Contract
{
    public int ContractId { get; set; }

    public int? CustomerId { get; set; }

    public int? DealerId { get; set; }

    public int? ContractDate { get; set; }

    public int? CarMake { get; set; }

    public int? CarPhoto { get; set; }

    public int? ReleaseDate { get; set; }

    public int? Mileage { get; set; }

    public int? SaleDate { get; set; }

    public int? SalePrice { get; set; }

    public int? Commission { get; set; }

    public int? Notes { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Dealer? Dealer { get; set; }
}
