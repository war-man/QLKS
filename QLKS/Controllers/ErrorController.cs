﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLKS.Controllers
{
    public class ErrorController : Controller
    {
        private QLKSEntities1 db = new QLKSEntities1();
        private TaiKhoan taiKhoan = new TaiKhoan();
        // GET: Error
        [HttpGet]
        public ActionResult PMAccessDenied()
        {
            return View("PMAccessDenied");
        }
       
    }
}