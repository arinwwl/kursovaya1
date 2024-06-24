using System;
using System.Collections.Generic;

namespace KursSolodkaya.Model;

public partial class Dealer
{
    public int DealerId { get; set; }

    public int LastName { get; set; }

    public int FirstName { get; set; }

    public int MiddleName { get; set; }

    public int Photo { get; set; }

    public int HomeAddres { get; set; }

    public int? PhoneNumber { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
