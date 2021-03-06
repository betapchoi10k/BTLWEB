namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nuoc")]
    public partial class Nuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nuoc()
        {
            HDDienNuocs = new HashSet<HDDienNuoc>();
        }

        [Key]
        [StringLength(20)]
        public string MaNuoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TGBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TGKetThuc { get; set; }

        public double? Gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HDDienNuoc> HDDienNuocs { get; set; }
    }
}
