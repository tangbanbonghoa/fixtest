using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Giay
{
    public int Magiay { get; set; }

    public string? Tengiay { get; set; }

    public virtual ICollection<Giaychitiet> Giaychitiets { get; set; } = new List<Giaychitiet>();
}
