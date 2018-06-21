
using System;
// Definición clase PublicacionEN
namespace LibrerateGenNHibernate.EN.Librerate
{
public partial class PublicacionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo usuario
 */
private LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario;



/**
 *	Atributo libro
 */
private LibrerateGenNHibernate.EN.Librerate.LibroEN libro;



/**
 *	Atributo numPag
 */
private int numPag;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.LibroEN Libro {
        get { return libro; } set { libro = value;  }
}



public virtual int NumPag {
        get { return numPag; } set { numPag = value;  }
}





public PublicacionEN()
{
}



public PublicacionEN(int id, string nombre, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, LibrerateGenNHibernate.EN.Librerate.LibroEN libro, int numPag
                     )
{
        this.init (Id, nombre, usuario, libro, numPag);
}


public PublicacionEN(PublicacionEN publicacion)
{
        this.init (Id, publicacion.Nombre, publicacion.Usuario, publicacion.Libro, publicacion.NumPag);
}

private void init (int id
                   , string nombre, LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuario, LibrerateGenNHibernate.EN.Librerate.LibroEN libro, int numPag)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Usuario = usuario;

        this.Libro = libro;

        this.NumPag = numPag;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PublicacionEN t = obj as PublicacionEN;
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
