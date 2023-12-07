using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Kichco
{
    public int Makichco { get; set; }

    public string? Tenkichco { get; set; }

    public string? Mota { get; set; }

    public bool? Trangthai { get; set; }

    public int? Mataikhoan { get; set; }

    public virtual ICollection<Giaychitiet> Giaychitiets { get; set; } = new List<Giaychitiet>();

    public virtual Taikhoan? MataikhoanNavigation { get; set; }
}
