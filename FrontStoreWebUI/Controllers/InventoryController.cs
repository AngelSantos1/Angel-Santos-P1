﻿using FrontStoreWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreBL;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontStoreWebUI.Controllers
{
    public class InventoryController : Controller
    {
        private IInventoryBL _invBL;
        private IProductBL _prodBL;
        private IStoreBL _storeBL;


        public InventoryController(IInventoryBL p_invBL, IProductBL p_prodBL, IStoreBL p_storeBL) 
        {
            _invBL = p_invBL;
            _prodBL = p_prodBL;
            _storeBL = p_storeBL;

        }

        /*public ActionResult SeeInventory(int p_id)
        {
            StoreFronts this = _storeBL.Get
            return View(_invBL.InventoryByStoreId()
                        .Select(inv => )
            )              
        }
        */

        


        // GET: InventoryController
        public ActionResult Index(int p_id)
        {
            // InvProdStoreVM crashoverride = new InvProdStoreVM(); 
            /*iewBag.Inventories = ShowInventory();
             */
            //List<Product> listOfProduct = _repo.Product.ToList;
            // var tupleModel = new Tuple<List<Inventory>, List<Product>, List<StoreFront>>(ShowInventory(), GetAllStore(), GetAllProduct());
            //InvProdStoreVM mymodel = new InvProdStoreVM();
            ViewData["Products"] = _prodBL.GetAllProducts();
            ViewData["StoreFronts"] = _storeBL.GetAllStore();
            ViewData["Inventory"] = _invBL.ShowInventory();
            return View(_invBL.AllItemStoreInfo(p_id)
                .Select(inv => new InventoryVM(inv))
                .ToList());
           
        }


        // GET: InventoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InventoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InventoryController/Create
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

        // GET: InventoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InventoryController/Edit/5
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

        // GET: InventoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InventoryController/Delete/5
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
