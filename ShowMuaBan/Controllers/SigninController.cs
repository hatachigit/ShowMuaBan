﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowMuaBan.Controllers
{
    public class SigninController : Controller
    {
        // GET: Signin
        public ActionResult FormDangKy()
        {
            return View();
        }
    }
}