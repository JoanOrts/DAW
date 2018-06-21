using LibrerateGenNHibernate.CAD.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;
using LibrerateGenNHibernate.CP.Librerate;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrerateWeb.Controllers
{
    public class CarritoController : BasicController
    {
        // GET: Carrito
        public ActionResult Index()
        {
            CarritoCEN cen = new CarritoCEN();
            IList<CarritoEN> listen = cen.ReadAll(0, 1);
            AssemblerCarrito ass = new AssemblerCarrito();
            IList<Carrito> list = ass.ConvertListENToModel(listen);
            return View(list);
        }

        // GET: Carrito/Details/5
        public ActionResult Details(int id)
        {
        //el buzz te da suscriptores.
            
            SessionInitialize();
            CarritoCAD cad = new CarritoCAD(session);
            CarritoCEN cen = new CarritoCEN(cad);
            CarritoEN en = cad.ReadOIDDefault(id);
            AssemblerCarrito ass = new AssemblerCarrito();
            Carrito car = ass.ConvertENToModelUI(en);
            SessionClose();
            return View(car);
        }

        // GET: Carrito/Create
        public ActionResult Create()
        {
            Carrito car = new Carrito();
            return View(car);
        }

        // POST: Carrito/Create
        [HttpPost]
        public ActionResult Create(Carrito car)
        {
            try
            {
                CarritoCEN cen = new CarritoCEN();
                cen.New_(car.Numerador, car.Precio, car.IdUsuario, car.Estado);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Carrito/Edit/5
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            CarritoCAD cad = new CarritoCAD(session);
            CarritoEN en = cad.ReadOIDDefault(id);
            AssemblerCarrito ass = new AssemblerCarrito();
            Carrito au = ass.ConvertENToModelUI(en);
            SessionClose();
            return View(au);
        }

        // POST: Carrito/Edit/5
        [HttpPost]
        public ActionResult Edit(Carrito car)
        {
            try
            {
                CarritoCEN cen = new CarritoCEN();
                cen.Modify(car.id, car.Numerador, car.Precio, car.Estado);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Carrito/Delete/5
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

        // POST: Carrito/Delete/5
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

        public ActionResult CalcularPrecio(int id)
        {
            SessionInitialize();
            CarritoCP cp = new CarritoCP(session);
            cp.CalcularPrecio(id);
            SessionClose();

            return RedirectToAction("Index");
        }

        public ActionResult ProcederCompra(int id)
        {
            try
            {
                SessionInitialize();
                /*
                Por si queremos mostrar el carrito cuyo precio total se vaya a modificar.
                Carrito car = null;
                CarritoCAD cad = new CarritoCAD(session);
                CarritoEN en = cad.ReadOIDDefault(id);
                AssemblerCarrito ass = new AssemblerCarrito();
                car = ass.ConvertENToModelUI(en);
                */
                CarritoCP cp = new CarritoCP(session);
                cp.ProcederCompra(id);
                SessionClose();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AdjuntarLineaPedido(int id)
        {

            return RedirectToAction("Index");
        }
    }
}
