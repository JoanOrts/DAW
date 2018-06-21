

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
 *      Definition of the class LibroCEN
 *
 */
public partial class LibroCEN
{
private ILibroCAD _ILibroCAD;

public LibroCEN()
{
        this._ILibroCAD = new LibroCAD ();
}

public LibroCEN(ILibroCAD _ILibroCAD)
{
        this._ILibroCAD = _ILibroCAD;
}

public ILibroCAD get_ILibroCAD ()
{
        return this._ILibroCAD;
}

public int New_ (string p_nombre, float p_precio, Nullable<DateTime> p_fecha, string p_descripcion, string p_portada, LibrerateGenNHibernate.Enumerated.Librerate.GeneroEnum p_genero, int p_numpag, string p_idioma, int p_media, System.Collections.Generic.IList<int> p_publicacion, int p_cantidadvendida, int p_usuario_0)
{
        LibroEN libroEN = null;
        int oid;

        //Initialized LibroEN
        libroEN = new LibroEN ();
        libroEN.Nombre = p_nombre;

        libroEN.Precio = p_precio;

        libroEN.Fecha = p_fecha;

        libroEN.Descripcion = p_descripcion;

        libroEN.Portada = p_portada;

        libroEN.Genero = p_genero;

        libroEN.Numpag = p_numpag;

        libroEN.Idioma = p_idioma;

        libroEN.Media = p_media;


        libroEN.Publicacion = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.PublicacionEN>();
        if (p_publicacion != null) {
                foreach (int item in p_publicacion) {
                        LibrerateGenNHibernate.EN.Librerate.PublicacionEN en = new LibrerateGenNHibernate.EN.Librerate.PublicacionEN ();
                        en.Id = item;
                        libroEN.Publicacion.Add (en);
                }
        }

        else{
                libroEN.Publicacion = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.PublicacionEN>();
        }

        libroEN.Cantidadvendida = p_cantidadvendida;


        if (p_usuario_0 != -1) {
                // El argumento p_usuario_0 -> Property usuario_0 es oid = false
                // Lista de oids id
                libroEN.Usuario_0 = new LibrerateGenNHibernate.EN.Librerate.UsuarioEN ();
                libroEN.Usuario_0.Id = p_usuario_0;
        }

        //Call to LibroCAD

        oid = _ILibroCAD.New_ (libroEN);
        return oid;
}

public void Modify (int p_Libro_OID, string p_nombre, float p_precio, Nullable<DateTime> p_fecha, string p_descripcion, string p_portada, LibrerateGenNHibernate.Enumerated.Librerate.GeneroEnum p_genero, int p_numpag, string p_idioma, int p_media, int p_cantidadvendida)
{
        LibroEN libroEN = null;

        //Initialized LibroEN
        libroEN = new LibroEN ();
        libroEN.Id = p_Libro_OID;
        libroEN.Nombre = p_nombre;
        libroEN.Precio = p_precio;
        libroEN.Fecha = p_fecha;
        libroEN.Descripcion = p_descripcion;
        libroEN.Portada = p_portada;
        libroEN.Genero = p_genero;
        libroEN.Numpag = p_numpag;
        libroEN.Idioma = p_idioma;
        libroEN.Media = p_media;
        libroEN.Cantidadvendida = p_cantidadvendida;
        //Call to LibroCAD

        _ILibroCAD.Modify (libroEN);
}

public void Destroy (int id
                     )
{
        _ILibroCAD.Destroy (id);
}

public LibroEN ReadOID (int id
                        )
{
        LibroEN libroEN = null;

        libroEN = _ILibroCAD.ReadOID (id);
        return libroEN;
}

public System.Collections.Generic.IList<LibroEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LibroEN> list = null;

        list = _ILibroCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerGenero (string p_genero)
{
        return _ILibroCAD.LeerGenero (p_genero);
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerUsuario (string p_usuario)
{
        return _ILibroCAD.LeerUsuario (p_usuario);
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerPrecio (string p_precio)
{
        return _ILibroCAD.LeerPrecio (p_precio);
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerNombre (string p_nombre)
{
        return _ILibroCAD.LeerNombre (p_nombre);
}
public void AsignarAlbum (int p_Libro_OID, System.Collections.Generic.IList<int> p_album_OIDs)
{
        //Call to LibroCAD

        _ILibroCAD.AsignarAlbum (p_Libro_OID, p_album_OIDs);
}
public void QuitardeAlbum (int p_Libro_OID, System.Collections.Generic.IList<int> p_album_OIDs)
{
        //Call to LibroCAD

        _ILibroCAD.QuitardeAlbum (p_Libro_OID, p_album_OIDs);
}
}
}
