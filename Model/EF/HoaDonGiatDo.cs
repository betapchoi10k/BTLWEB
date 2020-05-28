namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDonGiatDo")]
    public partial class HoaDonGiatDo
    {
        [Key]
        [StringLength(20)]
        public string MaHoaDonGD { get; set; }

        [StringLength(30)]
        public string MaSV { get; set; }

        [StringLength(20)]
        public string MaLoai { get; set; }

        public int? SL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        public virtual GatDo GatDo { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
