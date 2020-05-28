namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phong")]
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            HDThuePhongs = new HashSet<HDThuePhong>();
        }

        [Key]
        [StringLength(20)]
        public string MaPhong { get; set; }

        [StringLength(50)]
        public string TenPhong { get; set; }

        [StringLength(20)]
        public string MaKhu { get; set; }

        public int? GiaPhong { get; set; }

        public int? SoGiuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HDThuePhong> HDThuePhongs { get; set; }

        public virtual KhuNha KhuNha { get; set; }
    }
}
