

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
 *      Definition of the class PublicacionCEN
 *
 */
public partial class PublicacionCEN
{
private IPublicacionCAD _IPublicacionCAD;

public PublicacionCEN()
{
        this._IPublicacionCAD = new PublicacionCAD ();
}

public PublicacionCEN(IPublicacionCAD _IPublicacionCAD)
{
        this._IPublicacionCAD = _IPublicacionCAD;
}

public IPublicacionCAD get_IPublicacionCAD ()
{
        return this._IPublicacionCAD;
}

public int New_ (string p_nombre, int p_usuario, int p_NumPag)
{
        PublicacionEN publicacionEN = null;
        int oid;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();
        publicacionEN.Nombre = p_nombre;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                publicacionEN.Usuario = new LibrerateGenNHibernate.EN.Librerate.UsuarioEN ();
                publicacionEN.Usuario.Id = p_usuario;
        }

        publicacionEN.NumPag = p_NumPag;

        //Call to PublicacionCAD

        oid = _IPublicacionCAD.New_ (publicacionEN);
        return oid;
}

public void Modify (int p_Publicacion_OID, string p_nombre, int p_NumPag)
{
        PublicacionEN publicacionEN = null;

        //Initialized PublicacionEN
        publicacionEN = new PublicacionEN ();
        publicacionEN.Id = p_Publicacion_OID;
        publicacionEN.Nombre = p_nombre;
        publicacionEN.NumPag = p_NumPag;
        //Call to PublicacionCAD

        _IPublicacionCAD.Modify (publicacionEN);
}

public void Destroy (int id
                     )
{
        _IPublicacionCAD.Destroy (id);
}

public PublicacionEN ReadOID (int id
                              )
{
        PublicacionEN publicacionEN = null;

        publicacionEN = _IPublicacionCAD.ReadOID (id);
        return publicacionEN;
}

public System.Collections.Generic.IList<PublicacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PublicacionEN> list = null;

        list = _IPublicacionCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> LeerNombre (string p_nombre)
{
        return _IPublicacionCAD.LeerNombre (p_nombre);
}
}
}
