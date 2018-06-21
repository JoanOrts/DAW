
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;
using LibrerateGenNHibernate.Enumerated.Librerate;
using LibrerateGenNHibernate.CP.Librerate;
/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes

                System.Console.WriteLine ("Creando Usuarios...");
                UsuarioCEN usuarioCEN = new UsuarioCEN ();
                int usu1 = usuarioCEN.New_ ("Joan7", "joanpolopi@gmail.com", System.DateTime.Now, "123456789", false, "usu1.jpg");
                int usu2 = usuarioCEN.New_ ("Victor666", "victorjaja@gmail.com", System.DateTime.Now, "987654321", false, "usu2.jpg");
                int usu3 = usuarioCEN.New_ ("9Pedro9", "pedrounodos@gmail.com", System.DateTime.Now, "1234abcd", false, "usu3.jpg");
                UsuarioEN usuarioEN1 = usuarioCEN.ReadOID (usu1);
                System.Console.WriteLine (usuarioEN1.Nombre);

                System.Console.WriteLine ("Creando Administradores...");
                AdministradorCEN administradorCEN = new AdministradorCEN ();
                int admin1 = administradorCEN.New_ ("Joan7", "joanpolopi@gmail.com", System.DateTime.Now, usu1, "contrasenasecreta");

                System.Console.WriteLine ("Creando Libros...");
                LibroCEN libroCEN = new LibroCEN ();
                int lib1 = libroCEN.New_ ("Como aprobar DSM en 10 pasos", 10, System.DateTime.Now, "DSM", "asdfg.jpg", GeneroEnum.Fantasia, 103, "Espanyol", 0, null, 4, usu1);
                int lib2 = libroCEN.New_ ("Las aventuras de Pepe", 17, System.DateTime.Now, "DSM2", "asdfg.jpg", GeneroEnum.Ficcion, 103, "Ingles", 0, null, 4, usu1);
                LibroCAD libroCAD = new LibroCAD ();
                LibroCP libroCP = new LibroCP ();


                System.Console.WriteLine ("Creando Album...");
                AlbumCEN albumCEN = new AlbumCEN ();
                int album1 = albumCEN.New_ ("Libros para dormir", "Listado de libros para leer por la noche", 10, usu1);

                System.Console.WriteLine ("Creando Autores...");
                AutorCEN autorCEN = new AutorCEN ();
                int auto1 = autorCEN.New_ (0, "joanpolopi@gmail.com", System.DateTime.Now, usu1, "Joan7");
                int auto2 = autorCEN.New_ (0, "victorjaja@gmail.com", System.DateTime.Now, usu2, "Victor666");

                System.Console.WriteLine ("Creando Puntuaciones...");
                PuntuacionCEN puntuacionCEN = new PuntuacionCEN ();
                int puntu1 = puntuacionCEN.New_ (5, lib1, usu1);
                int puntu2 = puntuacionCEN.New_ (3, lib1, usu2);



                System.Console.WriteLine ("Creando Critica...");
                CriticaCEN criticaCEN = new CriticaCEN ();
                int crit1 = criticaCEN.New_ ("Esta es mi critica", "lskdhjfksflksjdflksdlfkjslfk", puntu1, lib1, usu1);
                int crit2 = criticaCEN.New_ ("Esta NO es mi critica", "lalalalalalalla", puntu2, lib1, usu2);

                libroCP.Calcularmedia (lib1);
                LibroEN libroEN = libroCAD.ReadOIDDefault (lib1);
                System.Console.WriteLine (libroEN.Media);

                System.Console.WriteLine ("Haciendo Admin...");
                UsuarioCP usuarioCP = new UsuarioCP ();
                int adminOID = usuarioCP.HacerAdmin (usu3);
                AdministradorEN adminEN1 = administradorCEN.ReadOID (adminOID);
                System.Console.WriteLine (adminEN1.Nombre);

                System.Console.WriteLine ("Haciendo Baneo...");
                usuarioCP.Banear (usu1);
                System.Console.WriteLine (new UsuarioCAD ().ReadOIDDefault (usu1).Baneado);

                System.Console.WriteLine ("Creando Carritos...");
                CarritoCEN carritoCEN = new CarritoCEN ();
                int carrito1 = carritoCEN.New_ (0, 0, usu3, false);
                int carrito2 = carritoCEN.New_ (0, 0, usu2, false);
                CarritoCP carritoCP = new CarritoCP ();
                CarritoCAD carritoCAD = new CarritoCAD ();



                System.Console.WriteLine ("Creando L�neas de pedido...");
                LineaPedidoCEN lineaPedidoCEN = new LineaPedidoCEN ();
                //int linea1 = lineaPedidoCEN.New_ (1, usu2, lib1);
                //int linea2 = lineaPedidoCEN.New_ (1, usu2, lib2);
                //int linea3 = lineaPedidoCEN.New_ (1, usu3, lib2);
                LineaPedidoCAD lineaPedidoCAD = new LineaPedidoCAD ();
                IList<int> listlin = new List<int>();
                //listlin.Add (linea3);
                carritoCEN.AdjuntarlineaPedido (carrito1, listlin);

                IList<int> listlin2 = new List<int>();
                //listlin2.Add (linea1);
                //listlin2.Add (linea2);
                carritoCEN.AdjuntarlineaPedido (carrito2, listlin2);

                System.Console.WriteLine ("Calculando precio total de los carritos...");
                carritoCP.CalcularPrecio (carrito1);
                carritoCP.CalcularPrecio (carrito2);

                CarritoEN car1 = carritoCAD.ReadOID (carrito1);
                CarritoEN car2 = carritoCAD.ReadOID (carrito2);

                System.Console.WriteLine (car1.Precio);
                System.Console.WriteLine (car2.Precio);

                System.Console.WriteLine ("Procediendo a comprar...");
                carritoCP.ProcederCompra (carrito1);

                car1 = carritoCAD.ReadOID (carrito1);
                car2 = carritoCAD.ReadOID (carrito2);

                System.Console.WriteLine (car1.Estado);
                System.Console.WriteLine (car2.Estado);

                System.Console.WriteLine ("Creando Publicaciones...");
                PublicacionCEN publicacionCEN = new PublicacionCEN ();
                //int pubg1 = publicacionCEN.New_ ("Público", usu1);
                //int pubg2 = publicacionCEN.New_ ("Privado", usu1);




                // p.e. CustomerCEN customer = new CustomerCEN();
                // customer.New_ (p_user:"user", p_password:"1234");




                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
