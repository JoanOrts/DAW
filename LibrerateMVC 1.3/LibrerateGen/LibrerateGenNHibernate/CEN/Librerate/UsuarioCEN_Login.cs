
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


/*PROTECTED REGION ID(usingLibrerateGenNHibernate.CEN.Librerate_Usuario_login) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace LibrerateGenNHibernate.CEN.Librerate
{
public partial class UsuarioCEN
{
public bool Login (string p_email, string p_contrasena)
{
        /*PROTECTED REGION ID(LibrerateGenNHibernate.CEN.Librerate_Usuario_login) ENABLED START*/

        // Write here your custom code...

        Boolean logeado = false;
        UsuarioEN usuario = null;

        usuario = _IUsuarioCAD.ReadOID (p_oid);

        if (usuario != null) { //SI EL USUARIO EXISTE (NO ES NULL)
                if (usuario.Nombre == p_nombre && usuario.Contrasena == Utils.Util.GetEncondeMD5 (p_contrasena)) {
                        //LOGIN CORRECTO
                        System.Console.WriteLine ("Login de " + usuario.Nombre + " correcto");
                        logeado = true;
                }
        }
        else //NO SE HA PODIDO CREAR EL OBJETO UsuarioEN Y POR TANTO, 'usuario' VALE NULL
                throw new Exception ("El nombre de usuario o la clave son incorrectos");


        return logeado;

        /*PROTECTED REGION END*/
}
}
}
