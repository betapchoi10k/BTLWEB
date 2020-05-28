namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VatTu")]
    public partial class VatTu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VatTu()
        {
            HoaDonSuaChuas = new HashSet<HoaDonSuaChua>();
        }

        [Key]
        [StringLength(20)]
        public string MaVatTu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Loai { get; set; }

        public int? SoLuong { get; set; }

        public double? Gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonSuaChua> HoaDonSuaChuas { get; set; }
    }
}
