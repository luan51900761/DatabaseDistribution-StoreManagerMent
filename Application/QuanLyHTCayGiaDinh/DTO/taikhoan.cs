namespace QuanLyBanHoa.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("taikhoan")]
    public partial class taikhoan
    {
        [StringLength(5)]
        public string manv { get; set; }

        [Key]
        [StringLength(20)]
        public string tentaikhoan { get; set; }

        [StringLength(100)]
        public string matkhau { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid rowguid { get; set; }

        public virtual nhanvien nhanvien { get; set; }
    }
}
