using aspSample.Data;
using aspSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace aspSample.Controllers
{    
    public class UserController : Controller
    {
        // GET: User
        [ActionName("Index1")]
        public async Task<ActionResult> Index()
        {
            return View("Index", UserData.Users);
        }

        // GET: User/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public async Task<ActionResult> Create(User collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!collection.Name.ToLower().Contains("m"))
                    {
                        ModelState.AddModelError("", "El nombre debe contener una M");
                        return View();
                    }

                    // TODO: Add insert logic here
                    UserData.Users.Add(collection);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
               
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(string id, User collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public async Task<ActionResult> Delete(string id, User collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
