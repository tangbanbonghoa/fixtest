using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Hoadonchitiet
{
    public int Mahoadonchitiet { get; set; }

    public int? Magiaychitiet { get; set; }

    public int? Mahoadon { get; set; }

    public int? Soluongmua { get; set; }

    public double? Gia { get; set; }

    public virtual Giaychitiet? MagiaychitietNavigation { get; set; }

    public virtual Hoadon? MahoadonNavigation { get; set; }
}
