namespace QuanLyBanHoa.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chitiethoadon")]
    public partial class chitiethoadon
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string mahd { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string masp { get; set; }

        public int? soluong { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public Guid rowguid { get; set; }

        public virtual hoadon hoadon { get; set; }

        public virtual sanpham sanpham { get; set; }
    }
}
