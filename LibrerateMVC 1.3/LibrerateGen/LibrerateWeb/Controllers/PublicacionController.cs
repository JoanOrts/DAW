using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using LibrerateGenNHibernate.CEN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;
using LibrerateGenNHibernate.CP.Librerate;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateWeb.Models;
using System.IO;
//libreria extra 


using System.Web.Security;

namespace LibrerateWeb.Controllers
{
    public class PublicacionController : BasicController
    {
        // GET: Publicacion
        public ActionResult Index()
        {


            PublicacionCEN cen = new PublicacionCEN();
            IList<PublicacionEN> list = cen.ReadAll(0, -1).ToList();
            IList<Publicacion> publicacions = new PublicacionAssembler().ConvertListENToModel(list);
            return View(publicacions);

        }

        // GET: Publicacion/Details/5

        public ActionResult Details(int id)
        {
            Publicacion usu = null;
            SessionInitialize();
            PublicacionEN artEN = new PublicacionCAD(session).ReadOIDDefault(id);
            usu = new PublicacionAssembler().ConvertENToModelUI(artEN);
            SessionClose();
            return View(usu);
        }

        //
        // GET: /Publicacion/Create

        public ActionResult Create()
        {
            if (Roles.IsUserInRole("admin"))
            {
                Publicacion usu = new Publicacion();

                return View(usu);
            }
            return RedirectToAction("Index", "Home");

        }

        // GET: /Publicacion/Create

        public ActionResult Create2()
        {

            Publicacion usu = new Publicacion();

            return View(usu);

        }



        //
        // POST: /Publicacion/Create

        [HttpPost]
        public ActionResult Create(Publicacion model)
        {
          

                try
                {


                SessionInitialize();
                PublicacionCAD cad = new PublicacionCAD(session);
                PublicacionCEN cen = new PublicacionCEN(cad);

                cen.New_(model.Nombre, model.libro.Id, model.NumPag);

                SessionClose();



                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            

            // Si llegamos a este punto, es que se ha producido un error y volvemos a mostrar el formulario
            return View(model);
        }
        //
        // GET: /Publicacion/Edit/5

        public ActionResult Edit(int id)
        {
            Publicacion usu = null;
            SessionInitialize();
            PublicacionEN artEN = new PublicacionCAD(session).ReadOIDDefault(id);
            usu = new PublicacionAssembler().ConvertENToModelUI(artEN);
            SessionClose();
            return View(usu);
        }

        //
        // POST: /Publicacion/Edit/5

        [HttpPost]
        public ActionResult Edit(Publicacion publi)
        {
           
            try
            {

                SessionInitialize();
                PublicacionCAD cad = new PublicacionCAD(session);
                PublicacionCEN cen = new PublicacionCEN(cad);
                
                
                cen.Modify(publi.id,publi.Nombre,publi.NumPag);
                SessionClose();
                return RedirectToAction("Details", new { id = publi.id });
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Publicacion/Delete/5

        public ActionResult Delete(int id)
        {

            SessionInitialize();
            PublicacionCAD usuCAD = new PublicacionCAD(session);
            PublicacionCEN cen = new PublicacionCEN(usuCAD);
            PublicacionEN usuEN = cen.ReadOID(id);
            Publicacion usu = new PublicacionAssembler().ConvertENToModelUI(usuEN);
            SessionClose();

            return View(usu);



        }

        //
        // POST: /Publicacion/Delete/5

        [HttpPost]
        public ActionResult Delete(Publicacion usu)
        {
            try
            {

                SessionInitialize();
                PublicacionCAD usuCAD = new PublicacionCAD(session);
                PublicacionCEN cen = new PublicacionCEN(usuCAD);
                cen.Destroy(usu.id);

                SessionClose();

                return RedirectToAction("Index", "Home");

            }
            catch
            {
                return View();
            }
        }

        public ActionResult leerNombre(string nombre)
        {
            SessionInitialize(); //hace falta crear el CEN con el CAD?
            PublicacionCAD cadArt = new PublicacionCAD(session);
            PublicacionCEN cen = new PublicacionCEN(cadArt);

            IList<PublicacionEN> listArtEn = cen.LeerNombre(nombre);
            IList<Publicacion> listArt = new PublicacionAssembler().ConvertListENToModel(listArtEn).ToList();


            SessionClose();
            return View(listArt);
        }


    }
}
