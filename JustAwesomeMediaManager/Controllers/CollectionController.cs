﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JustAwesomeMediaManager.Controllers
{
    public class CollectionController : Controller
    {
        //
        // GET: /Collection/

        public ActionResult Index()
        {

            CollectionProgressModel cpm = new CollectionProgressModel();
            cpm.Fetch();

            return View(cpm);
        }

    }
}
