namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(20)]
        [Display(Name ="Tài khoản")]
        public string UserName { get; set; }

        [StringLength(250)]

        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [StringLength(50)]

       
        public string EmailAddress { get; set; }

        [StringLength(30)]

        [Display(Name = "Mã sinh viên")]
        public string MaSV { get; set; }


        public virtual SinhVien SinhVien { get; set; }
    }
}
