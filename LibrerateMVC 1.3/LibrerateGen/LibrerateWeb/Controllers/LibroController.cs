using LibrerateGenNHibernate.CAD.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrerateWeb.Controllers
{
    public class LibroController : BasicController
    {
        // GET: Libro
        public ActionResult Index()
        {
            LibroCEN cen = new LibroCEN();
            IList<LibroEN> list = cen.ReadAll(0, -1).ToList();
            AssemblerLibro ass = new AssemblerLibro();
            IList<Libro> list2 = ass.ConvertListENToModel(list);
            return View(list2);
        }

        // GET: Libro/Details/5
        public ActionResult Details(int id)
        {
            Libro lbr = null;
            SessionInitialize();
            LibroEN lbrEN = new LibroCAD(session).ReadOIDDefault(id);
            lbr = new AssemblerLibro().ConvertENToModelUI(lbrEN);
            SessionClose();
            return View(lbr);
        }

        // GET: Libro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libro/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Libro/Edit/5
        public ActionResult Edit(int id)
        {
            Libro lib = null;
            SessionInitialize();
            LibroEN libEN = new LibroCAD(session).ReadOIDDefault(id);
            lib = new AssemblerLibro().ConvertENToModelUI(libEN);
            SessionClose();
            return View(lib);
        }

        // POST: Libro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Libro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Libro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
