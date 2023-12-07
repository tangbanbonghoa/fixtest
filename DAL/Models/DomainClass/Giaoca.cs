using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Giaoca
{
    public int Magiaoca { get; set; }

    public string? Tenca { get; set; }

    public TimeSpan? Thoigianbatdau { get; set; }

    public TimeSpan? Thoigianketthuc { get; set; }

    public virtual ICollection<Giaocanhanvien> Giaocanhanviens { get; set; } = new List<Giaocanhanvien>();
}
