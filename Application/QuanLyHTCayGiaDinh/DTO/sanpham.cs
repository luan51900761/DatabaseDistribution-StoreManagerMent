namespace QuanLyBanHoa.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sanpham")]
    public partial class sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sanpham()
        {
            chitiethoadons = new HashSet<chitiethoadon>();
            chitietphieunhaps = new HashSet<chitietphieunhap>();
            tonkhoes = new HashSet<tonkho>();
        }

        [Key]
        [StringLength(5)]
        public string masp { get; set; }

        [StringLength(100)]
        public string tensp { get; set; }

        [StringLength(100)]
        public string nhasx { get; set; }

        [StringLength(20)]
        public string loai { get; set; }

        public double? giaban { get; set; }

        [StringLength(5)]
        public string nhacc { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid rowguid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitiethoadon> chitiethoadons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietphieunhap> chitietphieunhaps { get; set; }
        public virtual nhacc nhacc1 { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tonkho> tonkhoes { get; set; }
    }
}
