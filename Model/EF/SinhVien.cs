namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            Accounts = new HashSet<Account>();
            HDDienNuocs = new HashSet<HDDienNuoc>();
            HDThuePhongs = new HashSet<HDThuePhong>();
            HoaDonGiatDoes = new HashSet<HoaDonGiatDo>();
            HoaDonSuaChuas = new HashSet<HoaDonSuaChua>();
        }

        [Key]
        [StringLength(30)]
        public string MaSV { get; set; }

        [StringLength(50)]
        public string TenSV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(6)]
        public string GioiTinh { get; set; }

        [StringLength(30)]
        public string CMND { get; set; }

        [StringLength(30)]
        public string NoiCap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCap { get; set; }

        [StringLength(20)]
        public string DanToc { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(20)]
        public string MaKTX { get; set; }

        [StringLength(20)]
        public string MaTruong { get; set; }

        [StringLength(20)]
        public string MaKhoa { get; set; }

        [StringLength(20)]
        public string TonGiao { get; set; }

        [StringLength(20)]
        public string MaThe { get; set; }

        public int? NamHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HDDienNuoc> HDDienNuocs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HDThuePhong> HDThuePhongs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonGiatDo> HoaDonGiatDoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonSuaChua> HoaDonSuaChuas { get; set; }
    }
}
