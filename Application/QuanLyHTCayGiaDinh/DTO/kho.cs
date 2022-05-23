namespace QuanLyBanHoa.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kho")]
    public partial class kho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kho()
        {
            phieunhaps = new HashSet<phieunhap>();
            tonkhoes = new HashSet<tonkho>();
        }

        [Key]
        [StringLength(5)]
        public string makho { get; set; }

        [StringLength(100)]
        public string tenkho { get; set; }

        [StringLength(100)]
        public string diachi { get; set; }

        [Required]
        [StringLength(5)]
        public string macn { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.Browsable(false)]

        public Guid rowguid { get; set; }
        [System.ComponentModel.Browsable(false)]

        public virtual chinhanh chinhanh { get; set; }
        [System.ComponentModel.Browsable(false)]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phieunhap> phieunhaps { get; set; }
        [System.ComponentModel.Browsable(false)]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tonkho> tonkhoes { get; set; }

    }
}
