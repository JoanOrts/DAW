

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LibrerateGenNHibernate.Exceptions;

using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;


namespace LibrerateGenNHibernate.CEN.Librerate
{
/*
 *      Definition of the class AdministradorCEN
 *
 */
public partial class AdministradorCEN
{
private IAdministradorCAD _IAdministradorCAD;

public AdministradorCEN()
{
        this._IAdministradorCAD = new AdministradorCAD ();
}

public AdministradorCEN(IAdministradorCAD _IAdministradorCAD)
{
        this._IAdministradorCAD = _IAdministradorCAD;
}

public IAdministradorCAD get_IAdministradorCAD ()
{
        return this._IAdministradorCAD;
}

public int New_ (string p_nombre, string p_email, Nullable<DateTime> p_fecha, int p_usuario, String p_contrasena)
{
        AdministradorEN administradorEN = null;
        int oid;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Nombre = p_nombre;

        administradorEN.Email = p_email;

        administradorEN.Fecha = p_fecha;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                administradorEN.Usuario = new LibrerateGenNHibernate.EN.Librerate.UsuarioEN ();
                administradorEN.Usuario.Id = p_usuario;
        }

        administradorEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);

        //Call to AdministradorCAD

        oid = _IAdministradorCAD.New_ (administradorEN);
        return oid;
}

public void Modify (int p_Administrador_OID, string p_nombre, string p_email, Nullable<DateTime> p_fecha, String p_contrasena)
{
        AdministradorEN administradorEN = null;

        //Initialized AdministradorEN
        administradorEN = new AdministradorEN ();
        administradorEN.Id = p_Administrador_OID;
        administradorEN.Nombre = p_nombre;
        administradorEN.Email = p_email;
        administradorEN.Fecha = p_fecha;
        administradorEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);
        //Call to AdministradorCAD

        _IAdministradorCAD.Modify (administradorEN);
}

public void Destroy (int id
                     )
{
        _IAdministradorCAD.Destroy (id);
}

public AdministradorEN ReadOID (int id
                                )
{
        AdministradorEN administradorEN = null;

        administradorEN = _IAdministradorCAD.ReadOID (id);
        return administradorEN;
}

public System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdministradorEN> list = null;

        list = _IAdministradorCAD.ReadAll (first, size);
        return list;
}
}
}
