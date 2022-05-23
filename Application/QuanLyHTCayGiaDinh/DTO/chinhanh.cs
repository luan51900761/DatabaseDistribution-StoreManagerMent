namespace QuanLyBanHoa.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chinhanh")]
    public partial class chinhanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chinhanh()
        {
            hoadons = new HashSet<hoadon>();
            khoes = new HashSet<kho>();
            nhanviens = new HashSet<nhanvien>();
        }

        [Key]
        [StringLength(5)]
        public string macn { get; set; }

        [StringLength(100)]
        public string tencn { get; set; }

        [StringLength(100)]
        public string diachi { get; set; }

        [StringLength(10)]
        public string sodt { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid rowguid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoadon> hoadons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kho> khoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhanvien> nhanviens { get; set; }
    }
}
