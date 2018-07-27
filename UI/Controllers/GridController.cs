﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class GridController : Controller
    {
        private Domain.Entities.TiendaDeMusicaEntities2 context;

        public GridController(Domain.Entities.TiendaDeMusicaEntities2 dbContext)
        {
            context = dbContext;
        }

        // GET: Grid
        public ActionResult Index()
        {
            var data = context.Album.ToList();
            return View(data);
        }
    }
}