using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace baitaplon
{
    public class NhaCungCap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        [Column(TypeName = "nvarchar")]
        [Index(IsUnique = true)] 
        public string TenNhaCungCap { get; set; }

        [StringLength(15)]
        [Column(TypeName = "nvarchar")]
        [Index(IsUnique = true)] 
        public string SoDienThoai { get; set; }

        [Column(TypeName = "nvarchar")]
        public string DiaChi { get; set; }

        [Column(TypeName = "decimal")]
        public decimal ThoiGianGiao { get; set; }

        [Column(TypeName = "nvarchar")]
        public string GhiChu { get; set; }

        public decimal DiemUyTin { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }

    public class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        [Column(TypeName = "nvarchar")]
        public string TenSanPham { get; set; }

        [ForeignKey("NhaCungCap")]
        public int NhaCungCapId { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Gia { get; set; }

        [Column(TypeName = "nvarchar")]
        public string GhiChu { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }
    }

    public class btlcontext : DbContext
    {
        public btlcontext() : base("name=QLNCC")
        {
        }

        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<SanPham> SanPham { get; set; }

    }
}
