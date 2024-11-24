using System;
using System.Collections.Generic;

namespace EF_001_ReverseEngineering.Entity;

public partial class Speaker
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
