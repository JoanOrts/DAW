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
    public class UsuarioController : BasicController
    {
        //
        // GET: /Usuario/
        
        public ActionResult Index()
        {
            UsuarioCEN cen = new UsuarioCEN();
            IList<UsuarioEN> list = cen.ReadAll(0, -1).ToList();
            IList<Usuario> usuarios = new UsuarioAssembler().ConvertListENToModel(list);
            return View(usuarios);
        }



        // GET: /Usuario/LeerNombre/

        public ActionResult leerNombre (string nombre)
        {
            SessionInitialize(); //hace falta crear el CEN con el CAD?
            UsuarioCAD cadArt = new UsuarioCAD(session);
            UsuarioCEN cen = new UsuarioCEN(cadArt);
            
            IList<UsuarioEN> listArtEn = cen.LeerNombre(nombre);
            IList<Usuario> listArt = new UsuarioAssembler().ConvertListENToModel(listArtEn).ToList();

            
            SessionClose();
            return View(listArt);
        }


        public ActionResult Banear()
        {
            UsuarioCEN cen = new UsuarioCEN();
            IList<UsuarioEN> list = cen.ReadAll(0, -1).ToList();
            IList<Usuario> usuarios = new UsuarioAssembler().ConvertListENToModel(list);
            return View(usuarios);
        }


        [HttpPost]
        public ActionResult Banear(Usuario usu)
        {
            try
            {

                
                UsuarioCP cp = new UsuarioCP();
                
                cp.Banear(usu.id);

               
              
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult HacerAdmin(Usuario usu)
        {
            try
            {


                UsuarioCP cp = new UsuarioCP();
                cp.HacerAdmin(usu.id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult SeguirAutor(int id, Autor autor)
        {
            try
            {

                SessionInitialize();

                UsuarioCAD cadArt = new UsuarioCAD(session);
                UsuarioCEN cen = new UsuarioCEN(cadArt);
                cen.SeguirAutor(id,autor.id);
                SessionClose();
                return RedirectToAction("Index");
                



            }
            catch
            {
                return View();
            }
        }
        

        public ActionResult DeseguirAutor(int id, Autor autor)
        {
            try
            {

                SessionInitialize();
                UsuarioCAD cadArt = new UsuarioCAD(session);
                UsuarioCEN cen = new UsuarioCEN(cadArt);
                cen.DeseguirAutor(id, autor.id);
                SessionClose();
                return RedirectToAction("Index");


            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult AnyadirLibro(int id, Libro libro)
        {
            try
            {

                SessionInitialize();
                UsuarioCAD cad2 = new UsuarioCAD(session);
                UsuarioCEN cen2 = new UsuarioCEN(cad2);
                LibroCAD cad = new LibroCAD(session);
                LibroCEN cen = new LibroCEN(cad);
                LibroEN en = cen.ReadOID(libro.id);
                IList<int> libros = null;
                libros.Add(en.Id);
                cen2.AnyadirLibro(id,libros);

                SessionClose();
                return RedirectToAction("Index");


            }
            catch
            {
                return View();
            }
        }

        public ActionResult QuitarLibro(int id, Libro libro)
        {
            try
            {
                SessionInitialize();

                UsuarioCAD cad2 = new UsuarioCAD(session);
                UsuarioCEN cen2 = new UsuarioCEN(cad2);
                LibroCAD cad = new LibroCAD(session);
                LibroCEN cen = new LibroCEN(cad);
                LibroEN en = cen.ReadOID(libro.id);
                IList<int> libros = null;
                libros.Add(en.Id);
                cen2.QuitarLibro(id, libros);
               
                

                SessionClose();
                return RedirectToAction("Index");


            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(int id)
        {
            Usuario usu = null;
            SessionInitialize();
            UsuarioEN artEN = new UsuarioCAD(session).ReadOIDDefault(id);
            usu = new UsuarioAssembler().ConvertENToModelUI(artEN);
            SessionClose();
            return View(usu);
        }

        public ActionResult Details2(int id)
        {
            Usuario usu = null;
            SessionInitialize();
            UsuarioEN artEN = new UsuarioCAD(session).ReadOIDDefault(id);
            usu = new UsuarioAssembler().ConvertENToModelUI(artEN);
            SessionClose();
            return View(usu);
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            Usuario usu = new Usuario();
                
            return View(usu);

        }

        // GET: /Usuario/Create

        [HttpPost]
        public ActionResult Create(Usuario user)
        {
            UsuarioCEN usu = new UsuarioCEN();
            usu.New_(user.Nombre, user.Email, user.fecha, user.Contrasena, user.Baneado, user.Imagen);

            return RedirectToAction("Index");
            
        }

     

        //
        // POST: /Usuario/Create

        /*[HttpPost]
        public ActionResult Create(Usuario model, HttpPostedFileBase file)
        {
          
            if (ModelState.IsValid)
            {
                string fileName = "", path = "";
                if (file != null && file.ContentLength > 0)
                {
                    fileName = Path.GetFileName(file.FileName);
                    path = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                    file.SaveAs(path);
                }

                try
                {
                    SessionInitialize();
                    UsuarioCAD usucad = new UsuarioCAD(session);
                    UsuarioCEN usu = new UsuarioCEN(usucad);
                    UsuarioEN usuen = new UsuarioEN();
                    usuen.Contrasena = model.Contrasena;

                    usuen.Email = model.Email;

                    fileName = "/Images/Uploads/" + fileName;
                    //anyadir propiedad foto
                    usuen.Imagen = fileName;

                    usuen.Nombre = model.Nombre;


                    usu.New_(model.Nombre, model.Email, model.fecha, model.Contrasena, false, fileName);
                    Roles.AddUserToRole(model.Nombre, "usuario");

                    SessionClose();

                    

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            // Si llegamos a este punto, es que se ha producido un error y volvemos a mostrar el formulario
            return View(model);
        }*/
        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(int id)
        {
            Usuario usu = null;
            SessionInitialize();
            UsuarioEN artEN = new UsuarioCAD(session).ReadOIDDefault(id);
            usu = new UsuarioAssembler().ConvertENToModelUI(artEN);
            SessionClose();
            return View(usu);
        }

        //
        // POST: /Usuario/Edit/5

        [HttpPost]
        public ActionResult Edit(Usuario u)
        {
            UsuarioCEN usu = new UsuarioCEN();
            usu.Modify(u.id, u.Nombre, u.Email, u.fecha, u.Contrasena, u.Baneado, u.Imagen);

            return RedirectToAction("Index");
        }

        /*[HttpPost]
        public ActionResult Edit(Usuario usu, HttpPostedFileBase file)
        {
            string fileName = "", path = "";
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file.SaveAs(path);
            }
            try
            {

                SessionInitialize();
                UsuarioCAD cad = new UsuarioCAD(session);
                UsuarioCEN cen = new UsuarioCEN(cad);
                fileName = "/Images/Uploads/" + fileName;
                if (usu.Imagen != fileName && fileName != "/Images/Uploads/")
                {
                    usu.Imagen= fileName;
                }
                cen.Modify(usu.id, usu.Nombre,usu.Email, DateTime.Now, usu.Contrasena, false, usu.Imagen);
                SessionClose();
                return RedirectToAction("Details", new { id = usu.id });
            }
            catch
            {
                return View();
            }
        }*/
    

        //
        // GET: /Usuario/Delete/5

        public ActionResult Delete(int id)
        {

        SessionInitialize();
        UsuarioCAD usuCAD = new UsuarioCAD(session);
        UsuarioCEN cen = new UsuarioCEN(usuCAD);
            UsuarioEN usuEN = cen.ReadOID(id);
        Usuario usu = new UsuarioAssembler().ConvertENToModelUI(usuEN);
        SessionClose();

            return View(usu);
        
       

    }

        //
        // POST: /Usuario/Delete/5

        [HttpPost]
        public ActionResult Delete(Usuario usu)
        {
            try
            {
                new UsuarioCEN().Destroy(usu.id);   
             
                return RedirectToAction("Index", "Usuario");
                
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Publicar()
        {

            Publicacion publi = new Publicacion();

            return View(publi);

        }
        [HttpPost]
        public ActionResult Publicar(Publicacion publi)
        {
            try { 
            UsuarioCP usu= new UsuarioCP();
            
            //usu.Publicar(publi.Nombre, publi.NumPag, publi.usuario.Id, publi.Nombre);

            //Hay que hacer el método Publicar del UsuarioCP

            return RedirectToAction("Index");

            }

            catch
            {
                return View();
            }

        }
    }
}
