using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Khachhang
{
    public int Makhachhang { get; set; }

    public string? Tenkhachhang { get; set; }

    public string? Sdt { get; set; }

    public int? Diemkhachhang { get; set; }

    public bool? Trangthai { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
