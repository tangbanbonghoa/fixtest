using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Bangluong
{
    public int Maluong { get; set; }

    public int? Thanglam { get; set; }

    public double? Luongcoban { get; set; }

    public double? Tienthuong { get; set; }

    public double? Tienkhautru { get; set; }

    public double? Tongthunhap { get; set; }

    public int? Mataikhoan { get; set; }

    public virtual Taikhoan? MataikhoanNavigation { get; set; }
}
