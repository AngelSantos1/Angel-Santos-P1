﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontStoreWebUI.Controllers
{
    public class LineItemController : Controller
    {
        // GET: LineItemController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LineItemController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LineItemController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LineItemController/Create
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

        // GET: LineItemController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LineItemController/Edit/5
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

        // GET: LineItemController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LineItemController/Delete/5
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
