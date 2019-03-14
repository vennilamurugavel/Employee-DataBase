using System;
using information.Models;
using System.Web.Mvc;
using System.Collections.Generic;

namespace information.Controllers
{
    public class Info1Controller : Controller
    {
        // GET: info1
        public ActionResult Index()
        {
            DBhandle handle = new DBhandle();
           
            return View(handle.Getdetail());
        }
        // GET: info1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: info1/Create
        [HttpPost]
        public ActionResult Create(info smodel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    DBhandle dbh = new DBhandle();
                    if(dbh.Addstudent(smodel))
                    {
                        ViewBag.message = "Student details added sucessfully";
                       
                    }
                }
                return View();
            }
          
            catch(Exception e)
            {
                return View();
            }
        }
        
        public ActionResult Detail1(int Id)
        {
            DBhandle db = new DBhandle();
            return View(db.Getdetail().Find(smodel=>smodel.Id==Id));
        }
        [HttpPost]
        public ActionResult Detail1(int Id, info smodel)
        {
            try

            {

                // TODO: Add update logic here
                DBhandle db = new DBhandle();
                db.Show(smodel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

      



        // GET: info1/Edit/5
        public ActionResult Edit(int Id)
        {
            
            DBhandle dbh = new DBhandle();  
            return View(dbh.Getdetail().Find(smodel=>smodel.Id==Id));
        }

        // POST: info1/Edit/5
        [HttpPost]
        public ActionResult Edit(int Id, info smodel)
        {
            try
            
            {

                // TODO: Add update logic here
                DBhandle dbh = new DBhandle();
                dbh.Updatedetail(smodel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: info1/Delete/5
        
        public ActionResult Delete(int Id)
        {
            try
            { 
                 DBhandle dbh = new DBhandle();
                 if (dbh.Deletedetail(Id))
                 {
                   ViewBag.AlertMsg = "deleted sucessfully";
                 }
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View();
            }
        }
        

        
    }
}
