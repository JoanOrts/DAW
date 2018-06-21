

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
 *      Definition of the class UsuarioCEN
 *
 */
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public int New_ (string p_nombre, string p_email, Nullable<DateTime> p_fecha, String p_contrasena, bool p_baneado, string p_imagen)
{
        UsuarioEN usuarioEN = null;
        int oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Nombre = p_nombre;

        usuarioEN.Email = p_email;

        usuarioEN.Fecha = p_fecha;

        usuarioEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);

        usuarioEN.Baneado = p_baneado;

        usuarioEN.Imagen = p_imagen;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.New_ (usuarioEN);
        return oid;
}

public void Modify (int p_Usuario_OID, string p_nombre, string p_email, Nullable<DateTime> p_fecha, String p_contrasena, bool p_baneado, string p_imagen)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.Id = p_Usuario_OID;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Email = p_email;
        usuarioEN.Fecha = p_fecha;
        usuarioEN.Contrasena = Utils.Util.GetEncondeMD5 (p_contrasena);
        usuarioEN.Baneado = p_baneado;
        usuarioEN.Imagen = p_imagen;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modify (usuarioEN);
}

public void Destroy (int id
                     )
{
        _IUsuarioCAD.Destroy (id);
}

public UsuarioEN ReadOID (int id
                          )
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.ReadOID (id);
        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> LeerNombre (string p_nombre)
{
        return _IUsuarioCAD.LeerNombre (p_nombre);
}
public void SeguirAutor (int p_Usuario_OID, int p_autor_OID)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.SeguirAutor (p_Usuario_OID, p_autor_OID);
}
public void DeseguirAutor (int p_Usuario_OID, int p_autor_OID)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.DeseguirAutor (p_Usuario_OID, p_autor_OID);
}
public void AnyadirLibro (int p_Usuario_OID, System.Collections.Generic.IList<int> p_libro_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.AnyadirLibro (p_Usuario_OID, p_libro_OIDs);
}
public void QuitarLibro (int p_Usuario_OID, System.Collections.Generic.IList<int> p_libro_OIDs)
{
        //Call to UsuarioCAD

        _IUsuarioCAD.QuitarLibro (p_Usuario_OID, p_libro_OIDs);
}
public LibrerateGenNHibernate.EN.Librerate.UsuarioEN LeerEmail (string p_email)
{
        return _IUsuarioCAD.LeerEmail (p_email);
}
}
}
