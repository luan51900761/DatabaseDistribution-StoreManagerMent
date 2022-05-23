namespace QuanLyBanHoa.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tonkho")]
    public partial class tonkho
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string makho { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string masp { get; set; }

        public int? soluong { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid rowguid { get; set; }

        public virtual kho kho { get; set; }

        public virtual sanpham sanpham { get; set; }
    }
}
