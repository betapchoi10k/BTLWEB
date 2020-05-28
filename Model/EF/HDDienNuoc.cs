namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HDDienNuoc")]
    public partial class HDDienNuoc
    {
        [Key]
        [StringLength(20)]
        public string MaHDDN { get; set; }

        [Required]
        [StringLength(30)]
        public string MaSV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        [StringLength(20)]
        public string MaDien { get; set; }

        public double? SoDien { get; set; }

        [StringLength(20)]
        public string MaNuoc { get; set; }

        public double? SoNuoc { get; set; }

        public virtual Dien Dien { get; set; }

        public virtual Nuoc Nuoc { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
