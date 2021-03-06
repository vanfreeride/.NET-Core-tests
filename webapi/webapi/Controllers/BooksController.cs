﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using webapi.core.Interfaces;
using webapi.core.Services;

namespace webapi.Controllers
{
    [Route ("")]
    [Route ("api/[controller]")]
    public class BooksController : Controller
    {
        private BookService serv;

        public BooksController (BookService serv)
        {
            this.serv = serv;
        }

        [HttpGet("get")]
        public JsonResult Get ()
        {
            var result = serv.Get ();

            return Json (result);
        }

        //[Authorize]
        [HttpGet("add")]
        public JsonResult Add ()
        {
            serv.Add ();

            return Json (true);
        }

        [HttpGet("{id}")]
        public JsonResult GetById (int id)
        {
            var result = serv.GetById (id);

            return Json (result);
        }

        [HttpPost]
        [Route ("test")]
        public async Task Test (int id)
        {
            Thread.Sleep (200);
        }
    }
}