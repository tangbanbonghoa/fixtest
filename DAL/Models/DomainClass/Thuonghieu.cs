using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Thuonghieu
{
    public int Mathuonghieu { get; set; }

    public string? Tenthuonghieu { get; set; }

    public string? Email { get; set; }

    public string? Sdt { get; set; }

    public bool? Trangthai { get; set; }

    public string? Mota { get; set; }

    public int? Mataikhoan { get; set; }

    public virtual ICollection<Giaychitiet> Giaychitiets { get; set; } = new List<Giaychitiet>();

    public virtual Taikhoan? MataikhoanNavigation { get; set; }
}
