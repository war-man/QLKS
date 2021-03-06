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

    public partial class ChiTietHoaDon
    {
        [Required(ErrorMessage = "Mã hóa đơn không được bỏ trống")]
        [DisplayName("Mã hóa đơn")]
        public int MaHD { get; set; }


        public int MaThuePhong { get; set; }

        [DisplayName("Ngày thanh toán")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> NgayThanhToan { get; set; }

        [DisplayName("Số ngày thuê")]
        [Required(ErrorMessage = "Số ngày thuê không được bỏ trống")]
        [Range(1, 31, ErrorMessage = "Số ngày thuê không được quá 32 ngày")]
        public Nullable<int> SoNgayThue { get; set; }

        [DisplayName("Thành tiền")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:#,###}VNĐ")]
        public Nullable<decimal> ThanhTien { get; set; }


        public virtual HD HD { get; set; }
        public virtual ThuePhong ThuePhong { get; set; }
    }
}
