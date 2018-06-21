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
    public class AlbumController : BasicController
    {
        public ActionResult Index()
        {


            AlbumCEN cen = new AlbumCEN();
            
         
            IList<AlbumEN> list = cen.ReadAll(0, -1).ToList();
            IList<Album> Albums = new AlbumAssembler().ConvertListENToModel(list);
            return View(Albums);

        }

        // GET: Album/Details/5

        public ActionResult Details(int id)
        {
            Album usu = null;
            SessionInitialize();
            AlbumEN artEN = new AlbumCAD(session).ReadOIDDefault(id);
            usu = new AlbumAssembler().ConvertENToModelUI(artEN);
            SessionClose();
            return View(usu);
        }

        //
        // GET: /Album/Create

        public ActionResult Create()
        {
            if (Roles.IsUserInRole("admin"))
            {
                Album usu = new Album();

                return View(usu);
            }
            return RedirectToAction("Index", "Home");

        }

        // GET: /Album/Create

        public ActionResult Create2()
        {

            Album usu = new Album();

            return View(usu);

        }



        //
        // POST: /Album/Create

        [HttpPost]
        public ActionResult Create(Album model)
        {


            try
            {


                SessionInitialize();
                AlbumCAD cad = new AlbumCAD(session);
                AlbumCEN cen = new AlbumCEN(cad);

                cen.New_(model.titulo,model.descripcion,model.cantidad,model.usuario.Id);

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
        // GET: /Album/Edit/5

        public ActionResult Edit(int id)
        {
            Album usu = null;
            SessionInitialize();
            AlbumEN artEN = new AlbumCAD(session).ReadOIDDefault(id);
            usu = new AlbumAssembler().ConvertENToModelUI(artEN);
            SessionClose();
            return View(usu);
        }

        //
        // POST: /Album/Edit/5

        [HttpPost]
        public ActionResult Edit(Album publi)
        {

            try
            {

                SessionInitialize();
                AlbumCAD cad = new AlbumCAD(session);
                AlbumCEN cen = new AlbumCEN(cad);

                cen.Modify(publi.id,publi.titulo,publi.descripcion,publi.cantidad);
                SessionClose();
                return RedirectToAction("Details", new { id = publi.id });
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Album/Delete/5

        public ActionResult Delete(int id)
        {

            SessionInitialize();
            AlbumCAD usuCAD = new AlbumCAD(session);
            AlbumCEN cen = new AlbumCEN(usuCAD);
            AlbumEN usuEN = cen.ReadOID(id);
            Album usu = new AlbumAssembler().ConvertENToModelUI(usuEN);
            SessionClose();

            return View(usu);



        }

        //
        // POST: /Album/Delete/5

        [HttpPost]
        public ActionResult Delete(Album usu)
        {
            try
            {

                SessionInitialize();
                AlbumCAD usuCAD = new AlbumCAD(session);
                AlbumCEN cen = new AlbumCEN(usuCAD);
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
            AlbumCAD cadArt = new AlbumCAD(session);
            AlbumCEN cen = new AlbumCEN(cadArt);

            IList<AlbumEN> listArtEn = cen.LeerNombre(nombre);
            IList<Album> listArt = new AlbumAssembler().ConvertListENToModel(listArtEn).ToList();


            SessionClose();
            return View(listArt);
        }

        [HttpPost]
        public ActionResult AnyadirLibro(int id, Libro libro)
        {
            try
            {

                SessionInitialize();

                AlbumCAD cad2 = new AlbumCAD(session);
                AlbumCEN cen2 = new AlbumCEN(cad2);
                LibroCAD cad = new LibroCAD(session);
                LibroCEN cen = new LibroCEN(cad);
                LibroEN en = cen.ReadOID(libro.id);
                IList<int> libros = null;
                libros.Add(en.Id);
                cen2.AnyadirLibroAlbum(id, libros);

                SessionClose();
                return RedirectToAction("Index");


            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult QuitarLibro(int id, Libro libro)
        {
            try
            {
                SessionInitialize();

                AlbumCAD cad2 = new AlbumCAD(session);
                AlbumCEN cen2 = new AlbumCEN(cad2);
                LibroCAD cad = new LibroCAD(session);
                LibroCEN cen = new LibroCEN(cad);
                LibroEN en = cen.ReadOID(libro.id);
                IList<int> libros = null;
                libros.Add(en.Id);
                cen2.QuitarLibroAlbum(id, libros);



                SessionClose();
                return RedirectToAction("Index");


            }
            catch
            {
                return View();
            }
        }
    }
}
