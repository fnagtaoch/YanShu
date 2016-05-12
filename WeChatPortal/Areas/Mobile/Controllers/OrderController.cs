﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeChatPortal.Filters;

namespace WeChatPortal.Areas.Mobile.Controllers
{
    [YanShuAuthorize]
    public class OrderController : MobileBaseController
    {
        // GET: Mobile/Order
        public ActionResult Index()
        {
            return View();
        }
    }
}