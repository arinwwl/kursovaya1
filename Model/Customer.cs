using System;
using System.Collections.Generic;

namespace KursSolodkaya.Model;

public partial class Customer
{
    public int CustomerId { get; set; }

    public int LastName { get; set; }

    public int FirstName { get; set; }

    public int MiddleName { get; set; }

    public int City { get; set; }

    public int Address { get; set; }

    public int PhoneNumber { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
