﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VLN2_Project.Services;

namespace VLN2_Project.Controllers
{
    public class FileController : Controller
    {
        private FileService _service;

        // GET: File
        public ActionResult Index()
        {
            return View();
        }
    }
}