namespace QuanLyBanHoa.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhanvien")]
    public partial class nhanvien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhanvien()
        {
            hoadons = new HashSet<hoadon>();
            taikhoans = new HashSet<taikhoan>();
        }

        [Key]
        [StringLength(5)]
        public string manv { get; set; }

        [StringLength(100)]
        public string hoten { get; set; }

        [StringLength(10)]
        public string sdt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaylamviec { get; set; }

        [Required]
        [StringLength(5)]
        public string macn { get; set; }

        [StringLength(10)]
        public string chucvu { get; set; }

        [Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid rowguid { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaysinh { get; set; }

        public int? gioitinh { get; set; }

        [StringLength(10)]
        public string cnmd { get; set; }

        public virtual chinhanh chinhanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoadon> hoadons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<taikhoan> taikhoans { get; set; }
    }
}
