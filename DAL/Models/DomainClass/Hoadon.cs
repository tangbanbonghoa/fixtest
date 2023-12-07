using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Hoadon
{
    public int Mahoadon { get; set; }

    public int? Mataikhoan { get; set; }

    public int? Mauudai { get; set; }

    public int? Makhachhang { get; set; }

    public int? Mahinhthucthanhtoan { get; set; }

    public string? Tencuahang { get; set; }

    public string? Diachicuahang { get; set; }

    public string? Sdtcuahang { get; set; }

    public string? Emailcuahang { get; set; }

    public DateTime? Ngaytao { get; set; }

    public double? Tongtien { get; set; }

    public bool? Trangthai { get; set; }

    public string? Ghichu { get; set; }

    public virtual ICollection<Hoadonchitiet> Hoadonchitiets { get; set; } = new List<Hoadonchitiet>();

    public virtual Hinhthucthanhtoan? MahinhthucthanhtoanNavigation { get; set; }

    public virtual Khachhang? MakhachhangNavigation { get; set; }

    public virtual Taikhoan? MataikhoanNavigation { get; set; }

    public virtual Uudai? MauudaiNavigation { get; set; }
}
