namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HDThuePhong")]
    public partial class HDThuePhong
    {
        [Key]
        [StringLength(20)]
        public string MaHDP { get; set; }

        [Required]
        [StringLength(30)]
        public string MaSV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayThue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        [StringLength(20)]
        public string MaPhong { get; set; }

        public double? Gia { get; set; }

        public virtual Phong Phong { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
