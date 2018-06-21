
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;



/*PROTECTED REGION ID(usingLibrerateGenNHibernate.CP.Librerate_Usuario_hacerAdmin) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace LibrerateGenNHibernate.CP.Librerate
{
public partial class UsuarioCP : BasicCP
{
public int HacerAdmin (int p_oid)
{
        /*PROTECTED REGION ID(LibrerateGenNHibernate.CP.Librerate_Usuario_hacerAdmin) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;
        AdministradorCAD administradorCAD = null;
        AdministradorCEN administradorCEN = null;
        int admin = 0;

        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new UsuarioCEN (usuarioCAD);
                administradorCAD = new AdministradorCAD (session);
                administradorCEN = new AdministradorCEN (administradorCAD);

                // Write here your custom transaction ...
                UsuarioEN usuarioEN = usuarioCAD.ReadOIDDefault (p_oid);
                if (usuarioEN.Administrador == null) {
                        //AdministradorCEN administradorCEN2 = new AdministradorCEN();
                        admin = administradorCEN.New_ (usuarioEN.Nombre, usuarioEN.Email, DateTime.Now, usuarioEN.Id, usuarioEN.Contrasena);
                }
                SessionCommit ();
                return admin;
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }



        /*PROTECTED REGION END*/
}
}
}
