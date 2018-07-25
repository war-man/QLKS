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

    public partial class DoanhThu
    {
        [Required(ErrorMessage = "Mã doanh thu không được bỏ trống")]
        [DisplayName("Mã doanh thu")]
        public int MaDoanhThu { get; set; }

        [Required(ErrorMessage = "Tháng không được bỏ trống")]
        [DisplayName("Tháng")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "Tháng {0:MM}")]
        public System.DateTime Thang { get; set; }


        public virtual ChiTietDoanhThu ChiTietDoanhThu { get; set; }
    }
}
