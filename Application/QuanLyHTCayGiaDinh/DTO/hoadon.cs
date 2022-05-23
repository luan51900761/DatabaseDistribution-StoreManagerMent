namespace QuanLyBanHoa.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hoadon")]
    public partial class hoadon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hoadon()
        {
            chitiethoadons = new HashSet<chitiethoadon>();
        }

        [Key]
        [StringLength(5)]
        public string mahd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaylap { get; set; }

        [StringLength(5)]
        public string manv { get; set; }

        [Required]
        [StringLength(5)]
        public string macn { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.Browsable(false)]
        public Guid rowguid { get; set; }

        public int? tong { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        [StringLength(10)]
        public string sdt { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual chinhanh chinhanh { get; set; }
        [System.ComponentModel.Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitiethoadon> chitiethoadons { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual nhanvien nhanvien { get; set; }
    }
}
