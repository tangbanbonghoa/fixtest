using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Giaychitiet
{
    public int Magiaychitiet { get; set; }

    public int? Magiay { get; set; }

    public int? Machatlieu { get; set; }

    public int? Mamausac { get; set; }

    public int? Makichco { get; set; }

    public int? Mathuonghieu { get; set; }

    public int? Makieudang { get; set; }

    public int? Soluongcon { get; set; }

    public DateTime? Ngaytao { get; set; }

    public DateTime? Ngaysua { get; set; }

    public int? Nguoitao { get; set; }

    public int? Nguoisua { get; set; }

    public double? Gia { get; set; }

    public string? Mota { get; set; }

    public bool? Trangthai { get; set; }

    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();

    public virtual Chatlieu? MachatlieuNavigation { get; set; }

    public virtual Giay? MagiayNavigation { get; set; }

    public virtual Kichco? MakichcoNavigation { get; set; }

    public virtual Kieudang? MakieudangNavigation { get; set; }

    public virtual Mausac? MamausacNavigation { get; set; }

    public virtual Thuonghieu? MathuonghieuNavigation { get; set; }

    public virtual Taikhoan? NguoisuaNavigation { get; set; }

    public virtual Taikhoan? NguoitaoNavigation { get; set; }
}
