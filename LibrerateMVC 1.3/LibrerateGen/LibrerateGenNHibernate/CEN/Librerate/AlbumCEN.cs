

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
 *      Definition of the class AlbumCEN
 *
 */
public partial class AlbumCEN
{
private IAlbumCAD _IAlbumCAD;

public AlbumCEN()
{
        this._IAlbumCAD = new AlbumCAD ();
}

public AlbumCEN(IAlbumCAD _IAlbumCAD)
{
        this._IAlbumCAD = _IAlbumCAD;
}

public IAlbumCAD get_IAlbumCAD ()
{
        return this._IAlbumCAD;
}

public int New_ (string p_titulo, string p_descripcion, int p_cantidad, int p_usuario)
{
        AlbumEN albumEN = null;
        int oid;

        //Initialized AlbumEN
        albumEN = new AlbumEN ();
        albumEN.Titulo = p_titulo;

        albumEN.Descripcion = p_descripcion;

        albumEN.Cantidad = p_cantidad;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                albumEN.Usuario = new LibrerateGenNHibernate.EN.Librerate.UsuarioEN ();
                albumEN.Usuario.Id = p_usuario;
        }

        //Call to AlbumCAD

        oid = _IAlbumCAD.New_ (albumEN);
        return oid;
}

public void Modify (int p_Album_OID, string p_titulo, string p_descripcion, int p_cantidad)
{
        AlbumEN albumEN = null;

        //Initialized AlbumEN
        albumEN = new AlbumEN ();
        albumEN.Id = p_Album_OID;
        albumEN.Titulo = p_titulo;
        albumEN.Descripcion = p_descripcion;
        albumEN.Cantidad = p_cantidad;
        //Call to AlbumCAD

        _IAlbumCAD.Modify (albumEN);
}

public void Destroy (int id
                     )
{
        _IAlbumCAD.Destroy (id);
}

public AlbumEN ReadOID (int id
                        )
{
        AlbumEN albumEN = null;

        albumEN = _IAlbumCAD.ReadOID (id);
        return albumEN;
}

public System.Collections.Generic.IList<AlbumEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AlbumEN> list = null;

        list = _IAlbumCAD.ReadAll (first, size);
        return list;
}
public void AnyadirLibroAlbum (int p_Album_OID, System.Collections.Generic.IList<int> p_libro_OIDs)
{
        //Call to AlbumCAD

        _IAlbumCAD.AnyadirLibroAlbum (p_Album_OID, p_libro_OIDs);
}
public void QuitarLibroAlbum (int p_Album_OID, System.Collections.Generic.IList<int> p_libro_OIDs)
{
        //Call to AlbumCAD

        _IAlbumCAD.QuitarLibroAlbum (p_Album_OID, p_libro_OIDs);
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> LeerNombre (string p_nombre)
{
        return _IAlbumCAD.LeerNombre (p_nombre);
}
}
}
