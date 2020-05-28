namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonSuaChua")]
    public partial class HoaDonSuaChua
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaHDSC { get; set; }

        [StringLength(30)]
        public string MaSV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaVatTu { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public virtual SinhVien SinhVien { get; set; }

        public virtual VatTu VatTu { get; set; }
    }
}
