
using System;
// Definición clase AlbumEN
namespace LibrerateGenNHibernate.EN.Librerate
{
public partial class AlbumEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo titulo
 */
private string titulo;



/**
 *	Atributo descripcion
 */
private string descripcion;



/**
 *	Atributo cantidad
 */
private int cantidad;



/**
 *	Atributo usuario
 */
private LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario;



/**
 *	Atributo libro
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> libro;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Titulo {
        get { return titulo; } set { titulo = value;  }
}



public virtual string Descripcion {
        get { return descripcion; } set { descripcion = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> Libro {
        get { return libro; } set { libro = value;  }
}





public AlbumEN()
{
        libro = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.LibroEN>();
}



public AlbumEN(int id, string titulo, string descripcion, int cantidad, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> libro
               )
{
        this.init (Id, titulo, descripcion, cantidad, usuario, libro);
}


public AlbumEN(AlbumEN album)
{
        this.init (Id, album.Titulo, album.Descripcion, album.Cantidad, album.Usuario, album.Libro);
}

private void init (int id
                   , string titulo, string descripcion, int cantidad, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> libro)
{
        this.Id = id;


        this.Titulo = titulo;

        this.Descripcion = descripcion;

        this.Cantidad = cantidad;

        this.Usuario = usuario;

        this.Libro = libro;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AlbumEN t = obj as AlbumEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
