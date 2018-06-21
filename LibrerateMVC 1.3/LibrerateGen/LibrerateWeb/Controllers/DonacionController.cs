using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using NHibernate;
using LibrerateGenNHibernate.Exceptions;
using LibrerateGenNHibernate.CEN.Librerate;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;
using LibrerateWeb.Models;

namespace LibrerateWeb.Controllers
{
    public class DonacionController : BasicController
    {
        // GET: Donacion
        public ActionResult Index()
        {
            DonacionCEN cen = new DonacionCEN();
            IList<DonacionEN> listen = cen.ReadAll(0, 10);
            DonacionAssembler ass = new DonacionAssembler();
            IList<Donacion> list = ass.ConvertListENToModel(listen);
            return View(list);
        }

        // GET: Donacion/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            DonacionCAD cad = new DonacionCAD(session);
            DonacionCEN cen = new DonacionCEN(cad);
            DonacionEN en = cad.ReadOIDDefault(id);
            DonacionAssembler ass = new DonacionAssembler();
            Donacion don = ass.ConvertENToModelUI(en);
            SessionClose();
            return View(don);
        }

        // GET: Donacion/Create
        public ActionResult Create()
        {
            Donacion don = new Donacion();
            return View(don);
        }

        // POST: Donacion/Create
        [HttpPost]
        public ActionResult Create(Donacion don)
        {
            try
            {
                DonacionCEN cen = new DonacionCEN();
                cen.New_(don.cantidad, don.autor.Id, don.usuario.Id);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Donacion/Edit/5
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            DonacionCAD cad = new DonacionCAD(session);
            DonacionEN en = cad.ReadOIDDefault(id);
            DonacionAssembler ass = new DonacionAssembler();
            Donacion don = ass.ConvertENToModelUI(en);
            SessionClose();
            return View(don);
        }

        // POST: Donacion/Edit/5
        [HttpPost]
        public ActionResult Edit(Donacion don)
        {
            try
            {
                DonacionCEN cen = new DonacionCEN();
                cen.Modify(don.id, don.cantidad);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Donacion/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                DonacionCEN cen = new DonacionCEN();
                cen.Destroy(id);
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Donacion/Delete/5
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
