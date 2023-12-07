using System;
using System.Collections.Generic;
using DAL.Models.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bangluong> Bangluongs { get; set; }

    public virtual DbSet<Chatlieu> Chatlieus { get; set; }

    public virtual DbSet<Chucvu> Chucvus { get; set; }

    public virtual DbSet<Giaoca> Giaocas { get; set; }

    public virtual DbSet<Giaocanhanvien> Giaocanhanviens { get; set; }

    public virtual DbSet<Giay> Giays { get; set; }

    public virtual DbSet<Giaychitiet> Giaychitiets { get; set; }

    public virtual DbSet<Hinhthucthanhtoan> Hinhthucthanhtoans { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Hoadonchitiet> Hoadonchitiets { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Kichco> Kichcos { get; set; }

    public virtual DbSet<Kieudang> Kieudangs { get; set; }

    public virtual DbSet<Mausac> Mausacs { get; set; }

    public virtual DbSet<Taikhoan> Taikhoans { get; set; }

    public virtual DbSet<Thuonghieu> Thuonghieus { get; set; }

    public virtual DbSet<Uudai> Uudais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-MN98SD2\\SQLEXPRESS;Initial Catalog=DBGIAY_DUAN1;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bangluong>(entity =>
        {
            entity.HasKey(e => e.Maluong).HasName("PK__BANGLUON__D9BA4D001D89CDA4");

            entity.ToTable("BANGLUONG");

            entity.Property(e => e.Maluong).HasColumnName("MALUONG");
            entity.Property(e => e.Luongcoban).HasColumnName("LUONGCOBAN");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Thanglam).HasColumnName("THANGLAM");
            entity.Property(e => e.Tienkhautru).HasColumnName("TIENKHAUTRU");
            entity.Property(e => e.Tienthuong).HasColumnName("TIENTHUONG");
            entity.Property(e => e.Tongthunhap).HasColumnName("TONGTHUNHAP");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Bangluongs)
                .HasForeignKey(d => d.Mataikhoan)
                .HasConstraintName("FK__BANGLUONG__MATAI__4316F928");
        });

        modelBuilder.Entity<Chatlieu>(entity =>
        {
            entity.HasKey(e => e.Machatlieu).HasName("PK__CHATLIEU__80F939F8D3C72BCB");

            entity.ToTable("CHATLIEU");

            entity.Property(e => e.Machatlieu).HasColumnName("MACHATLIEU");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mota)
                .HasMaxLength(200)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenchatlieu)
                .HasMaxLength(50)
                .HasColumnName("TENCHATLIEU");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Chatlieus)
                .HasForeignKey(d => d.Mataikhoan)
                .HasConstraintName("FK__CHATLIEU__MATAIK__440B1D61");
        });

        modelBuilder.Entity<Chucvu>(entity =>
        {
            entity.HasKey(e => e.Machucvu).HasName("PK__CHUCVU__9FA9FD6AA31A108C");

            entity.ToTable("CHUCVU");

            entity.Property(e => e.Machucvu).HasColumnName("MACHUCVU");
            entity.Property(e => e.Motachucvu)
                .HasMaxLength(200)
                .HasColumnName("MOTACHUCVU");
            entity.Property(e => e.Tenchucvu)
                .HasMaxLength(50)
                .HasColumnName("TENCHUCVU");
        });

        modelBuilder.Entity<Giaoca>(entity =>
        {
            entity.HasKey(e => e.Magiaoca).HasName("PK__GIAOCA__7D3545CC9543B3A5");

            entity.ToTable("GIAOCA");

            entity.Property(e => e.Magiaoca).HasColumnName("MAGIAOCA");
            entity.Property(e => e.Tenca)
                .HasMaxLength(50)
                .HasColumnName("TENCA");
            entity.Property(e => e.Thoigianbatdau).HasColumnName("THOIGIANBATDAU");
            entity.Property(e => e.Thoigianketthuc).HasColumnName("THOIGIANKETTHUC");
        });

        modelBuilder.Entity<Giaocanhanvien>(entity =>
        {
            entity.HasKey(e => e.Magiaocanhanvien).HasName("PK__GIAOCANH__B0F1BCFD94F1A411");

            entity.ToTable("GIAOCANHANVIEN");

            entity.Property(e => e.Magiaocanhanvien).HasColumnName("MAGIAOCANHANVIEN");
            entity.Property(e => e.Ghichu)
                .HasMaxLength(300)
                .HasColumnName("GHICHU");
            entity.Property(e => e.Magiaoca).HasColumnName("MAGIAOCA");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Ngaygiaoca)
                .HasColumnType("date")
                .HasColumnName("NGAYGIAOCA");
            entity.Property(e => e.Sanphamdagiao)
                .HasMaxLength(100)
                .HasColumnName("SANPHAMDAGIAO");
            entity.Property(e => e.Thoigianden).HasColumnName("THOIGIANDEN");
            entity.Property(e => e.Thoigianve).HasColumnName("THOIGIANVE");
            entity.Property(e => e.Tiendagiao).HasColumnName("TIENDAGIAO");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MagiaocaNavigation).WithMany(p => p.Giaocanhanviens)
                .HasForeignKey(d => d.Magiaoca)
                .HasConstraintName("FK__GIAOCANHA__MAGIA__44FF419A");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Giaocanhanviens)
                .HasForeignKey(d => d.Mataikhoan)
                .HasConstraintName("FK__GIAOCANHA__MATAI__45F365D3");
        });

        modelBuilder.Entity<Giay>(entity =>
        {
            entity.HasKey(e => e.Magiay).HasName("PK__GIAY__0C880C5853E963CC");

            entity.ToTable("GIAY");

            entity.Property(e => e.Magiay).HasColumnName("MAGIAY");
            entity.Property(e => e.Tengiay)
                .HasMaxLength(50)
                .HasColumnName("TENGIAY");
        });

        modelBuilder.Entity<Giaychitiet>(entity =>
        {
            entity.HasKey(e => e.Magiaychitiet).HasName("PK__GIAYCHIT__196AD703EA4D0B43");

            entity.ToTable("GIAYCHITIET");

            entity.Property(e => e.Magiaychitiet).HasColumnName("MAGIAYCHITIET");
            entity.Property(e => e.Gia).HasColumnName("GIA");
            entity.Property(e => e.Machatlieu).HasColumnName("MACHATLIEU");
            entity.Property(e => e.Magiay).HasColumnName("MAGIAY");
            entity.Property(e => e.Makichco).HasColumnName("MAKICHCO");
            entity.Property(e => e.Makieudang).HasColumnName("MAKIEUDANG");
            entity.Property(e => e.Mamausac).HasColumnName("MAMAUSAC");
            entity.Property(e => e.Mathuonghieu).HasColumnName("MATHUONGHIEU");
            entity.Property(e => e.Mota)
                .HasMaxLength(300)
                .HasColumnName("MOTA");
            entity.Property(e => e.Ngaysua)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSUA");
            entity.Property(e => e.Ngaytao)
                .HasColumnType("datetime")
                .HasColumnName("NGAYTAO");
            entity.Property(e => e.Nguoisua).HasColumnName("NGUOISUA");
            entity.Property(e => e.Nguoitao).HasColumnName("NGUOITAO");
            entity.Property(e => e.Soluongcon).HasColumnName("SOLUONGCON");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MachatlieuNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Machatlieu)
                .HasConstraintName("FK__GIAYCHITI__MACHA__46E78A0C");

            entity.HasOne(d => d.MagiayNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Magiay)
                .HasConstraintName("FK__GIAYCHITI__MAGIA__47DBAE45");

            entity.HasOne(d => d.MakichcoNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Makichco)
                .HasConstraintName("FK__GIAYCHITI__MAKIC__48CFD27E");

            entity.HasOne(d => d.MakieudangNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Makieudang)
                .HasConstraintName("FK__GIAYCHITI__MAKIE__49C3F6B7");

            entity.HasOne(d => d.MamausacNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Mamausac)
                .HasConstraintName("FK__GIAYCHITI__MAMAU__4AB81AF0");

            entity.HasOne(d => d.MathuonghieuNavigation).WithMany(p => p.Giaychitiets)
                .HasForeignKey(d => d.Mathuonghieu)
                .HasConstraintName("FK__GIAYCHITI__MATHU__4BAC3F29");

            entity.HasOne(d => d.NguoisuaNavigation).WithMany(p => p.GiaychitietNguoisuaNavigations)
                .HasForeignKey(d => d.Nguoisua)
                .HasConstraintName("FK__GIAYCHITI__NGUOI__4D94879B");

            entity.HasOne(d => d.NguoitaoNavigation).WithMany(p => p.GiaychitietNguoitaoNavigations)
                .HasForeignKey(d => d.Nguoitao)
                .HasConstraintName("FK__GIAYCHITI__NGUOI__4CA06362");
        });

        modelBuilder.Entity<Hinhthucthanhtoan>(entity =>
        {
            entity.HasKey(e => e.Mahinhthucthanhtoan).HasName("PK__HINHTHUC__C3B2561F421A573D");

            entity.ToTable("HINHTHUCTHANHTOAN");

            entity.Property(e => e.Mahinhthucthanhtoan).HasColumnName("MAHINHTHUCTHANHTOAN");
            entity.Property(e => e.Mota)
                .HasMaxLength(200)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenhinhthuc)
                .HasMaxLength(50)
                .HasColumnName("TENHINHTHUC");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Mahoadon).HasName("PK__HOADON__A4999DF51F916E4C");

            entity.ToTable("HOADON");

            entity.Property(e => e.Mahoadon).HasColumnName("MAHOADON");
            entity.Property(e => e.Diachicuahang)
                .HasMaxLength(200)
                .HasColumnName("DIACHICUAHANG");
            entity.Property(e => e.Emailcuahang)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAILCUAHANG");
            entity.Property(e => e.Ghichu)
                .HasMaxLength(200)
                .HasColumnName("GHICHU");
            entity.Property(e => e.Mahinhthucthanhtoan).HasColumnName("MAHINHTHUCTHANHTOAN");
            entity.Property(e => e.Makhachhang).HasColumnName("MAKHACHHANG");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mauudai).HasColumnName("MAUUDAI");
            entity.Property(e => e.Ngaytao)
                .HasColumnType("datetime")
                .HasColumnName("NGAYTAO");
            entity.Property(e => e.Sdtcuahang)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDTCUAHANG");
            entity.Property(e => e.Tencuahang)
                .HasMaxLength(100)
                .HasColumnName("TENCUAHANG");
            entity.Property(e => e.Tongtien).HasColumnName("TONGTIEN");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MahinhthucthanhtoanNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Mahinhthucthanhtoan)
                .HasConstraintName("FK__HOADON__MAHINHTH__4E88ABD4");

            entity.HasOne(d => d.MakhachhangNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Makhachhang)
                .HasConstraintName("FK__HOADON__MAKHACHH__4F7CD00D");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Mataikhoan)
                .HasConstraintName("FK__HOADON__MATAIKHO__5070F446");

            entity.HasOne(d => d.MauudaiNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Mauudai)
                .HasConstraintName("FK__HOADON__MAUUDAI__5165187F");
        });

        modelBuilder.Entity<Hoadonchitiet>(entity =>
        {
            entity.HasKey(e => e.Mahoadonchitiet).HasName("PK__HOADONCH__EF957FF0A4AD0CD8");

            entity.ToTable("HOADONCHITIET");

            entity.Property(e => e.Mahoadonchitiet).HasColumnName("MAHOADONCHITIET");
            entity.Property(e => e.Gia).HasColumnName("GIA");
            entity.Property(e => e.Magiaychitiet).HasColumnName("MAGIAYCHITIET");
            entity.Property(e => e.Mahoadon).HasColumnName("MAHOADON");
            entity.Property(e => e.Soluongmua).HasColumnName("SOLUONGMUA");

            entity.HasOne(d => d.MagiaychitietNavigation).WithMany(p => p.Hoadonchitiets)
                .HasForeignKey(d => d.Magiaychitiet)
                .HasConstraintName("FK__HOADONCHI__MAGIA__52593CB8");

            entity.HasOne(d => d.MahoadonNavigation).WithMany(p => p.Hoadonchitiets)
                .HasForeignKey(d => d.Mahoadon)
                .HasConstraintName("FK__HOADONCHI__MAHOA__534D60F1");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makhachhang).HasName("PK__KHACHHAN__30035C2FD31F3A75");

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.Makhachhang).HasColumnName("MAKHACHHANG");
            entity.Property(e => e.Diemkhachhang).HasColumnName("DIEMKHACHHANG");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Tenkhachhang)
                .HasMaxLength(50)
                .HasColumnName("TENKHACHHANG");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
        });

        modelBuilder.Entity<Kichco>(entity =>
        {
            entity.HasKey(e => e.Makichco).HasName("PK__KICHCO__7EDFFF2948A582C1");

            entity.ToTable("KICHCO");

            entity.Property(e => e.Makichco).HasColumnName("MAKICHCO");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mota)
                .HasMaxLength(200)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenkichco)
                .HasMaxLength(50)
                .HasColumnName("TENKICHCO");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Kichcos)
                .HasForeignKey(d => d.Mataikhoan)
                .HasConstraintName("FK__KICHCO__MATAIKHO__5441852A");
        });

        modelBuilder.Entity<Kieudang>(entity =>
        {
            entity.HasKey(e => e.Makieudang).HasName("PK__KIEUDANG__877F27F2E5A10889");

            entity.ToTable("KIEUDANG");

            entity.Property(e => e.Makieudang).HasColumnName("MAKIEUDANG");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mota)
                .HasMaxLength(200)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenkieudang)
                .HasMaxLength(50)
                .HasColumnName("TENKIEUDANG");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Kieudangs)
                .HasForeignKey(d => d.Mataikhoan)
                .HasConstraintName("FK__KIEUDANG__MATAIK__5535A963");
        });

        modelBuilder.Entity<Mausac>(entity =>
        {
            entity.HasKey(e => e.Mamausac).HasName("PK__MAUSAC__99E7A68F2B32AA3A");

            entity.ToTable("MAUSAC");

            entity.Property(e => e.Mamausac).HasColumnName("MAMAUSAC");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mota)
                .HasMaxLength(200)
                .HasColumnName("MOTA");
            entity.Property(e => e.Tenmausac)
                .HasMaxLength(50)
                .HasColumnName("TENMAUSAC");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Mausacs)
                .HasForeignKey(d => d.Mataikhoan)
                .HasConstraintName("FK__MAUSAC__MATAIKHO__5629CD9C");
        });

        modelBuilder.Entity<Taikhoan>(entity =>
        {
            entity.HasKey(e => e.Mataikhoan).HasName("PK__TAIKHOAN__2ED8B5173A662DAE");

            entity.ToTable("TAIKHOAN");

            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Diachi)
                .HasMaxLength(200)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Gioitinh).HasColumnName("GIOITINH");
            entity.Property(e => e.Hovaten)
                .HasMaxLength(50)
                .HasColumnName("HOVATEN");
            entity.Property(e => e.Machucvu).HasColumnName("MACHUCVU");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("date")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Ngaytaotaikhoan)
                .HasColumnType("date")
                .HasColumnName("NGAYTAOTAIKHOAN");
            entity.Property(e => e.Pasword)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PASWORD");
            entity.Property(e => e.Sodienthoai)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SODIENTHOAI");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("USERNAME");

            entity.HasOne(d => d.MachucvuNavigation).WithMany(p => p.Taikhoans)
                .HasForeignKey(d => d.Machucvu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TAIKHOAN__MACHUC__571DF1D5");
        });

        modelBuilder.Entity<Thuonghieu>(entity =>
        {
            entity.HasKey(e => e.Mathuonghieu).HasName("PK__THUONGHI__B319F638AC3E873B");

            entity.ToTable("THUONGHIEU");

            entity.Property(e => e.Mathuonghieu).HasColumnName("MATHUONGHIEU");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Mota)
                .HasMaxLength(200)
                .HasColumnName("MOTA");
            entity.Property(e => e.Sdt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Tenthuonghieu)
                .HasMaxLength(50)
                .HasColumnName("TENTHUONGHIEU");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Thuonghieus)
                .HasForeignKey(d => d.Mataikhoan)
                .HasConstraintName("FK__THUONGHIE__MATAI__5812160E");
        });

        modelBuilder.Entity<Uudai>(entity =>
        {
            entity.HasKey(e => e.Mauudai).HasName("PK__UUDAI__3F58B4FD3F8F9BAE");

            entity.ToTable("UUDAI");

            entity.Property(e => e.Mauudai).HasColumnName("MAUUDAI");
            entity.Property(e => e.Mataikhoan).HasColumnName("MATAIKHOAN");
            entity.Property(e => e.Ngaybatdau)
                .HasColumnType("datetime")
                .HasColumnName("NGAYBATDAU");
            entity.Property(e => e.Ngayketthuc)
                .HasColumnType("datetime")
                .HasColumnName("NGAYKETTHUC");
            entity.Property(e => e.Phantram).HasColumnName("PHANTRAM");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            entity.Property(e => e.Tenuudai)
                .HasMaxLength(50)
                .HasColumnName("TENUUDAI");
            entity.Property(e => e.Trangthai).HasColumnName("TRANGTHAI");

            entity.HasOne(d => d.MataikhoanNavigation).WithMany(p => p.Uudais)
                .HasForeignKey(d => d.Mataikhoan)
                .HasConstraintName("FK__UUDAI__MATAIKHOA__59063A47");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
