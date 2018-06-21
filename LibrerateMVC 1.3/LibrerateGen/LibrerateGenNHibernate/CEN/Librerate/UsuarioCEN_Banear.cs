
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LibrerateGenNHibernate.Exceptions;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;


/*PROTECTED REGION ID(usingLibrerateGenNHibernate.CEN.Librerate_Usuario_banear) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace LibrerateGenNHibernate.CEN.Librerate
{
public partial class UsuarioCEN
{
public void Banear (int p_oid)
{
        /*PROTECTED REGION ID(LibrerateGenNHibernate.CEN.Librerate_Usuario_banear) ENABLED START*/

        // Write here your custom code...
        
        IUsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null; 
    
            try
            {
                SessionInitializeTransaction();
                usuarioCAD = new UsuarioCAD(session);
                usuarioCEN = new UsuarioCEN(carritoCAD);
                UsuarioEN usuarioEN = usuarioCAD.ReadOIDDefault(p_oid);

                if (usuarioEN.baneado == false)
                {
                    usuarioEN.baneado = true;
                }

                SessionCommit();
            }
            catch (Exception ex)
            {
                SessionRollBack();
                throw ex;
            }
            finally
            {
                SessionClose();
            }

        throw new NotImplementedException ("Method Banear() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
