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

    public partial class LoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiPhong()
        {
            this.ChiTietDoanhThu = new HashSet<ChiTietDoanhThu>();
            this.Phong = new HashSet<Phong>();
        }

        [DisplayName("Mã loại phòng")]
        [Required(ErrorMessage = "Mã loại phòng không được bỏ trống")]
        [Range(1, 2000)]
        public int MaLoai { get; set; }

        [DisplayName("Loại phòng")]
        [StringLength(1)]
        public string TenLoai { get; set; }

        [DisplayName("Đơn giá")]
        [DisplayFormat(DataFormatString = "{0:#,###}VNĐ")]
        public Nullable<decimal> Dongia { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDoanhThu> ChiTietDoanhThu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phong { get; set; }
    }
}
