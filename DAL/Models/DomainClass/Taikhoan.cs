﻿using System;
using System.Collections.Generic;

namespace DAL.Models.DomainClass;

public partial class Taikhoan
{
    public int Mataikhoan { get; set; }

    public string? Username { get; set; }

    public string? Pasword { get; set; }

    public string? Hovaten { get; set; }

    public bool? Gioitinh { get; set; }

    public string? Sodienthoai { get; set; }

    public string? Diachi { get; set; }

    public string? Email { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public DateTime? Ngaytaotaikhoan { get; set; }

    public int Machucvu { get; set; }

    public bool? Trangthai { get; set; }

    public virtual ICollection<Bangluong> Bangluongs { get; set; } = new List<Bangluong>();

    public virtual ICollection<Chatlieu> Chatlieus { get; set; } = new List<Chatlieu>();

    public virtual ICollection<Giaocanhanvien> Giaocanhanviens { get; set; } = new List<Giaocanhanvien>();

    public virtual ICollection<Giaychitiet> GiaychitietNguoisuaNavigations { get; set; } = new List<Giaychitiet>();

    public virtual ICollection<Giaychitiet> GiaychitietNguoitaoNavigations { get; set; } = new List<Giaychitiet>();

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<Kichco> Kichcos { get; set; } = new List<Kichco>();

    public virtual ICollection<Kieudang> Kieudangs { get; set; } = new List<Kieudang>();

    public virtual Chucvu MachucvuNavigation { get; set; } = null!;

    public virtual ICollection<Mausac> Mausacs { get; set; } = new List<Mausac>();

    public virtual ICollection<Thuonghieu> Thuonghieus { get; set; } = new List<Thuonghieu>();

    public virtual ICollection<Uudai> Uudais { get; set; } = new List<Uudai>();
}
