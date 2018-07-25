﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            this.ThuePhong = new HashSet<ThuePhong>();
        }

        [Required(ErrorMessage = "Mã phòng không được bỏ trống")]
        [DisplayName("Mã phòng")]
        public int MaPhong { get; set; }

        [Required(ErrorMessage = "Mã phòng không được bỏ trống")]
        [DisplayName("Tên phòng")]
        [StringLength(5, MinimumLength = 3, ErrorMessage = "Tên phòng không được quá 5 ký tự và ít hơn 3 ký tự")]
        public string TenPhong { get; set; }


        public Nullable<int> MaLoai { get; set; }

        [DisplayName("Mô tả")]
        public string GhiChu { get; set; }

        [DisplayName("Tình trạng")]
        public Nullable<bool> TinhTrang { get; set; }

        [NotMapped]
        public string ChuyenKieuTinhTrang { get { bool result; Boolean.TryParse(this.TinhTrang.ToString(), out result); return result ? "Đã đặt" : "Còn phòng"; } }


        public virtual LoaiPhong LoaiPhong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThuePhong> ThuePhong { get; set; }
    }
}
