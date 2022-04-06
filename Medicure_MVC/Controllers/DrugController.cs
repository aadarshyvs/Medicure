using Medicure_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Medicure_MVC.Controllers
{
    public class DrugController : Controller
    {
        public static List<Drug> drugs = new List<Drug>();
        public IActionResult Index()
        {
            
            Drug d = new Drug();
      
            return View(drugs);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            Drug d = new Drug();
            d.Id =Convert.ToInt32( form["Id"]);
            d.Name = form["Name"];
            d.Price = Convert.ToInt64(form["Price"]);
            d.Salesmen_Qty = Convert.ToInt32(form["Salesmen_Qty"]);
            d.Supplier_Qty = Convert.ToInt32(form["Supplier_Qty"]);
            drugs.Add(d);
            return RedirectToAction(actionName: "Index");
        }
        public IActionResult edit(int id)
        {
            Drug d = new Drug();
            foreach (var item in drugs)
            {
                if (item.Id == Convert.ToInt32(id))
                {
                    d.Id = item.Id;
                    d.Name = item.Name;
                    d.Price = item.Price;
                    d.Salesmen_Qty = item.Salesmen_Qty;
                    d.Supplier_Qty = item.Supplier_Qty;

                }
            }
                    return View(d);
        }
        [HttpPost]
        public IActionResult edit(IFormCollection form)
        {
            foreach(var item in drugs)
            {
                if(item.Id== Convert.ToInt32(form["Id"]))
                {
                    
                    item.Name = form["Name"];
                    item.Price = Convert.ToInt64(form["Price"]);
                    item.Salesmen_Qty = Convert.ToInt32(form["Salesmen_Qty"]);
                    item.Supplier_Qty = Convert.ToInt32(form["Supplier_Qty"]);
                    

                }
            }
         
            
            return RedirectToAction(actionName: "Index");
        }
        public IActionResult Details(int id)
        {
            Drug d = new Drug();
            foreach (var item in drugs)
            {
                if (item.Id == Convert.ToInt32(id))
                {
                    d.Id = item.Id;
                    d.Name = item.Name;
                    d.Price = item.Price;
                    d.Salesmen_Qty = item.Salesmen_Qty;
                    d.Supplier_Qty = item.Supplier_Qty;

                }
            }
            return View(d);
        }
        public IActionResult Delete(int id)
        {
            
            foreach (var item in drugs)
            {
                if (item.Id == Convert.ToInt32(id))
                {
                    drugs.Remove(item);

                }
            }
            return RedirectToAction(actionName: "Index");
        }

    }
}
