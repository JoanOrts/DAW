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
    public class CriticaController : BasicController
    {
        // GET: Critica
        public ActionResult Index()
        {
            CriticaCEN cen = new CriticaCEN();
            IList<CriticaEN> list = cen.ReadAll(0, -1).ToList();
            IList<Critica> criticas = new AssemblerCritica().ConvertListENToModel(list);
            return View(criticas);
        }

        // GET: Critica/Details/5
        public ActionResult Details(int id)
        {

            SessionInitialize();
            CriticaCAD cad = new CriticaCAD(session);
            CriticaCEN cen = new CriticaCEN(cad);
            CriticaEN en = cad.ReadOIDDefault(id);
            AssemblerCritica ass = new AssemblerCritica();
            Critica critica = ass.ConvertENToModelUI(en);
            SessionClose();
            return View(critica);
        }

        // GET: Critica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Critica/Create
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

        // GET: Critica/Edit/5
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            CriticaCAD cad = new CriticaCAD(session);
            CriticaEN en = cad.ReadOIDDefault(id);
            AssemblerCritica ass = new AssemblerCritica();
            Critica critica = ass.ConvertENToModelUI(en);
            SessionClose();
            return View(critica);
        }

        // POST: Critica/Edit/5
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

        // GET: Critica/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Critica/Delete/5
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
