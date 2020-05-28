namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GatDo")]
    public partial class GatDo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GatDo()
        {
            HoaDonGiatDoes = new HashSet<HoaDonGiatDo>();
        }

        [Key]
        [StringLength(20)]
        public string MaLoai { get; set; }

        [StringLength(50)]
        public string TenLoai { get; set; }

        public double? Gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonGiatDo> HoaDonGiatDoes { get; set; }
    }
}
