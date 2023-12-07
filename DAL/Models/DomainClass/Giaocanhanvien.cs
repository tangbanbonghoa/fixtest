using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Giaocanhanvien
{
    public int Magiaocanhanvien { get; set; }

    public int? Mataikhoan { get; set; }

    public int? Magiaoca { get; set; }

    public DateTime? Ngaygiaoca { get; set; }

    public TimeSpan? Thoigianden { get; set; }

    public TimeSpan? Thoigianve { get; set; }

    public string? Sanphamdagiao { get; set; }

    public double? Tiendagiao { get; set; }

    public string? Ghichu { get; set; }

    public int? Trangthai { get; set; }

    public virtual Giaoca? MagiaocaNavigation { get; set; }

    public virtual Taikhoan? MataikhoanNavigation { get; set; }
}
