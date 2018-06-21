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
    public class AutorController : BasicController
    {
        // GET: Usuario
        public ActionResult Index()
        {
            AutorCEN cen = new AutorCEN();
            IList<AutorEN> listen = cen.ReadAll(0, -1).ToList();
            AssemblerAutor ass = new AssemblerAutor();
            IList<Autor> list = ass.ConvertListENToModel(listen);
            return View(list);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            AutorCAD cad = new AutorCAD(session);
            AutorCEN cen = new AutorCEN(cad);
            AutorEN en = cad.ReadOIDDefault(id);
            AssemblerAutor ass = new AssemblerAutor();
            Autor aut = ass.ConvertENToModelUI(en);
            SessionClose();
            return View(aut);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            Autor aut = new Autor();
            return View(aut);
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(Autor au)
        {
            try
            {
                AutorCEN cen = new AutorCEN();
                cen.New_(au.Ganancias, au.Email, au.Fecha, au.Usuario.Id, au.Nombre);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            AutorCAD cad = new AutorCAD(session);
            AutorEN en = cad.ReadOIDDefault(id);
            AssemblerAutor ass = new AssemblerAutor();
            Autor au = ass.ConvertENToModelUI(en);
            SessionClose();
            return View(au);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(Autor au)
        {
            try
            {
                AutorCEN cen = new AutorCEN();
                cen.Modify(au.id, au.Ganancias, au.Email, au.Fecha, au.Nombre);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                AutorCEN cen = new AutorCEN();
                cen.Destroy(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Usuario/Delete/5
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

        public ActionResult LeerNombre(String nombre)
        {
            
            AutorCEN cen = new AutorCEN();
            IList<AutorEN> listen = cen.LeerNombre(nombre);
            AssemblerAutor ass = new AssemblerAutor();
            IList<Autor> aus = ass.ConvertListENToModel(listen);

            return View(aus);
        }
    }
}
