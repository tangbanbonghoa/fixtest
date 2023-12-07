using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Chucvu
{
    public int Machucvu { get; set; }

    public string? Tenchucvu { get; set; }

    public string? Motachucvu { get; set; }

    public virtual ICollection<Taikhoan> Taikhoans { get; set; } = new List<Taikhoan>();
}
