﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esmeraldaplus.Web.Controllers
{
    public class aboutController : Controller
    {
        // GET: aboutController
        public ActionResult Index()
        {
            return View();
        }

        // GET: aboutController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: aboutController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: aboutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: aboutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: aboutController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: aboutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: aboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
