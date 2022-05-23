namespace QuanLyBanHoa.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("phieunhap")]
    public partial class phieunhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public phieunhap()
        {
            chitietphieunhaps = new HashSet<chitietphieunhap>();
        }

        [Key]
        [StringLength(5)]
        public string mapn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaynhap { get; set; }

        [StringLength(5)]
        public string makho { get; set; }

        [StringLength(5)]
        public string mancc { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.Browsable(false)]

        public Guid rowguid { get; set; }
        public int tong { get; set; }
        public int tinhtrang { get; set; }
        [System.ComponentModel.Browsable(false)]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chitietphieunhap> chitietphieunhaps { get; set; }
        [System.ComponentModel.Browsable(false)]

        public virtual kho kho { get; set; }
        [System.ComponentModel.Browsable(false)]

        public virtual nhacc nhacc { get; set; }
    }
}
