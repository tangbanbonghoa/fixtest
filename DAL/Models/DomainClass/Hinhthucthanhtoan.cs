using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Hinhthucthanhtoan
{
    public int Mahinhthucthanhtoan { get; set; }

    public string? Tenhinhthuc { get; set; }

    public string? Mota { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
