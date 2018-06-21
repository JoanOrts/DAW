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
    public class LineaPedidoController : BasicController
    {
        // GET: LineaPedido
        public ActionResult Index()
        {
            LineaPedidoCEN cen = new LineaPedidoCEN();
            IList<LineaPedidoEN> listen = cen.ReadAll(0, 10);
            LineaPedidoAssembler ass = new LineaPedidoAssembler();
            IList<LineaPedido> list = ass.ConvertListENToModel(listen);
            return View(list);
        }

        // GET: LineaPedido/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            LineaPedidoCAD cad = new LineaPedidoCAD(session);
            LineaPedidoCEN cen = new LineaPedidoCEN(cad);
            LineaPedidoEN en = cad.ReadOIDDefault(id);
            LineaPedidoAssembler ass = new LineaPedidoAssembler();
            LineaPedido lin = ass.ConvertENToModelUI(en);
            SessionClose();
            return View(lin);
        }

        // GET: LineaPedido/Create
        public ActionResult Create()
        {
            LineaPedido lin = new LineaPedido();
            return View(lin);
        }

        // POST: LineaPedido/Create
        [HttpPost]
        public ActionResult Create(LineaPedido lin)
        {
            try
            {
                LineaPedidoCEN cen = new LineaPedidoCEN();
                cen.New_(lin.cantidad, lin.usuario.Id, lin.carrito.Id, lin.libro.Id);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LineaPedido/Edit/5
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            LineaPedidoCAD cad = new LineaPedidoCAD(session);
            LineaPedidoEN en = cad.ReadOIDDefault(id);
            LineaPedidoAssembler ass = new LineaPedidoAssembler();
            LineaPedido lin = ass.ConvertENToModelUI(en);
            SessionClose();
            return View(lin);
        }

        // POST: LineaPedido/Edit/5
        [HttpPost]
        public ActionResult Edit(LineaPedido lin)
        {
            try
            {
                LineaPedidoCEN cen = new LineaPedidoCEN();
                cen.Modify(lin.id,lin.cantidad);
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LineaPedido/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                LineaPedidoCEN cen = new LineaPedidoCEN();
                cen.Destroy(id);
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: LineaPedido/Delete/5
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
