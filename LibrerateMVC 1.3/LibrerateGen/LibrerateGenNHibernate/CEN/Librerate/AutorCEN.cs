

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
 *      Definition of the class AutorCEN
 *
 */
public partial class AutorCEN
{
private IAutorCAD _IAutorCAD;

public AutorCEN()
{
        this._IAutorCAD = new AutorCAD ();
}

public AutorCEN(IAutorCAD _IAutorCAD)
{
        this._IAutorCAD = _IAutorCAD;
}

public IAutorCAD get_IAutorCAD ()
{
        return this._IAutorCAD;
}

public int New_ (float p_ganancias, string p_email, Nullable<DateTime> p_fecha, int p_usuario, string p_nombre)
{
        AutorEN autorEN = null;
        int oid;

        //Initialized AutorEN
        autorEN = new AutorEN ();
        autorEN.Ganancias = p_ganancias;

        autorEN.Email = p_email;

        autorEN.Fecha = p_fecha;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                autorEN.Usuario = new LibrerateGenNHibernate.EN.Librerate.UsuarioEN ();
                autorEN.Usuario.Id = p_usuario;
        }

        autorEN.Nombre = p_nombre;

        //Call to AutorCAD

        oid = _IAutorCAD.New_ (autorEN);
        return oid;
}

public void Modify (int p_Autor_OID, float p_ganancias, string p_email, Nullable<DateTime> p_fecha, string p_nombre)
{
        AutorEN autorEN = null;

        //Initialized AutorEN
        autorEN = new AutorEN ();
        autorEN.Id = p_Autor_OID;
        autorEN.Ganancias = p_ganancias;
        autorEN.Email = p_email;
        autorEN.Fecha = p_fecha;
        autorEN.Nombre = p_nombre;
        //Call to AutorCAD

        _IAutorCAD.Modify (autorEN);
}

public void Destroy (int id
                     )
{
        _IAutorCAD.Destroy (id);
}

public AutorEN ReadOID (int id
                        )
{
        AutorEN autorEN = null;

        autorEN = _IAutorCAD.ReadOID (id);
        return autorEN;
}

public System.Collections.Generic.IList<AutorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AutorEN> list = null;

        list = _IAutorCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AutorEN> LeerNombre (string p_nombre)
{
        return _IAutorCAD.LeerNombre (p_nombre);
}
}
}
