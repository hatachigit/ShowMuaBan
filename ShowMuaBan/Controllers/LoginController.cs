﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowMuaBan.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult AfterLogin()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
    }
}