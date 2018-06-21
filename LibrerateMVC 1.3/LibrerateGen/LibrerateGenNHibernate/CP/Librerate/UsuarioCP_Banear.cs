
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;



/*PROTECTED REGION ID(usingLibrerateGenNHibernate.CP.Librerate_Usuario_banear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace LibrerateGenNHibernate.CP.Librerate
{
public partial class UsuarioCP : BasicCP
{
public void Banear (int p_oid)
{
        /*PROTECTED REGION ID(LibrerateGenNHibernate.CP.Librerate_Usuario_banear) ENABLED START*/

        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;



        try
        {
                SessionInitializeTransaction ();
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new UsuarioCEN (usuarioCAD);



                // Write here your custom transaction ...

                UsuarioEN usuarioEN = usuarioCAD.ReadOIDDefault (p_oid);

                if (usuarioEN.Baneado == false) {
                        usuarioEN.Baneado = true;
                }
                usuarioCAD.Modify (usuarioEN);
                SessionCommit ();
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
